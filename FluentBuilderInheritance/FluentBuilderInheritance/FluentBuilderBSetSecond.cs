using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    public class FluentBuilderBSetSecond<TBuilder> : FluentBuilderAsetFirst<TBuilder> where TBuilder : FluentBuilderBSetSecond<TBuilder>
    {
        public TBuilder setSecond(int value)
        {
            ((B)_buildItem).druhy = value; // Sorry, but this is required -> base class has A type
            return (TBuilder)this;
        }
    }
}
