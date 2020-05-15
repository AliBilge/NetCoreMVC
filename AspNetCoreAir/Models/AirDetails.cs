using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreAir.Models
{
    public class AirDetails
    {
        public Guid Id { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string Airliners { get; set; }
        [Required]
        public int Numbers { get; set; }
    }
}