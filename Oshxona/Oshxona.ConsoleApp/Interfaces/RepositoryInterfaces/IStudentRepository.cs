using Oshxona.ConsoleApp.Models;
using University.ConsoleApp.Interfaces.Common;

namespace University.ConsoleApp.Interfaces.RepositoryInterfaces
{
    public interface IStudentRepository :
        ICreateable<Student>, IReadable<Student>, IDeleteable<Student>, IUpdateable<Student>
    {

    }
}
