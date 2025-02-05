using System;
using System.Collections.Generic;
using System.Linq;
using MovieManagementSystem.DataAccess;

namespace MovieManagementSystem.BusinessLogic
{
    public class MovieService : IMovieService
    {
        public static Dictionary<int, Movie> movieDictionary = new Dictionary<int, Movie>();

        public bool AddMovie(Movie movie)
        {
            if (movie.movieID <= 0 || movieDictionary.ContainsKey(movie.movieID))
                return false;

            movieDictionary.Add(movie.movieID, movie);
            return true;
        }

        public bool DeleteMovie(int movieID)
        {
            return movieDictionary.Remove(movieID);
        }

        public bool UpdateMovie(int movieID, Movie updatedMovie)
        {
            if (movieDictionary.ContainsKey(movieID))
            {
                movieDictionary[movieID] = updatedMovie;
                return true;
            }
            return false;
        }

        public Movie GetMovie(int movieID)
        {
            movieDictionary.TryGetValue(movieID, out Movie movie);
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return movieDictionary.Values.ToList();
        }

        public void LoadMovies(List<Movie> movies)
        {
            movieDictionary = movies.ToDictionary(m => m.movieID);
        }

        public List<Movie> GetAllMoviesSorted()
        {
            return movieDictionary.Values.OrderBy(m => m.movieID).ToList();
        }
    }
}
