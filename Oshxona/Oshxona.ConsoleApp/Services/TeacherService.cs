using System.Collections.Generic;
using System.Threading.Tasks;
using University.ConsoleApp.Interfaces.RepositoryInterfaces;
using University.ConsoleApp.Interfaces.ServicesInterfaces;
using University.ConsoleApp.Models;
using University.ConsoleApp.Repositories;

namespace University.ConsoleApp.Services
{
    public class TeacherService : ITeacherServices
    {
        ITeacherRepository teacherRepository;

        public TeacherService()
        {
            teacherRepository = new TeacherRepository();
        }

        public async Task<IEnumerable<Teacher>> GetAllAsync()
            => await teacherRepository.GetAllAsync();
    }
}
