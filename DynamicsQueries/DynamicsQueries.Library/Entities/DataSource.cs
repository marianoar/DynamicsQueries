using DynamicsQueries.Library.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DynamicsQueries.Library.Entities
{
    public class DataSource(string name, string description, Type elementType, IQueryable queryable, DataSourcePropertyInfo[] properties)
    {
        public string Name => name;
        public string Description => description;
        public Type ElementType => elementType;
        public IQueryable Queryable => queryable;
        public DataSourcePropertyInfo[] Properties => properties;

        public PropertyInfo GetPropertyInfo(string name) =>
                ElementType.GetProperty(name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
        
        public PropertyInfo[] GetPropertyInfos()=>
            [..Properties.Select(p=>GetPropertyInfo(p.Name))];
    }
}
