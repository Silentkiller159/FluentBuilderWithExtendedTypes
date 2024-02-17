using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    public class A
    {
        public int prvni;

        public override string ToString()
        {
            return $"I am A and first is: {prvni}";
        }
    }
}
