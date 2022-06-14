using University.ConsoleApp.Interfaces.Common;
using University.ConsoleApp.Models;

namespace University.ConsoleApp.Interfaces.RepositoryInterfaces
{
    public interface ITeacherRepository :
        IUpdateable<Teacher>, IReadable<Teacher>, IDeleteable<Teacher>, ICreateable<Teacher>
    {

    }
}
