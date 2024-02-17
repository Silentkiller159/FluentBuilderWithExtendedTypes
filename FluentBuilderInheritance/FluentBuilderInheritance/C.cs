using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    public class C : B
    {
        public int treti;

        public override string ToString()
        {
            return $"I am C and first is: {prvni}, second is: {druhy}, third is: {treti}";
        }
    }
}
