using System.IO;
using System.Xml.Serialization;
using WpfAppMovies.Model;

namespace WpfAppMovies.Repository
{
    public static class MovieRepository
    {
        public static Movies GetAll()
        {
            using var fileStream = new FileStream("../../../MoviesData.xml", FileMode.Open);
            var serializer = new XmlSerializer(typeof(Movies));
            return (Movies) serializer.Deserialize(fileStream);
        }
    }
}