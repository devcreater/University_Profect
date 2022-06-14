using Sharprompt;
using System;
using System.Threading.Tasks;
using University.ConsoleApp.Pages.Teachers;

namespace University.ConsoleApp.Pages
{
    public class TeacherPage
    {
        public static async Task RunAsync()
        {
            Console.Clear();

            var type = Prompt.Select("Select the service type", new[] {
                "1. List of student",
                "2. Add student",
                "3. Delete student",
                "4. Get student",
                "5. Update student" });


            var select = type[0];

            if (select == '1')
            {
                Console.Clear();
                await ReadAllPage.RunAsync();
            }
            else if (select == '2')
            {
                Console.Clear();
                await CreatePage.RunAsync();
            }
            else if (select == '3')
            {
                Console.Clear();
                await DeletePage.RunAsync();
            }
            else if (select == '4')
            {
                Console.Clear();
                await ReadPage.RunAsync();
            }
            else if (select == '5')
            {
                Console.Clear();
                await UpdatePage.RunAsync();
            }

            Console.WriteLine(select);

        }
    }
}
