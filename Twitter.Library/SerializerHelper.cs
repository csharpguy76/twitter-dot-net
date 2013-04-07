using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Twitter.Library
{
    public static class SerializerHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static object Deserialize(string url, Type type)
        {
            var xmlReader = XmlReader.Create(url);
            var serializer = new XmlSerializer(type);
            var obj = serializer.Deserialize(xmlReader);
            return obj;
        }
    }
}
