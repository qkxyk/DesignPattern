using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateProject
{
    public class AddOperate : IOperate<int>
    {
        public int Operation(int a, int b)
        {
            return a + b;
        }
    }
}
