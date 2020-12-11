using System;
using System.Text.RegularExpressions;
namespace UserRegisteration
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("***********Welcome To User Registration**********");
            UserRegister Register = new UserRegister();
            Console.Write("Enter First Name : ");
            string First_Name = Console.ReadLine();
            Console.WriteLine(Register.FirstName(First_Name));
            Console.Write("Enter Last Name : ");
            string Last_Name = Console.ReadLine();
            Console.WriteLine(Register.LastName(Last_Name));
        }
    }
}
