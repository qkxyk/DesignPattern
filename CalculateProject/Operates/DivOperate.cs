using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateProject
{
    public class DivOperate : IOperate<int>
    {
        public int Operation(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            return a / b;
        }
    }
}
