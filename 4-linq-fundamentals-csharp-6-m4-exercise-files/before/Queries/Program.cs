﻿using System.Linq;
using System.Collections.Generic;
using System;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            



            var movies = new List<Movie>
            {
                new Movie { Title = "The Dark Knight",   Rating = 8.9f, Year = 2008 },
                new Movie { Title = "The King's Speech", Rating = 8.0f, Year = 2010 },
                new Movie { Title = "Casablanca",        Rating = 8.5f, Year = 1942 },
                new Movie { Title = "Star Wars V",       Rating = 8.7f, Year = 1980 }                        
            };

            //var query = movies.Where(m => m.Year > 2000);
            var query = movies.Filter(m => m.Year > 2000)
                               .Take(1);

            //foreach (var movie in query)
            //{
            //    Console.WriteLine(movie.Title);
            //}
            
            //var query = from movie in movies
            //            where movie.Year > 2000
            //            orderby movie.Rating descending
            //            select movie;

            var enumerator = query.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Title);
            }
            Console.ReadLine();
        }
    }
}
