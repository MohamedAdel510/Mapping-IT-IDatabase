using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping_IT_IDatabase.Entites
{
    public class Course
    {
        //Mapped used Fluent APIs
       public int Id { get; set; }
       public string Name { get; set; }
       public string Description { get; set; }
       public DateTime Duration { get; set; }
        [ForeignKey("Topic")]
       public int TopicId { get; set; }
       public Topic Topic { get; set; } //Navigational Property
       public ICollection<StudentCourse> Students { get; set; } = new HashSet<StudentCourse>();
       public ICollection<CourseInstructor> Instructors { get; set; } = new HashSet<CourseInstructor>();
    }
}
