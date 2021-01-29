using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MovieListLab10
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Movie> movies = new List<Movie>();
            {
                movies.Add(new Movie("Midsommar", "Drama"));
                movies.Add(new Movie("The Room", "Drama"));
                movies.Add(new Movie("Dramatic Movie", "Drama"));
                movies.Add(new Movie("Weather Underground", "Documentary"));
                movies.Add(new Movie("The Wobblies", "Documentary"));
                movies.Add(new Movie("The Murder of Fred Hampton", "Documentary"));
                movies.Add(new Movie("The Untold History Of The United States", "Documentary"));
                movies.Add(new Movie("Baby Geniuses 2", "Box Office Flop"));
                movies.Add(new Movie("GameStop", "Box Office Flop"));
                movies.Add(new Movie("Cats", "Box Office Flop"));
            }
            string yesOrNo = "y";
            while (yesOrNo.Contains("y"))
            {
                string genre = "";
                while (true)
                {

                    Console.WriteLine();
                    Console.WriteLine("Choose a movie genre: \n-Drama- \n-Documentary- \n-Box Office Flops-");
                    string input = Console.ReadLine().Trim().ToLower();

                    if (input.Contains("dra"))
                    {
                        genre = "Drama";
                        break;
                    }
                    else if (input.Contains("doc"))
                    {
                        genre = "Documentary";
                        break;
                    }
                    else if (input.Contains("box") || input.Contains("flo"))
                    {
                        genre = "Box Office Flop";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                        continue;
                    }


                }
                //Console.WriteLine(genre);
                foreach (Movie movie in movies)
                {
                    if (movie.Genre == genre)
                    {
                        movie.ShowMovies();
                    }
                }            
                    Console.WriteLine($"Do you want to explore another movie genre? [y/n]");
                    yesOrNo = Console.ReadLine();

            }


        } 

} 
}
