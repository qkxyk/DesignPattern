using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoProject.Interface;

namespace AutoProject.Factory
{
    public class AudiAutoFactory : IAutoFactory
    {
        public string AutoMessage { get; }

        public AudiAutoFactory()
        {
            AutoMessage = "Audi Factory ";
        }
        public string CreateCar()
        {
            ICar car = new AudiCar();
            return AutoMessage + car.ManufactureCar();
        }

        public string CreateSportCar()
        {
            ISportCar sport = new AudiSportCar();
            return AutoMessage + sport.ManufactureSportCar();
        }
    }
}
