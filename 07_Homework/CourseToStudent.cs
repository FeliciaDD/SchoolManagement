using System;
namespace _Homework
{
    public class CourseToStudent
    {
		public Student student;
		public Course course;
		public CourseToStudent(Course course, Student student)
		{
			this.course = course;
			this.student = student;
		}
    }
}
