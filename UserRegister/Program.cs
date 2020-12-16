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
            Console.Write("Enter Email ID: ");
            string Email_Id = Console.ReadLine();
            Console.WriteLine(Register.Email(Email_Id));
            Console.Write("Enter Mobile Number: ");
            string Mobile_Number = Console.ReadLine();
            Console.WriteLine(Register.MobileNumber(Mobile_Number));
            Console.Write("Enter Paswrod: ");
            string Pwd = Console.ReadLine();
            Console.WriteLine(Register.Password(Pwd));
            
        }
    }
}
