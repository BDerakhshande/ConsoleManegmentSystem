using SampleManegmentSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleManegmentSystem.Repository
{
    public class UserRepository
    {
        private List<User> users;
        public UserRepository()
        {
            users = new List<User>();
            users.Add(new User
            {
                UserId = 1,
                UserName = "Admin",
                Password = "123",
                PhoneNumber = 09114344,
                Email = "batool",
                IsActive = true,
                UserRole = Role.Admin
            });
        }
        public void AddEmployee(User user)
        {
            users.Add(user);
            Console.WriteLine("User register....");
        }

        public int GetUsersCount()
        {
            return users.Count;
        }
        public void DeleteUsers(int id)
        {
            var user = users.FirstOrDefault(x => x.UserId == id && x.UserRole != Role.Admin);
            if (user != null)
            {
                users.Remove(user);
                Console.WriteLine("User Deleted...");
            }
            else
            {
                Console.WriteLine("Not find user...");
            }

        }
        public void ShowInformatin()
        { 
            users.ForEach(user => Console.WriteLine(user));
            Console.ReadKey();

        }

        public User GetUser(string username , string passwprd)
        {
            return users.FirstOrDefault(t => t.UserName.Equals(username) && t.Password.Equals(passwprd));
        }

        public bool Login(string username , string password)
        {
           bool result = users.Any(x => x.UserName.Equals(username) && x.Password.Equals(password));
            return result;
        }

        public int GetNewId()
        {
           return users.Last().UserId + 1;
        }
    }
}
