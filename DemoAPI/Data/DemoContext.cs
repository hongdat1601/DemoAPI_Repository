using Bogus;
using DemoAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace DemoAPI.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            int ids = 1;
            var fakeStudent = new Faker<Student>()
                .RuleFor(s => s.Id, f => ids++)
                .RuleFor(s => s.Name, f => f.Internet.UserName())
                .RuleFor(s => s.Old, f => f.Random.Byte());

            modelBuilder.Entity<Student>()
                .HasData(fakeStudent.GenerateBetween(100, 100));
        }
    }
}
