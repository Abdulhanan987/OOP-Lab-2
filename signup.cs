using SignUp.NewFolder1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            int x = 0;
            MUser[] User = new MUser[100];
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Business Application: ");
                Console.WriteLine("1. Sign Up: ....");
                Console.WriteLine("2. Sign In: ....");
                Console.WriteLine("3. Exit: ......");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();
                    User[x] = user();
                    x++;
                    Console.WriteLine("Press any key to continue: .....");
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    Console.Clear();
                    int needed = -1;
                    if (SignIn(User, ref x, ref needed) == true)
                    {
                        Console.WriteLine("You have succesfully signed in as " + User[needed].Role);
                    }
                    Console.WriteLine("Press any key to continue: .....");
                    Console.ReadKey();
                }
                else if (option==3)
                {
                    break;
                }

            }
        }
        static MUser user()
        {
            Console.Write("Enter the username: ");
            string username = Console.ReadLine();
            Console.Write("Enter the password: ");
            string password = Console.ReadLine();
            Console.Write("Enter the role: ");
            string role = Console.ReadLine();
            MUser mUser = new MUser(username, password, role);
            AddData(mUser);
            return mUser;
        }
        static void AddData(MUser mUser)
        {
            string path = "E:\\Semester 2\\Lab 2\\SignUp\\User.txt";
            if (File.Exists(path))
            {
                StreamWriter file = new StreamWriter(path, true);
                file.WriteLine(mUser.Username + "," + mUser.Password + "," + mUser.Role + ",");
                file.Flush();
                file.Close();

            }
        }
        static bool SignIn(MUser[] mUser, ref int count, ref int needed)
        {
            string path = "E:\\Semester 2\\Lab 2\\SignUp\\User.txt";
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string var;

                while ((var = file.ReadLine()) != null)
                {
                    MUser user = new MUser();
                    mUser[x] = user;
                    mUser[x].Username = getField(var, 1);
                    mUser[x].Password = getField(var, 2);
                    mUser[x].Role = getField(var, 3);
                    x++;
                }
                file.Close();
            }

            count = x;

            Console.Write("Enter the username: ");
            string username = Console.ReadLine();
            Console.Write("Enter the password: ");
            string password = Console.ReadLine();
            for (int i = 0; i < x; i++)
            {
                if (username == mUser[i].Username && password == mUser[i].Password)
                {

                    needed = i;
                    return true;

                }
            }
            return false;
        }
        static string getField(string record, int field)
        {
            int commaCount = 1;
            string result = "";
            for (int x = 0; x < record.Count(); x++)
            {
                if (record[x] == ',')
                {
                    commaCount = commaCount + 1;
                }
                else if (commaCount == field)
                {
                    result = result + record[x];
                }
            }
            return result;
        }
    }
}
