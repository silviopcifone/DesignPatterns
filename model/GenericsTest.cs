using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.model
{
    internal class GenericsTest<T>
    {
        private T value;

        public T GetValue()
        {
            return value;
        }
    }
}
