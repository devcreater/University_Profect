using System.Threading.Tasks;

namespace University.ConsoleApp.Interfaces.Common
{
    public interface IDeleteable<T>
    {
        public Task DeleteAsync(int id);
    }
}
