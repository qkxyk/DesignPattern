using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateProject
{
    public class SubOperate : IOperate<int>
    {
        public int Operation(int a, int b)
        {
            if (a > b)
            {
                return a - b;
            }
            return b - a;
        }
    }
}
