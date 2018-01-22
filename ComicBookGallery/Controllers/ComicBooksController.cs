using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {




        // GET: ComicBooks
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "Hogans Hero's";
            ViewBag.IssueNumber = 1;
            ViewBag.Description = "<p>The first issue ever</p>";
            ViewBag.Artists = new string[]
            {
                 "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };


            return View();
        }
    }
}