using Mapping_IT_IDatabase.Configuration;
using Mapping_IT_IDatabase.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_IT_IDatabase.Contextes
{
    internal class EnterpriseITIDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = MOHAMMED; Database = EnterPriseITI; Trusted_Connection = true; TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfiguration());

            modelBuilder.Entity<StudentCourse>()
                .HasKey(SC => new { SC.StudentId, SC.CourseId });

            modelBuilder.Entity<CourseInstructor>()
                .HasKey(CI => new { CI.CourseId, CI.InstructorId });

            modelBuilder.Entity<Department>()
                .HasMany(D => D.Instructors)
                .WithOne(Ins => Ins.Department)
                .HasForeignKey(Ins => Ins.DeptId);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
