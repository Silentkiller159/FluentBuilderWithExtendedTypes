using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    /// <summary>
    /// Implements generic fluent builder interface, as a data type A
    /// Creates the instance of the builded item
    /// Implements the Build method for the data type A
    /// 
    /// Also, extends the Fluent Builder which provides method for setting the "prvni" field of the data type A
    /// </summary>
    public class FluentBuilderA : FluentBuilderAsetFirst<FluentBuilderA>, FluentBuilder<A>
    {
        public FluentBuilderA()
        {
            _buildItem = new A();
        }

        public A Build()
        {
            return _buildItem;
        }
    }
}
