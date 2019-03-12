using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarProject.Interface;

namespace CarProject.Factory
{
    public class AudiFactory : IFactory
    {
        public ICar car { get; set; }

        //ICar car { get; set; }
        //ICar IFactory.car { get ; set ; }

        public string CreateAuto()
        {
            car = new AudiCar();
            return "Audi Factory " + car.Manufacture();
        }
    }
}
