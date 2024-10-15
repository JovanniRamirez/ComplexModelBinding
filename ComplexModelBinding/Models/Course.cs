using Microsoft.AspNetCore.Routing.Constraints;
using System.ComponentModel.DataAnnotations;

namespace ComplexModelBinding.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Instructor Instructor { get; set; }
    }

    public class CourseCreateViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public List<Instructor>? AllAvailableInstructors { get; set; }
        
        public int ChosenInstructor { get; set; }
    }

    public class CourseIndexViewModel
    {
        public int CourseId { get; set; }
        
        [Display(Name = "Course Title")]
        public string CourseTitle { get; set; }
        
        [Display(Name = "Instructor")]
        public string InstructorName { get; set; }
    }
}
