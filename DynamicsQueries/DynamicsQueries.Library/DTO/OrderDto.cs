using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicsQueries.Library.DTO
{
                                            // asc or desc
    public class OrderDto(string fieldName, string orderType) 
    {
        public string FieldName => fieldName;
        public string OrderType => orderType;
    }
}
