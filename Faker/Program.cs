using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FakerLib;
using DTOLib;
using XmlSerialization;

namespace FakerMain
{

    class Program
    {
        static void Main(string[] args)
        {
            var faker = new Faker();
            DTO1 obj = faker.Create<DTO1>();
            XmlSer forOut = new XmlSer();
            forOut.Make(obj);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
