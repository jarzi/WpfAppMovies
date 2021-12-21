using System.Windows;
using WpfAppMovies.ViewModels;

namespace WpfAppMovies.Views
{
    public partial class MoviesPage
    {
        public MoviesPage()
        {
            InitializeComponent();
            DataContext = new MoviesViewModel();
        }

        private void ButtonMovie_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow.MainNavigationFrame.Navigate(new MovieDetailsPage(sender));
        }
    }
}