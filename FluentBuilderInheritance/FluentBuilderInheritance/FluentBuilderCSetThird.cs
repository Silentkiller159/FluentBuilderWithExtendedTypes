using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    internal class FluentBuilderCSetThird<TBuilder> : FluentBuilderBSetSecond<TBuilder> where TBuilder : FluentBuilderCSetThird<TBuilder>
    {
        public TBuilder setThird(int value)
        {
            ((C)_buildItem).treti = value; // Sorry, but this is required -> base class has A type
            return (TBuilder)this;
        }
    }
}
