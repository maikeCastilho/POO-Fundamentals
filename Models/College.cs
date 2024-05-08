using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchOOP.Models
{
    public class College
    {
        //Atributos
        private string collegeName;
        private List<Course> courses;
        private List<Teacher> teachers;
        private List<Student> students;

        //propriedades (accessor)
        public string College_Name
        {
            get { return collegeName; }
            set { collegeName = value; }
        }

        public List<Course> Courses
        {
            get { return courses; }
            set { courses = value; }
        }

        public List<Teacher> Teachers
        {
            get { return teachers; }
            set { teachers = value; }
        }

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        //construct method
        public College(string college_name)
        {
            this.collegeName = college_name;
            this.students = new List<Student>();
            this.courses = new List<Course>();
            this.teachers = new List<Teacher>();
        }

        //COURSE METHODS
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            courses.Remove(course);
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public void DisplayStudents()
        {
            Console.WriteLine("");
            Console.WriteLine("Students:");
            if (students.Any())
            {
                foreach (var student in students)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Email: {student.Email}");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("No students avaliable");
                Console.WriteLine("");
            }
        }

        public void DisplayCourses()
        {
            Console.WriteLine("");
            Console.WriteLine("Courses:");
            if (courses.Any())
            {
                foreach (var course in courses)
                {
                    Console.WriteLine($"ID: {course.Id}, Name: {course.Name}");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("No courses available");
                Console.WriteLine("");
            }
        }

        public void DisplayTeachersWithCourses()
        {
            Console.WriteLine("");
            Console.WriteLine("Teachers:");

            if (teachers.Count > 0)
            {

                foreach (var teacher in teachers)
                {

                    // Verificar se o professor está associado a algum curso
                    if (teacher.Courses.Any())
                    {
                        foreach (var course in teacher.Courses)
                        {
                            Console.WriteLine($"Name: {teacher.Name} - Course: {course.Name}");
                        }
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine($"Name: {teacher.Name}");
                    }
                    Console.WriteLine(""); // Adicionar uma linha em branco para separar os professores
                }
            }
            else
            {
                Console.WriteLine("No teachers associated.");
                Console.WriteLine("");
            }
        }

        public void AddTeacherToCourse(Teacher teacher, Course course)
        {
            teacher.AddCourse(course);
            course.AddTeacher(teacher);
        }

        public void RemoveTeacherFromCourse(Teacher teacher, Course course)
        {
            teacher.RemoveCourse(course);
            course.RemoveTeacher(teacher);
        }
    }
}