using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicsQueries.Library.DTO
{
    //ej best price > 100 && name == "sarasa" -> campo/operacion/valor
    public class FilterDto(string fieldName, string operation, string value, string joinWithNext)
    {
        public string FieldName => fieldName;
        public string Operation => operation;
        public string Value => value;
        public string JoinWithNext => joinWithNext;
    }
}
