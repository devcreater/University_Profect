using System.Threading.Tasks;

namespace University.ConsoleApp.Interfaces.Common
{
    public interface ICreateable<T>
    {
        public Task CreateAsync(T obj);
    }
}
