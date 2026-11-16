using Microsoft.AspNetCore.Mvc;

namespace RaceDay.MVC.Controller
{
    public class ParticipantController : Controller
    {
        public IActionResult Index()
        {
            // Security Check: Only allow Participants
            if (HttpContext.Session.GetString("UserRole") != "Participant")
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
    }
}