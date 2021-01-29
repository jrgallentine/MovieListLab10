using System;
using System.Collections.Generic;
using System.Text;

namespace MovieListLab10
{
    class Movie
    {
        private string _title;
        private string _genre;
        public string Title { get; set; }
        public string Genre { get; set; }

        public Movie(string title, string genre)
        {
            this.Title = title;
            this.Genre = genre;
        }

        public void ShowMovies()
        {
            Console.WriteLine($"\nTitle: {Title} || Genre: {Genre}\n");

        }
    }
}
