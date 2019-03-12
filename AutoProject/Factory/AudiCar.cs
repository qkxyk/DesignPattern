using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoProject.Interface;

namespace AutoProject.Factory
{
    public class AudiCar : ICar
    {
        public string ManufactureCar()
        {
            return "Manufacture Audi Car";
        }
    }
}
