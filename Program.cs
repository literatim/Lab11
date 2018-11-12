using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!");

            List<Movie> movieList = new List<Movie>();

            // James - I really like that you are using constuctors here, makes the code much easier to read. 
            movieList.Add(new Movie(movieTitle: "Star Wars", movieCategory: "scifi"));
            movieList.Add(new Movie(movieTitle:"2001: A Space Odyssey", movieCategory: "scifi"));
            movieList.Add(new Movie(movieTitle:"E.T. The Extra-Terrestrial", movieCategory: "scifi"));
            movieList.Add(new Movie(movieTitle:"A Clockwork Orange", movieCategory: "scifi"));
            movieList.Add(new Movie(movieTitle:"Close Encounters of the Third Kind", movieCategory: "scifi"));
            movieList.Add(new Movie(movieTitle:"Spirited Away", movieCategory: "animated"));
            movieList.Add(new Movie(movieTitle:"The Godfather", movieCategory: "drama"));
            movieList.Add(new Movie(movieTitle:"Get Out", movieCategory: "horror"));
            movieList.Add(new Movie(movieTitle:"Psycho", movieCategory: "horror"));
            movieList.Add(new Movie(movieTitle:"My Neighbor Totoro", movieCategory: "animated"));

            Console.WriteLine($"There are {movieList.Count} movies in this list.");
            do
            {
                Console.WriteLine("What category are you interested in? You can say 'animated', 'drama', 'horror', or 'scifi': ");

                var userSelection = GetUserInput();

                Movie.GetMovieTitle(userSelection.ToLower(), movieList);

                Console.WriteLine($"Do you want to continue? (y/n)");

            } while (Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase));

            string GetUserInput()
            {
                string input = Console.ReadLine();
                while (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Category cannot be blank.");
                    Console.WriteLine("You can say 'animated', 'drama', 'horror', or 'scifi': ");
                }

                return input;
            }
        }
    }
}
