using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AdvancedFeatures
{
    static class Extension_Methods
    {

        public static void Demo()
        {
            object obj = GetsSomeObject();

            Console.WriteLine("Obj as string is : {0}", obj.ToXml());
        }

        private static object GetsSomeObject()
        {
            return 123;
        }

        public static string ToXml(this object obj)
        {
            var xs = new XmlSerializer(obj.GetType());
            using (var memoryStream = new MemoryStream())
            using (var xmlTextWriter = new XmlTextWriter(memoryStream, null))
            {
                xs.Serialize(xmlTextWriter, obj);
                return Encoding.UTF8.GetString(memoryStream.ToArray());
            }
        }
    }
}
