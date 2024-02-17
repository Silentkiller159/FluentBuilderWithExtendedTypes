using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    /// <summary>
    /// Implements generic fluent builder interface, as a data type C
    /// Creates the instance of the builded item
    /// Implements the Build method for the data type C
    /// 
    /// Also, extends the Fluent Builder which provides method for setting the "treti" field of the data type C
    /// </summary>
    internal class FluentBuilderC : FluentBuilderCSetThird<FluentBuilderC>, FluentBuilder<C>
    {
        public FluentBuilderC()
        {
            _buildItem = new C();
        }

        public C Build()
        {
            return ((C)_buildItem);
        }
    }
}
