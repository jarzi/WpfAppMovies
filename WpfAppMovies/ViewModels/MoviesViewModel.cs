using System.Collections.ObjectModel;
using WpfAppMovies.Model;
using WpfAppMovies.Repository;

namespace WpfAppMovies.ViewModels
{
    public class MoviesViewModel : ViewModelBase
    {
        private ObservableCollection<Movie> _movies = new ObservableCollection<Movie>();


        public ObservableCollection<Movie> Movies
        {
            get => _movies;
            set
            {
                _movies = value;
                RaisePropertyChangedEvent(nameof(Movies));
            }
        }

        public MoviesViewModel()
        {
            var movies = MovieRepository.GetAll();
            Movies = new ObservableCollection<Movie>(movies.MoviesList);
        }
    }
}