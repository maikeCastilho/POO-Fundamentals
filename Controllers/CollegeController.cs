using SearchOOP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchOOP.Controllers
{
    public class CollegeController
    {
        private College college;

        public CollegeController(College college)
        {
            this.college = college;
        }


        // Método para exibir o menu de opções
        private void ShowMenu()
        {
            Console.WriteLine("-------------- Sistema de Cadastro --------------");
            Console.WriteLine("1. Cadastrar Aluno      |  4. Exibir Alunos");
            Console.WriteLine("2. Cadastrar Professor  |  5. Exibir Professores");
            Console.WriteLine("3. Cadastrar Curso      |  6. Exibir Cursos");
            Console.WriteLine("7. Sair");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("");
        }

        // Método para cadastrar um aluno
        private void RegisterStudent()
        {
            Console.WriteLine("");
            Console.WriteLine("Informe os dados do aluno:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            // Criar um novo aluno e adicioná-lo ao college
            Student student = new Student(id, name, email);

            college.AddStudent(student);
            Console.WriteLine("Aluno cadastrado com sucesso!");
            Console.WriteLine("");

        }

        // Método para cadastrar um professor
        private void RegisterProfessor()
        {
            Console.WriteLine("");
            Console.WriteLine("Informe os dados do professor: ");
            Console.WriteLine("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: ");
            string name = Console.ReadLine();


            Teacher professor = new Teacher(id, name);

            college.AddTeacher(professor);
            Console.WriteLine("Professor cadastrado com sucesso!");
            Console.WriteLine("");

            Console.WriteLine("Selecione um curso para associar ao professor:");
            college.DisplayCourses();
            Console.Write("ID do curso: ");
            int courseId = int.Parse(Console.ReadLine());


            Course selectedCourse = college.Courses.FirstOrDefault(c => c.Id == courseId);
            if (selectedCourse != null)
            {
                // Adicionar o professor ao curso selecionado
                college.AddTeacherToCourse(professor, selectedCourse);
                Console.WriteLine("Professor associado ao curso com sucesso!");
            }
            else
            {
                Console.WriteLine("Curso não encontrado.");
            }

        }

        // Método para cadastrar um curso
        private void RegisterCourse()
        {
            Console.WriteLine("");
            Console.WriteLine("Informe os dados do Curso ");
            Console.WriteLine("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome: ");
            string name = Console.ReadLine();

            Course course = new Course(id, name);

            college.AddCourse(course);

        }

        // Método principal para executar o sistema
        public void Run()
        {
            bool running = true;

            while (running)
            {
                // Exibir o menu de opções
                ShowMenu();

                // Ler a opção do usuário
                Console.Write("Escolha uma opção: ");
                string option = Console.ReadLine();


                // Executar a ação correspondente à opção escolhida
                switch (option)
                {
                    case "1":
                        RegisterStudent();
                        break;

                    case "2":
                        RegisterProfessor();
                        break;

                    case "3":
                        RegisterCourse();
                        break;

                    case "4":
                        college.DisplayStudents();
                        break;

                    case "5":
                        college.DisplayTeachers();
                        break;

                    case "6":
                        college.DisplayCourses();
                        break;

                    case "7":
                        running = false; // Sair do loop e encerrar o programa
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }
            }

            Console.WriteLine("Programa encerrado.");
        }
    }
}
