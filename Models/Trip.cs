using System;
using System.ComponentModel.DataAnnotations;

namespace TripLog.Models
{
    public class Trip
    {
        public int TripID { get; set; }

        [Required(ErrorMessage = "Please enter a Destination")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Please enter a Start Date")]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "Please enter an End Date ")]
        public DateTime? EndDate { get; set; }

        public string AccommodationName { get; set; }

        public string AccommodationPhone { get; set; }

        public string AccommodationEmail { get; set; }

        public string ThingToDo1 { get; set; }

        public string ThingToDo2 { get; set; }

        public string ThingToDo3 { get; set; }

    }
}
