using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    public class FluentBuilderA : FluentBuilderAsetFirst<FluentBuilderA>, FluentBuilder<A>
    {
        //Nothing needed here
    }
}
