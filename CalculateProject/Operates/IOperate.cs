using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateProject
{
    public interface IOperate<T> where T : struct
    {
        T Operation(T a, T b);
    }
}
