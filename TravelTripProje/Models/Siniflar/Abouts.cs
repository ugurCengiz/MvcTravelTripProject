using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Siniflar
{
    public class Abouts
    {
        [Key]
        public int ID { get; set; }
        public string PhotoUrl { get; set; }
        public string Explanation { get; set; }
    }
}