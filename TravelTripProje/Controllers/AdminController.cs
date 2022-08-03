using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        private Context c = new Context();

        [Authorize]
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog p)
        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir", bl);
        }

        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Explanation = b.Explanation;
            blg.Title = b.Title;
            blg.BlogImage = b.BlogImage;
            blg.Date = b.Date;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YorumListesi()
        {
            var comments = c.Comments.ToList();
            return View(comments);
        }

        public ActionResult YorumSil(int id)
        {
            var b = c.Comments.Find(id);
            c.Comments.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumGetir(int id)
        {
            var yr = c.Comments.Find(id);
            return View("YorumGetir", yr);
        }

        public ActionResult YorumGüncelle(Comment y)
        {
            var yrm = c.Comments.Find(y.ID);
            yrm.UserName = y.UserName;
            yrm.CommentContent = y.CommentContent;
            yrm.Mail = y.Mail;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }




    }
}