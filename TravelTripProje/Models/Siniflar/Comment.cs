using System.ComponentModel.DataAnnotations;

namespace TravelTripProje.Models.Siniflar
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string CommentContent { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }

    }
}