using System;
using System.Xml.Serialization;

namespace WpfAppMovies.Model
{
    public class Movie
    {
        [XmlElement("ImageUrl")]
        public string ImageUrl { get; set; }
        [XmlElement("Title")]
        public string Title { get; set; }
        [XmlElement("ReleaseDate")]
        public DateTime ReleaseDate  { get; set; }
        [XmlElement("Director")]
        public string Director { get; set; }
        [XmlElement("AdditionalInfo")]
        public string AdditionalInfo { get; set; }
    }
}