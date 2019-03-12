using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.Interface;

namespace CarProject.Factory
{
    public class BenzCar : ICar
    {
        public string Manufacture()
        {
            return "Manufacture Benz Car";
        }
    }
}
