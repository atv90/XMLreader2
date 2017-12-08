using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLreader2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader(@"C:\Users\Anne\source\repos\XMLreader1\XMLtiedosto.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text:

                        Console.WriteLine(reader.Value);
                        break;
                    case XmlNodeType.EndElement:
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
