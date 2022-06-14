using System.Collections.Generic;
using System.Threading.Tasks;
using University.ConsoleApp.Models;

namespace University.ConsoleApp.Interfaces.ServicesInterfaces
{
    public interface ITeacherServices
    {
        Task<IEnumerable<Teacher>> GetAllAsync();
    }
}
