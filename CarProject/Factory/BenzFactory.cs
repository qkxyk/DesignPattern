using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.Interface;

namespace CarProject.Factory
{
    public class BenzFactory : IFactory
    {
        public ICar car { get; set; }

        public string CreateAuto()
        {
            car = new BenzCar();
            return "Benz Factory " + car.Manufacture();
        }
    }
}
