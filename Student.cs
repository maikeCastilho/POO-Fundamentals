using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchOOP.Models
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        private string email;

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

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //construct method
        public Student(int id, string name, string email)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Email = email;

        }
    }
}
