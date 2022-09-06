using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleManegmentSystem.Model
{
    public enum Role
    {
        Admin , Employee
    }
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public Role UserRole { get; set; }
        public virtual ICollection<Report> Reports { get; set; }

        public override string ToString()
        {
            return string.Format("{0}\t\t{1}\t\t{2}\t\t{3}",UserId,UserName,UserRole,IsActive); 
        }
    }
}
