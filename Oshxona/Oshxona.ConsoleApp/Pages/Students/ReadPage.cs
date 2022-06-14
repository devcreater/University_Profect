using Sharprompt;
using System;
using System.Threading.Tasks;
using University.ConsoleApp.Interfaces.RepositoryInterfaces;
using University.ConsoleApp.Repositories;

namespace University.ConsoleApp.Pages.Students
{
    public class ReadPage
    {
        public static async Task RunAsync()
        {
            IStudentRepository repository = new StudentRepository();

            int id = Prompt.Input<int>("Enter student id");

            await repository.GetAsynk(id);
        }
    }
}
