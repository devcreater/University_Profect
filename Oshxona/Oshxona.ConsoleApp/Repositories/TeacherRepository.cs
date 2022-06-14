using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using University.ConsoleApp.Constants;
using University.ConsoleApp.Interfaces.RepositoryInterfaces;
using University.ConsoleApp.Models;

namespace University.ConsoleApp.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private string path = DatabasePath.Teacher_DB_Path;

        public async Task CreateAsync(Teacher obj)
        {
            List<Teacher> teachers = (await GetAllAsync()).ToList();
            obj.Id = teachers.Count == 0 ? 1 : teachers.Max(x => x.Id) + 1;
            teachers.Add(obj);

            File.WriteAllText(path, JsonConvert.SerializeObject(teachers));

        }

        public async Task DeleteAsync(int id)
              => File.WriteAllText(path, JsonConvert.SerializeObject(GetAllAsync().Result.Where(x => x.Id != id)));


        public async Task<IEnumerable<Teacher>> GetAllAsync()
        {
            string json = File.ReadAllText(path);

            if (string.IsNullOrEmpty(json))
            {
                json = "[]";
                File.WriteAllText(path, json);
            }

            return JsonConvert.DeserializeObject<IEnumerable<Teacher>>(json);
        }

        public Task<Teacher> GetAsynk(int Id)
            => Task.FromResult(GetAllAsync().Result.FirstOrDefault(x => x.Id == Id));

        public async Task UpdateAsync(int id, Teacher obj)
        {
            obj.Id = id;
            var teachers = GetAllAsync().Result.Select(x => x.Id == id ? obj : x).ToList();
        }
    }
}
