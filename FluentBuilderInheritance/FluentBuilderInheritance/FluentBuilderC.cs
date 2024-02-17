using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    internal class FluentBuilderC : FluentBuilderCSetThird<FluentBuilderC>, FluentBuilder<C>
    {
        public FluentBuilderC()
        {
            _buildItem = new C();
        }

        public new C Build()
        {
            return ((C)_buildItem);
        }
    }
}
