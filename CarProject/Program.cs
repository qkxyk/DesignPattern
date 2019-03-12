using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.Factory;
using CarProject.Interface;

namespace CarProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new AudiFactory();
            Console.WriteLine(factory.CreateAuto());
            factory = new BenzFactory();
            Console.WriteLine(factory.CreateAuto());
            Console.ReadKey();
        }
    }
}
