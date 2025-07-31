using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicsQueries.Library.DTO
{
                                        // o recibo IEnumerable o array, List es mas pesada
    public class QueryDto(string dataSource, string[] fieldName, FilterDto filters, OrderDto order)
    {
        public string DataSource => dataSource;
        public string[] FieldName => fieldName; 
        public FilterDto Filter => filters;
        public OrderDto Order => order;
    }
}
