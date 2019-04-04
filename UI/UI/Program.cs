using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factorys;
using IMaths; 

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMath math = Factory.CreateMaths();
            int c = math.Add(10, 10);

            IMathComplex math1= Factory.CreateMaths();
            int d1 = math1.Add(10, 10);
            int c1 = math1.Devide(10, 10);
        }
    }
}
