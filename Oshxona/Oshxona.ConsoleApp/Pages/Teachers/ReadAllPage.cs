using ConsoleTables;
using System.Threading.Tasks;
using University.ConsoleApp.Interfaces.RepositoryInterfaces;
using University.ConsoleApp.Repositories;

namespace University.ConsoleApp.Pages.Teachers
{
    public class ReadAllPage
    {
        public static async Task RunAsync()
        {
            ConsoleTable table = new ConsoleTable("Id", "FirstName", "LastName", "Age", "Email", "Phone");

            ITeacherRepository repository = new TeacherRepository();
            var students = await repository.GetAllAsync();


            foreach (var student in students)
            {
                table.AddRow(student.Id, student.FirstName, student.LastName, student.Age, student.Email, student.Phone);
            }

            table.Write();
        }
    }
}
