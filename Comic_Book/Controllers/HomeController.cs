using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Comic_Book.Models;
using Comic_Book.Data;

namespace Comic_Book.Controllers
{
    public class HomeController : Controller
    {
        private Manga_Repository _mangaRepository = null;

        public HomeController()
        {
            _mangaRepository = new Manga_Repository();
        }
        
        public IActionResult Index()
        {
            var mangas = _mangaRepository.GetMangas();
            return View(mangas);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Manga Website Description";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Genre(){
            
            return View();
        }
        public IActionResult Detail(int? id)
        {
            if(id == null)
            {
                return NotFound("HTTP Error 404 - Not Found");
                //used to be return HttpNotFound(); before asp.net core
            }
            var manga = _mangaRepository.GetManga((int)id);

            return View(manga);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
