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
        private string college_name;
        private List<Course> courses;
        private List<Teacher> teachers;
        private List<Student> students;

        //properties (accessor)
        public string College_Name
        {
            get { return college_name; }
            set { college_name = value; }
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
            this.college_name = college_name;
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

        public void DisplayCourses()
        {
            Console.WriteLine("");
            Console.WriteLine("Courses:");
            if (courses.Any()) {
                foreach (var course in courses)
                {
                    Console.WriteLine($"ID: {course.Id}, Name: {course.Name}");

                }
                Console.WriteLine("");
            }

            else
            {
                Console.WriteLine("No courses avaliable");
                Console.WriteLine("");

            }
            
        }

        //STUDENT METHODS
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


        //TEACHER METHODS
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);

        }

        public void RemoveTeacher(Teacher teacher)
        {
            teachers.Remove(teacher);

        }

        public void AddTeacherToCourse(Teacher teacher, Course course)
        {
            teacher.AddCourse(course);

        }

        public void RemoveTeacherFromCourse(Teacher teacher, Course course)
        {
            teacher.RemoveCourse(course);
            RemoveTeacher(teacher);

        }

        public void DisplayTeachers()
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
    }
}