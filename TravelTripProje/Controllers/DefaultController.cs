using System.Linq;
using System.Web.Mvc;
using TravelTripProje.Controllers;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        // GET: Default
        public ActionResult Index()
        {
           
            var values = c.Blogs.Take(8).ToList();
            return View(values);
        }

        public ActionResult About()
        {

            return View();
        }

        public PartialViewResult Partial1()
        {
            var values = c.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial2()
        {
            var values = c.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView (values);
        }

        public PartialViewResult Partial3()
        {
            var values = c.Blogs.Take(10).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial4()
        {
            var values = c.Blogs.Take(4).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial5()
        {
            var values = c.Blogs.OrderByDescending(x=>x.ID).Take(4).ToList();
            return PartialView(values);
        }

    }
}