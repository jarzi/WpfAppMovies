using System.Windows;
using System.Windows.Controls;
using WpfAppMovies.Model;
using WpfAppMovies.ViewModels;

namespace WpfAppMovies.Views
{
    public partial class MovieDetailsPage
    {
        public MovieDetailsPage(object sender)
        {
            InitializeComponent();
            var button = (Button)sender;
            var movie = (Movie)button.DataContext;
            DataContext = new MovieDetailsViewModel(movie);
        }

        private void ButtonBack_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow.MainNavigationFrame.GoBack();
        }
    }
}