using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_IT_IDatabase.Entites
{
    public class Department
    {
        // Mapping using By Convention
        public int Id { get; set; }
        public string Name { get; set; } 
        public DateTime HiringDate { get; set; }
        public ICollection<Student> Students { get; set; } = new HashSet<Student>(); // Navegational Property
        [InverseProperty("Department")]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
        [ForeignKey("Instructor")]
        public int? InstructorId { get; set; }
        [InverseProperty("MangedDepartment")]
        public Instructor Instructor { get; set; }
    }
}
