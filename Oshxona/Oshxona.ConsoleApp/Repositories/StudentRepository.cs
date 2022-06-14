using Newtonsoft.Json;
using Oshxona.ConsoleApp.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using University.ConsoleApp.Constants;
using University.ConsoleApp.Interfaces.RepositoryInterfaces;

namespace University.ConsoleApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private string path = DatabasePath.Student_DB_Path;

        public async Task CreateAsync(Student obj)
        {
            List<Student> students = (await GetAllAsync()).ToList();
            var laststudent = students.LastOrDefault();
            obj.Id = laststudent == null ? 1 : laststudent.Id + 1;
            students.Add(obj);

            File.WriteAllText(path, JsonConvert.SerializeObject(students, Formatting.Indented));
        }

        public async Task DeleteAsync(int id)
              => File.WriteAllText(path, JsonConvert.SerializeObject(GetAllAsync().Result.Where(x => x.Id != id)));


        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            string json = File.ReadAllText(path);

            if (string.IsNullOrEmpty(json))
            {
                json = "[]";
                File.WriteAllText(path, json);
            }

            return JsonConvert.DeserializeObject<IEnumerable<Student>>(json);
        }


        public async Task<Student> GetAsynk(int Id)
                => GetAllAsync().Result.FirstOrDefault(x => x.Id == Id);

        public async Task UpdateAsync(int id, Student obj)
        {
            obj.Id = id;
            var students = GetAllAsync().Result.Select(x => x.Id == id ? obj : x).ToList();

            File.WriteAllText(path, JsonConvert.SerializeObject(students, Formatting.Indented));
        }

    }
}
