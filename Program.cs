using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using InspectorLib;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Inspect funk = new Inspect();
            Console.WriteLine($"{funk.GetInspector()}");
            Console.WriteLine($"{funk.GenerateNumber("456", "d".ToUpper(), "75")}");
            Console.WriteLine($"{funk.GetWorker()}");
            Console.WriteLine($"{funk.AddWdorker()}");

            Console.ReadLine();
        }
    }
}