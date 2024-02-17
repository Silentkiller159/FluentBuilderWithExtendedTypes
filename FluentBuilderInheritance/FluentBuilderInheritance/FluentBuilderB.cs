using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    public class FluentBuilderB : FluentBuilderBSetSecond<FluentBuilderB>, FluentBuilder<B>
    {

        public FluentBuilderB()
        {
            _buildItem = new B();
        }

        public new B Build()
        {
            return ((B)_buildItem);
        }
    }
}
