using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateProject
{
    public class OperateContext<T> where T : struct
    {
        private IOperate<T> operate;
        public OperateContext(IOperate<T> op)
        {
            operate = op;
        }
        public T GetResult(T a, T b)
        {
            return operate.Operation(a, b);
        }
    }
}
