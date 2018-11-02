using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        private string Title { get; set; }
        private string Category { get; set; }

        public Movie(string movieTitle, string movieCategory)
        {
            Title = movieTitle;
            Category = movieCategory;
        }
    }
}
