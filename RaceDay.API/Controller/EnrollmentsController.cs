using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RaceDay.API.Data;
using RaceDay.API.Models;

namespace RaceDay.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EnrollmentsController : ControllerBase
    {
        private readonly RaceDayDbContext _context;

        public EnrollmentsController(RaceDayDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Authorize(Roles = "Participant")]
        public async Task<IActionResult> Enroll([FromBody] Enrollment enrollment)
        {
            var userId = int.Parse(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value ?? "0");
            enrollment.ParticipantId = userId;
            enrollment.EnrolledAt = DateTime.UtcNow;
            _context.Enrollments.Add(enrollment);
            await _context.SaveChangesAsync();
            return Ok(enrollment);
        }

        [HttpGet("my")]
        [Authorize(Roles = "Participant")]
        public async Task<IActionResult> GetMyEnrollments()
        {
            var userId = int.Parse(User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value ?? "0");
            return Ok(await _context.Enrollments
                .Include(e => e.Event)
                .Where(e => e.ParticipantId == userId)
                .ToListAsync());
        }

        [HttpGet("event/{eventId}")]
        [Authorize(Roles = "Organiser")]
        public async Task<IActionResult> GetByEvent(int eventId)
        {
            return Ok(await _context.Enrollments
                .Include(e => e.Participant)
                .Where(e => e.EventId == eventId)
                .ToListAsync());
        }
    }
}