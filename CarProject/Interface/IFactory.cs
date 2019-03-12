using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Interface
{
    interface IFactory
    {
        ICar car { get; set; }
        string CreateAuto();
    }
}
