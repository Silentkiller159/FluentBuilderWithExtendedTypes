using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    public class B : A
    {
        public int second;

        public override string ToString()
        {
            return $"I am B and first is: {first}, second is: {second}";
        }
    }
}
