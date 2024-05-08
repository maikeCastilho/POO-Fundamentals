using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchOOP.Models
{
    public class Course
    {
        private int id;
        private string name;
        private List<Teacher> teachers;
        private List<Subject> subjects;

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

        public List<Subject> Subjects
        {
            get { return subjects; }
            set { subjects = value; }
        }

        public Course(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Subjects = new List<Subject>();
            this.teachers = new List<Teacher>();
        }

        public void AddMateria(Subject subject)
        {
            subjects.Add(subject);
        }

        public void RemoveMateria(Subject subject)
        {
            subjects.Remove(subject);
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void AddTeacher(List<Teacher> newTeachers)
        {
            foreach (var teacher in newTeachers)
            {
                teachers.Add(teacher);
            }
        }

        public void RemoveTeacher(Teacher teacher)
        {
            teachers.Remove(teacher);
        }

        public void DisplayMaterias()
        {
            Console.WriteLine("");
            Console.WriteLine("Materias:");

            if (subjects.Count > 0)
            {
                foreach (var materia in subjects)
                {
                    Console.WriteLine($"ID: {materia.Id}, Name: {materia.Name}");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("No materias associated.");
                Console.WriteLine("");
            }
        }
    }
}