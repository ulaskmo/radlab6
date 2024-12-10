using Microsoft.EntityFrameworkCore;
using StudentClassLibrary;
using System;
using System.IO;

namespace StudentConsoleApp
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var dbPath = Path.Combine("/Users/ulaskaramustafaoglu/Downloads/radlab64/", "students.db");
            Console.WriteLine($"Database path: {dbPath}"); // Debug log
            options.UseSqlite($"Data Source={dbPath}");
        }

    }
}