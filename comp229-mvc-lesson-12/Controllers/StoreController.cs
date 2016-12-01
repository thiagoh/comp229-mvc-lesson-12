using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using comp229_mvc_lesson_12.Models;

namespace comp229_mvc_lesson_12.Controllers {
    public class StoreController : Controller {
        private MVCMusicStoreContext db = new MVCMusicStoreContext();

        // GET: Store
        public ActionResult Index() {
            /*
            List<Genre> genres = new List<Genre>
            {
                new Genre("Disco"),
                new Genre("Jazz"),
                new Genre("Rock"),
                new Genre("Electronic")
            }; */

            return View(db.Genres.ToList());
        }

        // GET: Store/Browse?genre=Disco
        public ActionResult Browse(string genre) {
            if (genre == null) {
                genre = "Disco";
            }

            Genre genreModel = db.Genres.Include("Albums").Single(g => g.Name == genre);

            return View(genreModel);
        }

        // GET: Store/Details/5
        public ActionResult Details(int? id = 1) {
            Album album = db.Albums.Find(id);

            return View(album);
        }


    }
}
