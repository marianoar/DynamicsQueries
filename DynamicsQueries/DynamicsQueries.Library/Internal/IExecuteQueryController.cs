using DynamicsQueries.Library.DTO;
using DynamicsQueries.Library.Result;
using System.Dynamic;

namespace DynamicsQueries.Library.Internal
{
    internal interface IExecuteQueryController
    {
                    //encapsula un dictionary
        Task<HandleRequestResult<IEnumerable<ExpandoObject>>> HandleRequestAsync (QueryDto queryDto);
    }
}
