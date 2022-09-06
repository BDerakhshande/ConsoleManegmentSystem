using SampleManegmentSystem.ConsoleUI;
using SampleManegmentSystem.Model;
using SampleManegmentSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleManegmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int panelNumber = Ui.ShowMainMenu();
            UserRepository userRepository = new UserRepository();
            while (true)
            {
                switch (panelNumber)
                {
                    case 1:
                        #region Admin Panel
                        Console.Write("Enter UserName:");
                        string userName = Console.ReadLine();
                        Console.Write("Enter Password:");
                        string password = Console.ReadLine();
                        if (userRepository.Login(userName, password) == true)
                        {
                            int adminCommandNumber = Ui.ShowAdminPanel();
                            switch (adminCommandNumber)
                            {
                                case 1:
                                    userRepository.ShowInformatin();
                                    break;
                                case 2:
                                    User user = new User();
                                    user.UserId = userRepository.GetNewId();
                                    Console.Write("Enter UserName:");
                                    user.UserName = Console.ReadLine();
                                    Console.Write("Enter Password:");
                                    user.Password = Console.ReadLine();
                                    Console.Write("Enter Mobile:");
                                    user.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Enter Email:");
                                    user.Email = Console.ReadLine();
                                    user.IsActive = true;
                                    user.UserRole = Role.Employee;
                                    userRepository.AddEmployee(user);
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter User Id for Delete :");
                                    int userId = Convert.ToInt32(Console.ReadLine());
                                    userRepository.DeleteUsers(userId);
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    panelNumber = Ui.ShowMainMenu();
                                    break;


                            }
                        }
                        else
                        {
                            Console.WriteLine("Correct UserName or Password...");
                            Console.ReadKey();
                            panelNumber = Ui.ShowMainMenu();
                        }
                        break;

                    #endregion
                    case 2:
                        int EmployeeCommandNumber = Ui.ShowEmployeePanel();
                        Console.Write("Enter UserName:");
                        string userName1 = Console.ReadLine();
                        Console.Write("Enter Password:");
                        string password1 = Console.ReadLine();
                        if (userRepository.Login(userName1, password1) == true)
                        {
                            User user = userRepository.GetUser(userName1 , password1);
                            switch(EmployeeCommandNumber)
                            {
                                case 1:

                                    break;
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Correct UserName or Password...");
                            Console.ReadKey();
                            panelNumber = Ui.ShowMainMenu();
                        }
                        break;
                    case 3:

                        break;
                }
            }
        }
    }
}
