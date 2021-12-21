using System.Collections.Generic;
using System.Xml.Serialization;

namespace WpfAppMovies.Model
{
    [XmlRoot("Movies")]
    public class Movies
    {
        [XmlElement("Movie")]
        public List<Movie> MoviesList { get; set; }
    }
}