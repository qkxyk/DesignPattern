using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProject.Interface
{
    interface IAutoFactory
    {
        string AutoMessage { get; }
        string CreateCar();
        string CreateSportCar();
    }
}
