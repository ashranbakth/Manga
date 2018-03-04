using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Comic_Book.Models;

namespace Comic_Book.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
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

        public IActionResult Detail()
        {
            var manga = new Manga()
            {
                id = 1,
                title = "Naruto",
                summary = "<p>Twelve years before the start of the series, a powerful " +
                     "creature known as the Nine-tailed Demon Fox attacked the ninja " +
                     "village Konohagakure, decimating many people. In response, the leader " +
                     "of Konohagakure's ninja military - <strong> theFourth Hokage </strong> - sacrificed " +
                     "his life to seal the demon inside his newly born child Naruto " +
                     "Uzumaki. Konohagakure, however, regarded Naruto as if he were the demon " +
                     "fox itself and mistreated him throughout most of his childhood. " +
                     "The plot tells the story of Naruto Uzumaki, now a adolescent ninja " +
                     "who constantly searches for recognition and dreams to become the " +
                     "Hokage, the ninja in his village who is acknowledged as the leader and the strongest of all. </p>", 
                characters = new string[]{
                    "Naruto",
                    "Sasuke",
                    "Sakura",
                    "Hinata",
                },
                favorite = false

            };

            return View(manga);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
