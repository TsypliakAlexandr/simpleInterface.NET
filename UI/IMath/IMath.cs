using System;

namespace IMaths
{
    public interface IMath
    {
        int Add(int a, int b);
        int Multiply(int a, int b);
    }

    public interface IMathComplex:IMath
    {
        int Devide(int a, int b);
    }
}
 