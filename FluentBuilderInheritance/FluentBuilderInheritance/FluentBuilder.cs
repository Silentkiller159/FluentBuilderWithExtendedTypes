using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    /// <summary>
    /// Interface for the fluent builder, provides the method for the build of specific type
    /// </summary>
    /// <typeparam name="T">Data type to be built</typeparam>
    public interface FluentBuilder<T>
    {
        public T Build();
    }
}
