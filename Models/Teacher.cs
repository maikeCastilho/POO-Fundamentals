using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchOOP.Models
{
    public class Teacher
    {
        private int id;
        private string name;
        private List<Course> courses;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Course> Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        //constructor method
        public Teacher(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            courses.Remove(course);
        }
    }
}