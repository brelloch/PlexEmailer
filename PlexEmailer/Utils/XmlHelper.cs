using System.IO;
using System.Xml;
using System.Xml.Serialization;
using PlexEmailer.Models;

namespace PlexEmailer.Utils
{
    public class XmlHelper<T> where T : class
    {
        public static T Deserialize(string xml)
        {
            T type;
            var serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(xml))
            {
                type = serializer.Deserialize(reader) as T;
            }
            
            return type;
        }
    }

}
