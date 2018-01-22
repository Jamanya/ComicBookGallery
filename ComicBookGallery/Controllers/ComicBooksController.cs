using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Data;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers {


    public class ComicBooksController : Controller {

        private ComicBookRepository _comicBookRespository = null;

        public ComicBooksController()
        {
            _comicBookRespository = new ComicBookRepository();
        }

        // GET: ComicBooks
        public ActionResult Detail(int? id) {

            if(id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookRespository.GetComicBook(id.Value);

            return View(comicBook);
        }
    }
}