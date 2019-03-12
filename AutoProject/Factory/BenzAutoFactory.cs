using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoProject.Interface;

namespace AutoProject.Factory
{
    public class BenzAutoFactory : IAutoFactory
    {
        public BenzAutoFactory()
        {
            AutoMessage = "Benz Factory ";
        }
        public string AutoMessage { get; }

        public string CreateCar()
        {
            ICar car = new BenzCar();
            return AutoMessage + car.ManufactureCar();
        }

        public string CreateSportCar()
        {
            ISportCar sport = new BenzSportCar();
            return AutoMessage + sport.ManufactureSportCar();
        }
    }
}
