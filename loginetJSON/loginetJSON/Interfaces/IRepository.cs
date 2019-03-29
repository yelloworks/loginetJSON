using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginetJSON.Interfaces
{
    public interface IRepository<T> : IDisposable
    {
        Task<IEnumerable<T>> GetList();
        Task<T> GetItem(int id);

        Task<IEnumerable<T>> GetBy(string paramName, string param);
    }
}
