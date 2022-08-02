using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Siniflar
{
    public class AddressBlog
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
        public string OpenAddress { get; set; }
        public string Mail { get; set; }
        public string Telephone { get; set; }
        public string Location { get; set; }

    }
}