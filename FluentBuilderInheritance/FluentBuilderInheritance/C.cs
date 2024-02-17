using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    public class C : B
    {
        public int third;

        public override string ToString()
        {
            return $"I am C and first is: {first}, second is: {second}, third is: {third}";
        }
    }
}
