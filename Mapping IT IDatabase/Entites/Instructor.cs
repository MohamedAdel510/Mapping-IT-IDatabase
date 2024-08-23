using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_IT_IDatabase.Entites
{
    public class Instructor
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "Money")]
        public decimal Salary { get; set; }
        [DataType(DataType.Currency)]
        public decimal Bouns { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public decimal Address { get; set; }
        public decimal HourRate { get; set; }
        [Required]
        [ForeignKey("Department")]
        public int DeptId { get; set; }
        [InverseProperty("Instructors")]
        public Department Department { get; set; }
        [InverseProperty("Instructor")]
        public Department MangedDepartment { get; set; } 
        public ICollection<CourseInstructor> Courses { get; set; } = new List<CourseInstructor>();
    }
}
