using DemoAPI.Data;
using DemoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Repositories.StudentRepo
{
    public class StudentRepo : IStudentRepo
    {
        private readonly DemoContext _context = null!;

        public StudentRepo(DemoContext context)
        {
            _context = context;
        }

        public Task<bool> Create(Student student)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var student = await _context.Student.ToListAsync();
            return student;
        }
    }
}
