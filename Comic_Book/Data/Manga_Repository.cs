using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Comic_Book.Models;

namespace Comic_Book.Data
{
    public class Manga_Repository
    {
        private static Manga[] _manga = new Manga[]{

            new Manga()
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

            }, 

            new Manga(){
                id = 2,
                title = "Bleach", 
                summary = "<p>Bleach follows the adventures of <strong>Ichigo Kurosaki</strong> after he " +
                    "obtains the powers of a Soul Reaper —a death " +
                    "personification similar to the Grim Reaper—from another " +
                    "Soul Reaper, Rukia Kuchiki. His newfound powers force him " +
                    "to take on the duties of defending humans from evil spirits " +
                    "and guiding departed souls to the afterlife. What the Bleach " +
                    "manga attracted us is not the novel lot, but the " +
                    "interpretation about the fate of Ichigo Kurosaki, a young " +
                    "who stay with the sad memories. The Bleach tried to outline " +
                    "the story out with a lot of memories and dialogues, slowly but implicative.</p>",
                characters = new string[]{
                    "Ichigo", 
                    "Rukia",
                    "Uryu",
                    "Orihime",
                    "Yasutora",
                    "Renji",
                },
                favorite = false
            }

        };

        public Manga[] GetMangas()
        {
            return _manga;
        }

        public Manga GetManga(int id)
        {
            Manga mangatoreturn = null;

            foreach (var manga in _manga)
            {
                if(manga.id == id){
                    mangatoreturn = manga;
                    break;
                }
            }

            return mangatoreturn;
        }
    }
}
