using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicsQueries.Library.Result
{
    public class HandleRequestResult<T>
    {
        //todo de solo lectura
        public bool Success { get; private set; }
        public T SuccesValue { get; private set; } 
        public string ErrorMessage { get; private set; } = string.Empty;
        public HandleRequestResult(T Result)
        {
            Success = true;
            SuccesValue = Result;
        }

        public HandleRequestResult(string errorMessage)
        {
            ErrorMessage = errorMessage;
            Success = false;
        }
    }
}
