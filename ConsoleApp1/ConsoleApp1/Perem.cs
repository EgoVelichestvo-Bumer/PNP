using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Perem
    {
        static void Main(string[] args)
        {
            DoOperation(10, 5, Operation.Add);
            DoOperation(10, 5, Operation.Subtract);
            DoOperation(10, 5, Operation.Multiply);
            DoOperation(10, 5, Operation.Divide);

            void DoOperation(double x, double y, Operation op);
        }
    }
}
