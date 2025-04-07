using System.ComponentModel.DataAnnotations;

namespace EventEase3.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int VenueId { get; set; }
        public int EventId { get; set; }
        [Display(Name = "Booking Date")]
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }
        public Venue? Venue { get; set; }
        public Event? Event { get; set; }
    }
}
