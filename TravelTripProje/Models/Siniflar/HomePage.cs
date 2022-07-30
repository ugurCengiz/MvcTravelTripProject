using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class HomePage
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Explanation { get; set; }
    }
}