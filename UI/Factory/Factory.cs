using IMaths;
using MathLibrarys;
using System;

namespace Factorys
{
    public static class Factory
    {
        public static IMathComplex CreateMaths()
        {
            return new MathLibrary();
        }
    }
}
