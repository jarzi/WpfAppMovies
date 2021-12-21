using System;
using WpfAppMovies.Model;

namespace WpfAppMovies.ViewModels
{
    public class MovieDetailsViewModel : ViewModelBase
    {
        private string _imageUrl;
        public string ImageUrl
        {
            get => _imageUrl;
            set
            {
                _imageUrl = value;
                RaisePropertyChangedEvent(nameof(ImageUrl));
            }
        }
        
        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                RaisePropertyChangedEvent(nameof(Title));
            }
        }
        
        private DateTime _releaseDate;
        public DateTime ReleaseDate
        {
            get => _releaseDate;
            set
            {
                _releaseDate = value;
                RaisePropertyChangedEvent(nameof(ReleaseDate));
            }
        }
        
        private string _director;
        public string Director
        {
            get => _director;
            set
            {
                _director = value;
                RaisePropertyChangedEvent(nameof(Director));
            }
        }
        
        private string _additionalInfo;
        public string AdditionalInfo
        {
            get => _additionalInfo;
            set
            {
                _additionalInfo = value;
                RaisePropertyChangedEvent(nameof(AdditionalInfo));
            }
        }

        public MovieDetailsViewModel(Movie movie)
        {
            ImageUrl = movie.ImageUrl;
            Title = movie.Title;
            Director = movie.Director;
            ReleaseDate = movie.ReleaseDate;
            AdditionalInfo = movie.AdditionalInfo;
        }
    }
}