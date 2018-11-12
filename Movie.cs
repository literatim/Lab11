using System;
using System.Collections.Generic;
using System.Linq;

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

        // James - glad to see this is just one method, one method to handle all movie selections, good job
        // I would consider changing the return type for this method, like returning a movie object or a string.
        // Doing this will keep your app loosely coupled from a console app.  like what if you want to use this
        // class in a web app? well it has methods that point directly to a console, so they are tightly coupled 
        // right now.  This is mostly just a design suggestion, otherwise, good job.
        public static void GetMovieTitle(string userSelection, List<Movie> movieList)
        {
            List<Movie> selectedMovies = movieList.FindAll(m => m.Category == userSelection);

            if (!selectedMovies.Any())
            {
                Console.WriteLine("That category doesn't exist.");
                return;
            }

            foreach (var movie in selectedMovies)
            {
                Console.WriteLine(movie.Title);
            }
        }
    }
}
