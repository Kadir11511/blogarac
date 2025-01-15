using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using triptravel.Models.Siniflar;

namespace triptravel.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogYorum by = new BlogYorum();
        Context c = new Context();
        public ActionResult Index()
        {
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();

            return View(by);
        }


        public ActionResult BlogDetay(int id)
        {

            //var blogbul=c.Blogs.Where(x=>x.ID==id).ToList();
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            by.Deger4 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            var blog = c.Blogs.FirstOrDefault(x => x.ID == id);
            if (blog != null)
            {
                by.VideoUrl = blog.VideoUrl;
            }

            return View(by);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}