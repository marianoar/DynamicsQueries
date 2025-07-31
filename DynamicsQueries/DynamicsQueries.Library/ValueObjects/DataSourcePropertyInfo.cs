using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicsQueries.Library.ValueObjects
{
    public class DataSourcePropertyInfo(string name, string description, Type type)
    {
        public string Name => name;
        public string Description => description;
        public Type Type => type;

    }
}
