using Mapping_IT_IDatabase.Contextes;
using Mapping_IT_IDatabase.Entites;
using Microsoft.EntityFrameworkCore;

namespace Mapping_IT_IDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using EnterpriseITIDbContext dbContext = new EnterpriseITIDbContext();
            #region Insert
            //Course course = new Course()
            //{
            //    Name = "Asp.net",
            //    Description = "Description",
            //    Duration = DateTime.Now,
            //};
            ////dbContext.Courses.Add(course);

            //Department department = new Department()
            //{
            //    Name = "SW",
            //    HiringDate = DateTime.Now
            //};
            ////dbContext.Departments.Add(department);

            //Student student = new Student()
            //{
            //    FName = "Mohamed",
            //    LName = "Adel",
            //    Age = 23,
            //    Address = "Cairo",
            //    DeptId = 1,
            //};
            ////dbContext.Students.Add(student);
            #endregion

            #region Read
            //var Students = (from S in dbContext.Students.Include(S => S.Department)
            //                where S.Id == 2
            //                select S).FirstOrDefault();

            //Console.WriteLine(Students?.FName ?? "NotFound");
            //Console.WriteLine(Students?.Department.Name ?? "NotFound");
            #endregion

            #region Update
            //var student = (from S in dbContext.Students
            //               where S.Id == 2
            //               select S).FirstOrDefault();
            //student.FName = "Ahmed";

            #endregion

            #region Delete
            //var student = (from S in dbContext.Students
            //               where S.Id == 8
            //               select S).FirstOrDefault();
            
            //dbContext.Students.Remove(student);
            #endregion

            dbContext.SaveChanges();
        }
    }
}
