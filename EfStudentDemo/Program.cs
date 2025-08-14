using System;
using System.Data.Entity;

namespace EfStudentDemo
{
    // 1. Define Student entity
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
    }

    // 2. Define DbContext
    public class MyContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    // 3. Program Entry
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyContext())
            {
                var student = new Student
                {
                    Name = "Alice"
                };
                context.Students.Add(student);
                context.SaveChanges();

                Console.WriteLine($"Saved student with ID: {student.StudentId}");
            }
        }
    }
}
