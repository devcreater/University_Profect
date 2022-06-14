using Oshxona.ConsoleApp.Models;
using Sharprompt;
using System.Threading.Tasks;
using University.ConsoleApp.Interfaces.RepositoryInterfaces;
using University.ConsoleApp.Repositories;

namespace University.ConsoleApp.Pages.Students
{
    public class UpdatePage
    {
        public static async Task RunAsync()
        {
            IStudentRepository repository = new StudentRepository();

            Student student = new Student();

            int id = Prompt.Input<int>("Enter student id");
            
            student.FirstName = Prompt.Input<string>("Enter student name");

            student.LastName = Prompt.Input<string>("Enter student Surname");

            student.Age = Prompt.Input<int>("Enter student age");

            student.Email = Prompt.Input<string>("Enter student email");

            student.Course = Prompt.Input<int>("Enter student course");

            student.Faculty = Prompt.Input<string>("Enter student faculty");

            await repository.UpdateAsync(id, student);
        }
    }
}
