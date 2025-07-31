using DynamicsQueries.Library.DTO;
using DynamicsQueries.Library.Internal;
using DynamicsQueries.Library.Result;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicsQueries.Library.Controllers
{
    internal class ExecuteQueryController : IExecuteQueryController
    {
        public Task<HandleRequestResult<IEnumerable<ExpandoObject>>> HandleRequestAsync(QueryDto queryDto)
        {
            throw new NotImplementedException();
        }
    }
}
