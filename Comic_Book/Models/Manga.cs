using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace Comic_Book.Models
{
    public class Manga
    {
        public int id { get; set; }
        public string title { get; set; }
        public string summary { get; set; }
        public string[] Characters { get; set; }
        public bool Favorite { get; set; }

    }
}
