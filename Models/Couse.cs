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

        public Course(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

    }
}
