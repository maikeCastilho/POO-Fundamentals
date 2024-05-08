using SearchOOP.Controllers;
using SearchOOP.Models;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SearchOOP
{
    public class Program
    {
        static void Main(string[] args)
        {

            College college = new College("Unifoa");
            CollegeController collegeController = new CollegeController(college);

            collegeController.Run();

            


        }
    }
}