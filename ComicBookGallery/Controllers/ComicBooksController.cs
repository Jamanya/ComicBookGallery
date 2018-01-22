using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers {


    public class ComicBooksController : Controller {

        // GET: ComicBooks
        public ActionResult Detail() {
            var comicBook = new ComicBook() {

                SeriesTitle = "Hogans Hero's",
                IssueNumber = 1,
                DescriptionHtml = "<p>The first issue ever </p>",
                Artists = new Artists[]
                {
                    new Artists() { Name= "Dan Slott", Role= "Script"},
                    new Artists() { Name= "Humberto Ramos", Role= "Pencils"},
                    new Artists() { Name= "Victor Olazaba", Role= "Inks"},
                    new Artists() { Name= "Edgar Delgado", Role= "Colors"},
                    new Artists() { Name= "Chris Eliopoulos", Role= "Letters"},
                }

            };
            return View(comicBook);
        }
    }
}