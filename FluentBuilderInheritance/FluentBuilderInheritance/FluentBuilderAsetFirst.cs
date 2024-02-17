using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    /// <summary>
    /// This is the bottom of the recursive generic, so called base-class
    /// </summary>
    /// <typeparam name="TBuilder">Data type of the builder, should be set as the highest class n the hierarchy -> Without recursive generic!</typeparam>
    public class FluentBuilderAsetFirst<TBuilder> where TBuilder : FluentBuilderAsetFirst<TBuilder>
    {
        /// <summary>
        /// This is the item we will modify/build, so it has to be decladed in the base class
        /// </summary>
        protected A _buildItem;

        public FluentBuilderAsetFirst()
        {
            // Just to keep warning away, this should never be needed ...
            this._buildItem = new A();
        }

        public TBuilder setFirst(int value)
        {
            _buildItem.first = value;
            return (TBuilder)this;
        }
    }
}
