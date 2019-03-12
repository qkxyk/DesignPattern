using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoProject.Interface;

namespace AutoProject.Factory
{
    public class AudiSportCar : ISportCar
    {
        public string ManufactureSportCar()
        {
            return "Manufacture Audi Sport Car ";
        }
    }
}
