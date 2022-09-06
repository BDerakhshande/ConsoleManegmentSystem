using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleManegmentSystem.ConsoleUI
{
    public static class Ui
    {
        public static int ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine(" ---------------------------- Main Menu ---------------------------- ");
            Console.WriteLine("1)Admin Panel");
            Console.WriteLine("2)Employee Panel");
            Console.WriteLine("3)Exit");
            Console.WriteLine("Enter Panel Number :");
            return Convert.ToInt32(Console.ReadLine());
            
        }

        public static int ShowAdminPanel()
        {
            Console.Clear();
            Console.WriteLine(" ---------------------------- Admin Panel  ---------------------------- ");
            Console.WriteLine("1)Show All User");
            Console.WriteLine("2)Add User");
            Console.WriteLine("3)Delete User");
            Console.WriteLine("4)Back To Main Menu");
            Console.WriteLine("Enter Command Number : ");
            return Convert.ToInt32(Console.ReadLine());

        }

        public static int ShowEmployeePanel()
        {
            Console.Clear();
            Console.WriteLine(" ---------------------------- Employee Panel  ---------------------------- ");
            Console.WriteLine("1)Register Reoprt");
            Console.WriteLine("-------");
            Console.WriteLine("-------");
            Console.WriteLine("4)Back To Main Menu");
            Console.WriteLine("Enter Command Number : ");
            return Convert.ToInt32(Console.ReadLine());

        }
    }
}
