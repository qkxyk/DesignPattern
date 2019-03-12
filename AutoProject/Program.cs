using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoProject.Interface;
using AutoProject.Factory;

namespace AutoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutoFactory factory = new AudiAutoFactory();
            Console.WriteLine(factory.CreateCar());
            Console.WriteLine(factory.CreateSportCar());
            factory = new BenzAutoFactory();
            Console.WriteLine(factory.CreateCar());
            Console.WriteLine(factory.CreateSportCar());
            Console.ReadKey();
        }
    }
}
