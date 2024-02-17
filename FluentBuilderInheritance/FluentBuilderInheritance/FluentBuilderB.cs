using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    /// <summary>
    /// Implements generic fluent builder interface, as a data type B
    /// Creates the instance of the builded item
    /// Implements the Build method for the data type B
    /// 
    /// Also, extends the Fluent Builder which provides method for setting the "druhy" field of the data type B
    /// </summary>
    public class FluentBuilderB : FluentBuilderBSetSecond<FluentBuilderB>, FluentBuilder<B>
    {
        public FluentBuilderB()
        {
            _buildItem = new B();
        }

        public B Build()
        {
            return ((B)_buildItem);
        }
    }
}
