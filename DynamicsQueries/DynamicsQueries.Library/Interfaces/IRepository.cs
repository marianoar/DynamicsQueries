using DynamicsQueries.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicsQueries.Library.Interfaces
{
    public interface IRepository
    {
        DataSource GetDataSourceByName(string name);
        IEnumerable<DataSource> GetAllDataSources();

        Task<IEnumerable<object[]>> GetDataAsync(IQueryable<object[]> queryable);
    }
}
