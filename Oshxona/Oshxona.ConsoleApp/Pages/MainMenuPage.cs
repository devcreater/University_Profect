using Sharprompt;
using System;
using System.IO;
using System.Threading.Tasks;
using University.ConsoleApp.Constants;

namespace University.ConsoleApp.Pages
{
    public class MainMenuPage
    {
        public static async Task RunAsync()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\tWelcome to the University Management System");
            Console.ForegroundColor = ConsoleColor.White;

            var type = Prompt.Select("Select a section", new[] {
                "1. Student list",
                "2. Teacher list",
                });
            
            
            var choice = int.Parse(type[0].ToString());
            
            var code = Prompt.Password("Enter the password");
            
            string result = Shifrlash(code, 5);
            var student = File.ReadAllText(DatabasePath.StudentHashCode);
            var teacher = File.ReadAllText(DatabasePath.TeacherHashCode);

            if (choice >= 1 && choice <= 2)
            {
                if (choice == 1)
                {
                    if (result == student)
                        await StudentsPage.RunAsync();
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid code");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    if (result == teacher)
                        await TeacherPage.RunAsync();
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid code");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid choice");
                Console.ForegroundColor = ConsoleColor.White;
            }



        }

        public static char shifr(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }
        public static string Shifrlash(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += shifr(ch, key);

            return output;
        }

    }
}
