using System.Collections.Generic;
using System.Threading.Tasks;

namespace University.ConsoleApp.Interfaces.Common
{
    public interface IReadable<T>
    {
        public Task<IEnumerable<T>> GetAllAsync();

        public Task<T> GetAsynk(int Id);
    }
}
