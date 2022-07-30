using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        public string NameSurName { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}