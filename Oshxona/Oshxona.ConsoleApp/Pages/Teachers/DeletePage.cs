using Sharprompt;
using System;
using System.Threading.Tasks;
using University.ConsoleApp.Interfaces.RepositoryInterfaces;
using University.ConsoleApp.Repositories;

namespace University.ConsoleApp.Pages.Teachers
{
    public class DeletePage
    {
        public static async Task RunAsync()
        {
            ITeacherRepository repository = new TeacherRepository();

            int id = Prompt.Input<int>("Enter teacher id");

            await repository.DeleteAsync(id);
        }
    }
}
