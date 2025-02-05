using System.Text.Json;
using MovieManagementSystem.BusinessLogic;
using MovieManagementSystem.DataAccess;

namespace MovieManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(MovieGenre));
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            int movieID;
            string movieTitle = txtMovieTitle.Text;
            string movieDirector = txtMovieDirector.Text;
            DateTime releaseDate = dateTimePicker1.Value;
            MovieGenre movieGenre;

            if (string.IsNullOrWhiteSpace(movieTitle) || string.IsNullOrWhiteSpace(movieDirector))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            if (!int.TryParse(txtMovieID.Text, out movieID) || !Enum.TryParse(comboBox1.SelectedItem.ToString(), out movieGenre))
            {
                MessageBox.Show("Invalid Movie ID or Genre.");
                return;
            }

            if (MovieService.movieDictionary.ContainsKey(movieID))
            {
                MessageBox.Show("Movie ID already exists.");
                return;
            }
            Movie newMovie = new Movie(movieID, movieTitle, movieGenre, movieDirector, releaseDate);
            bool result = new MovieService().AddMovie(newMovie);

            MessageBox.Show(result ? "Movie added successfully." : "Movie addition failed.");

            DisplayMovies();
            clearInputs();
        }
        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            int movieID;
            string movieTitle = txtMovieTitle.Text;
            string movieDirector = txtMovieDirector.Text;
            DateTime releaseDate = dateTimePicker1.Value;
            MovieGenre movieGenre;

            if (string.IsNullOrWhiteSpace(movieTitle) || string.IsNullOrWhiteSpace(movieDirector))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            if (!int.TryParse(txtMovieID.Text, out movieID) || !Enum.TryParse(comboBox1.SelectedItem.ToString(), out movieGenre))
            {
                MessageBox.Show("Invalid Movie ID or Genre.");
                return;
            }

            Movie updatedMovie = new Movie(movieID, movieTitle, movieGenre, movieDirector, releaseDate);
            bool result = new MovieService().UpdateMovie(movieID, updatedMovie);

            MessageBox.Show(result ? "Movie updated successfully." : "Movie update failed.");

            DisplayMovies();
            clearInputs();
        }
        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMovieID.Text, out int movieID))
            {
                MessageBox.Show("Invalid Movie ID.");
                return;
            }

            bool result = new MovieService().DeleteMovie(movieID);
            MessageBox.Show(result ? "Movie deleted successfully." : "Movie deletion failed.");

            DisplayMovies();
        }

        private void btnViewAllMovies_Click(object sender, EventArgs e)
        {
            DisplayMovies();
        }

        private void DisplayMovies()
        {
            MOVIES.Items.Clear();

            var movies = new MovieService().GetAllMoviesSorted();
            if (movies.Any())
            {
                foreach (var movie in movies)
                {
                    var movieDetails = $"Movie ID: {movie.movieID}, Title: {movie.movieTitle}, Genre: {movie.movieGenre}, Year: {movie.releaseDate}";
                    MOVIES.Items.Add(movieDetails);
                }
            }
            else
            {
                MessageBox.Show("No movies available.");
            }
        }
        private void btnSaveMovies_Click(object sender, EventArgs e)
        {
            string filePath = "movies.json";
            var movies = new MovieService().GetAllMoviesSorted();
            JsonAdd.SaveToFile(filePath, movies);
            MessageBox.Show("Movies saved successfully.");
        }

        private void btnLoadMovies_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Open JSON File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var movies = JsonAdd.LoadFromFile<List<Movie>>(openFileDialog.FileName);
                    if (movies != null)
                    {
                        new MovieService().LoadMovies(movies);
                        DisplayMovies();
                        MessageBox.Show("Movies loaded successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to load movies.");
                    }
                }

            }
        }
        private void clearInputs()
        {
            txtMovieID.Clear(); // Clears Movie ID textbox
            txtMovieTitle.Clear(); // Clears Movie Title textbox
            txtMovieDirector.Clear(); // Clears Movie Director textbox
            comboBox1.SelectedIndex = -1; // Optionally, clear the genre selection (combobox)
            dateTimePicker1.Value = DateTime.Now; // Optionally, reset the DateTimePicker to the current date
        }
        public class JsonAdd
        {
            public static void SaveToFile<T>(string filePath, T data)
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                var jsonString = JsonSerializer.Serialize(data, options);
                File.WriteAllText(filePath, jsonString);
            }

            public static T LoadFromFile<T>(string filePath)
            {
                if (!File.Exists(filePath))
                    return default(T);

                var jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(jsonString);
            }
        }

        private void btnDeleteMovie_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

