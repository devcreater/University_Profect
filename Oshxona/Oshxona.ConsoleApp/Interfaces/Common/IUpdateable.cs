using System.Threading.Tasks;

namespace University.ConsoleApp.Interfaces.Common
{
    public interface IUpdateable<T>
    {
        public Task UpdateAsync(int id, T obj);
    }
}
