using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLParser;

namespace XMLTester
{
    class Program
    {

        static void Main(string[] args)
        {
            Parser parser = new Parser("http://nubgrammer.com/community/?type=rss2&forum=g&topic=g");
            Console.WriteLine(parser.ToString());
           
        }
    }
}
