using System.Windows.Controls;

namespace WpfAppMovies.Views
{
    public partial class MainWindow
    {
        public static Frame MainNavigationFrame { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            MainNavigationFrame = NavigationFrame;
            MainNavigationFrame.Navigate(new MoviesPage());
        }
    }
}