using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Explanation { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Comment> Comments { get; set; }




    }
}