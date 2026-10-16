using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RaceDay.API.Models
{
    public class Result
    {
        [Key]
        public int ResultId { get; set; }

        public int ParticipantId { get; set; }

        [ForeignKey("ParticipantId")]
        public User? Participant { get; set; }

        public int EventId { get; set; }

        [ForeignKey("EventId")]
        public Event? Event { get; set; }

        public TimeSpan FinishTime { get; set; }

        public int FinishingPosition { get; set; }

        public DateTime RecordedAt { get; set; } = DateTime.UtcNow;
    }
}