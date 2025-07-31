using DynamicsQueries.Library.DTO;
using System.Dynamic;

namespace DynamicsQueries.Library.Internal
{
    internal interface IExecuteQueryInputPort
    {
        Task<IEnumerable<ExpandoObject>> HandleQueryAsync(QueryDto queryDto);
    }
}
