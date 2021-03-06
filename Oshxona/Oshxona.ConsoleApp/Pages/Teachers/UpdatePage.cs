using Sharprompt;
using System;
using System.Threading.Tasks;
using University.ConsoleApp.Interfaces.RepositoryInterfaces;
using University.ConsoleApp.Models;
using University.ConsoleApp.Repositories;

namespace University.ConsoleApp.Pages.Teachers
{
    public class UpdatePage
    {
        public static async Task RunAsync()
        {
            ITeacherRepository repository = new TeacherRepository();

            Teacher teacher = new Teacher();

            int id = Prompt.Input<int>("Enter teacher id");
            
            teacher.FirstName = Prompt.Input<string>("Enter teacher name");

            teacher.LastName = Prompt.Input<string>("Enter teacher Surname");

            teacher.Age = Prompt.Input<int>("Enter teacher age");

            teacher.Email = Prompt.Input<string>("Enter techer email");

            teacher.Phone = Prompt.Input<string>("Enter teacher phone");

            await repository.UpdateAsync(id, teacher);

        }
    }
}
