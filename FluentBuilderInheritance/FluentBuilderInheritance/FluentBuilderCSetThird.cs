using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    /// <summary>
    /// This is the class with the recursive generic
    /// This class extends another Fluent Builder modifier class
    /// 
    /// The C data type extends the base-class data type A, so the cast is possible
    /// </summary>
    /// <typeparam name="TBuilder">Data type of the builder, should be set as the highest class in the hierarchy -> Without recursive generic!</typeparam>
    internal class FluentBuilderCSetThird<TBuilder> : FluentBuilderBSetSecond<TBuilder> where TBuilder : FluentBuilderCSetThird<TBuilder>
    {
        public TBuilder setThird(int value)
        {
            ((C)_buildItem).third = value; // Sorry, but cast is required -> base class has A type
            return (TBuilder)this;
        }
    }
}
