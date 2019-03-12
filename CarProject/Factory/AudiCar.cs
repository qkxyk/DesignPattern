using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.Interface;

namespace CarProject.Factory
{
    public class AudiCar : ICar
    {
        public string Manufacture()
        {
            return "Manufacture Audi Car";
        }
    }
}
