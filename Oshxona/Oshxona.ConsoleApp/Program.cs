using System.Threading.Tasks;
using University.ConsoleApp.Pages;

namespace Oshxona.ConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await MainMenuPage.RunAsync();
        }
    }
}

