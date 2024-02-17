using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    /// <summary>
    /// This is the bottom of the recursive generic
    /// </summary>
    /// <typeparam name="TBuilder"></typeparam>
    public class FluentBuilderAsetFirst<TBuilder> where TBuilder : FluentBuilderAsetFirst<TBuilder>
    {
        protected A _buildItem;

        public FluentBuilderAsetFirst()
        {

            this._buildItem = new A();
        }

        public TBuilder setFirst(int value)
        {
            _buildItem.prvni = value;
            return (TBuilder)this;
        }

        public A Build()
        {
            return _buildItem;
        }
    }
}
