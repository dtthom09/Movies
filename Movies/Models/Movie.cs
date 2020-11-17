using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Genre { get; set; }
        public List<string> Actors { get; set; }
        public string Description { get; set; }
        public List<string> Directors { get; set; }
    }
}