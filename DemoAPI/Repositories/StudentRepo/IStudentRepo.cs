using DemoAPI.Models;

namespace DemoAPI.Repositories.StudentRepo
{
    public interface IStudentRepo
    {
        public Task<IEnumerable<Student>> GetAll();
        public Task<bool> Create(Student student);
    }
}
