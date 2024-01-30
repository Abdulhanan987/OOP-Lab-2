using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StudenManagementSystem
{

    internal class Program
    {


        static void Main(string[] args)
        {
            int option = 0;
            int x = 0;
            Student[] students = new Student[100];
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Student Management System : ");
                Console.WriteLine("1.Add Students: ");
                Console.WriteLine("2.Show Students: ");
                Console.WriteLine("3.Calculate Aggregate: ");
                Console.WriteLine("4.Top Students: ");
                 option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Console.Clear();
                    students[x] = addStudent();
                    x++;
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();

                }
                else if (option == 2)
                {
                    Console.Clear();
                    ShowStudentData(students, x);
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    Console.Clear();
                    aggregateCalculator(students, x);
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else if (option == 4)
                {
                    Console.Clear();
                    showTopStudents(students, x);
                    Console.WriteLine("Press any key to continue: ");
                    Console.ReadKey();
                }
                else
                    break;
            }

        }
        static Student addStudent()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your matric marks: ");
            float matric = float.Parse(Console.ReadLine());
            Console.Write("Enter your fsc marks: ");
            float inter = float.Parse(Console.ReadLine());
            Console.Write("Enter your ecat Marks: ");
            float ecat = float.Parse(Console.ReadLine());
            Student s1 = new Student(name, matric, inter, ecat);

            return s1;
          
        }
        static void aggregateCalculator(Student[] students, int count)
        {
            for (int i = 0; i < count; i++)
            {
                students[i].aggregate = ((students[i].matricMarks)/1100 * 17)  + ((students[i].fscmarks)/550 * 50)  + ((students[i].ecatMarks)/400 * 33) ;
                Console.WriteLine(students[i].aggregate);
            }
            
        }
        static void ShowStudentData(Student[] student, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Name: " + student[i].sname);
                Console.WriteLine("Matric Marks: " + student[i].matricMarks);
                Console.WriteLine("Fsc Marks: " + student[i].fscmarks);
                Console.WriteLine("Ecat Marks: " + student[i].ecatMarks);
                Console.WriteLine();
            }
           

        }
        static void showTopStudents(Student[] students,int count )
        {
            int counter = 0;
            for(int i=0;i<count;i++)
            {
                if (i + 1 == count)
                {
                    if (students[i].aggregate > students[i - 1].aggregate)
                    {
                        Console.WriteLine(students[i].sname + " " + students[i].aggregate);
                        counter++;
                    }
                }
                else
                {
                    if (students[i].aggregate > students[i + 1].aggregate)
                    {
                        Console.WriteLine(students[i].sname + " " + students[i].aggregate);
                        counter++;
                    }
                }
                  
                if(counter==3) 
                {
                    break;
                }
               
                
            }
            
        }
    }
}
