using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateProject
{
    class Program
    {
        static void Main(string[] args)
        {
            OperateContext<int> context = new OperateContext<int>(new AddOperate());
            var sum =context.GetResult(20, 15);
            Console.WriteLine(sum);
            context = new OperateContext<int>(new SubOperate());
            var sub = context.GetResult(45, 85);
            Console.WriteLine(sub);
            Console.ReadKey();
        }
    }
}
