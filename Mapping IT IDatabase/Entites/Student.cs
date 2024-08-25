using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_IT_IDatabase.Entites
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string FName { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string LName { get; set; }
        public string Address { get; set; }
        [Range(18, 40)]
        public int? Age { get; set; }
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public Department Department { get; set; } // Navigational Property
        public ICollection<StudentCourse> Courses { get; set; } = new HashSet<StudentCourse>();
    }
}
