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

        public static void GetMovieTitle(string userSelection, List<Movie> movieList)
        {
            List<Movie> selectedMovies = movieList.FindAll(m => m.Category == userSelection);

            foreach (var title in selectedMovies)
            {
                Console.WriteLine(title.Title);
            }

            switch (userSelection)
            {
                case "animated":
                {

                 

                   // animatedMovie.ForEach(Console.WriteLine);

                    break;
                }
                case "drama":
                {

                    break;
                }
                case "horror":
                {
                    break;
                }
                case "scifi":
                {

                    break;
                }
                default:
                {
                    Console.WriteLine(value: "That category doesn't exist.");
                    break;
                }
            }
        }
    }
}
