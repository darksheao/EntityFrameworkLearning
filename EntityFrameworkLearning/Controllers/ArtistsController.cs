using EntityFrameworkLearning.Models;
using EntityFrameworkLearning.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkLearning.Controllers
{
    public class ArtistsController : Controller
    {
        //MusicStoreContext context = new MusicStoreContext();
        ArtistRepository repo = new ArtistRepository();

        // GET: Artists
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult Create(Artist artist)
        {
            if(!ModelState.IsValid) { return View(artist); }

            repo.Add(artist);
            repo.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Artist artist = repo.Get(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(artist);
            }
        }
    }
}