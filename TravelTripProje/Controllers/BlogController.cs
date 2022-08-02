using System.Linq;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        private Context c = new Context();
        private BlogComment bi = new BlogComment();
        public ActionResult Index()
        {
            //var bloglar = c.Blogs.ToList();
            bi.Deger1 = c.Blogs.ToList();
            bi.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();

            return View(bi);
        }

        private BlogComment by = new BlogComment();
        public ActionResult BlogDetail(int id)
        {

            //var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Comments.Where(x => x.BlogId == id).ToList();
            return View(by);

        }

        [HttpGet]
        public PartialViewResult YorumYap(int? id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        
        [HttpPost]
        public PartialViewResult YorumYap(Comment y)
        {

            c.Comments.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}