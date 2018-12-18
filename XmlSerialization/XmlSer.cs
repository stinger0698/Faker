using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Serialization;
using System.IO;
using DTOLib;

namespace XmlSerialization
{
    public interface IWriter
    {
        void Write(MemoryStream memStram);
    }

    public class Writer : IWriter
    {
        public void Write(MemoryStream memStream)
        {
            memStream.Position = 0;
            StreamReader sr = new StreamReader(memStream);


            Console.WriteLine(sr.ReadToEnd());

            using (FileStream fs = new FileStream("dto.xml", FileMode.Create))
            {
                memStream.WriteTo(fs);
            }
        }
    }

    public interface ISerialization
    {
        MemoryStream Serialize<T>(T ElArr, MemoryStream stram);
    }

    public class XmlSerialization : ISerialization
    {        
        public MemoryStream Serialize<T>(T ElArr, MemoryStream memoryStream)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            StreamWriter stream = new StreamWriter(memoryStream);
            formatter.Serialize(stream, ElArr);

            Console.WriteLine("Объект XML сериализован");
            return memoryStream;
        }
    }


    public class XmlSer
    {
        public void Make<T>(T obj)
        {
            MemoryStream stream = new MemoryStream();
            XmlSerialization newSer = new XmlSerialization();
            stream = newSer.Serialize(obj, stream);
            Writer wr = new Writer();
            wr.Write(stream);
        }
    }
}
