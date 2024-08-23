using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_IT_IDatabase.Entites
{
    public class CourseInstructor
    {
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public decimal Evaluation {  get; set; }
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
    }
}
