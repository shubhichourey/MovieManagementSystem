namespace MovieManagementSystem.DataAccess
{
    public class Movie
    {
        public int movieID { get; set; }
        public string movieTitle { get; set; }

        public MovieGenre movieGenre { get; set; }

        public string movieDirector { get; set; }

        public DateTime releaseDate { get; set; }

        

        public Movie(int movieID, string movieTitle, MovieGenre movieGenre, string movieDirector, DateTime releaseDate)
        {
            this.movieID = movieID;
            this.movieTitle = movieTitle;
            this.movieGenre = movieGenre;
            this.movieDirector = movieDirector;
            this.releaseDate = releaseDate;
        }
    }
}
public enum MovieGenre
{
    Romance,
    Horror,
    Drama,
    Fantasy,
    Thriller,
    ScienceFiction,
    Comedy
}