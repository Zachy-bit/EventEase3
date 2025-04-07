using System.ComponentModel.DataAnnotations;

namespace EventEase3.Models
{
    public class Venue
    {
        public int VenueId { get; set; }
        [Display(Name = "Venue Name")]
        public string? VenueName { get; set; }
        public string? VenueLocal { get; set; }
        public int VenueCap { get; set; }
        public string? VenueImgURL { get; set; }
        public List<Booking>? Bookings { get; set; }

    }
}
