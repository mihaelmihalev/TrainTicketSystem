using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketSystem
{
    public class UserProfileManagmentSystem
    {
        private List<User> users = new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
            Console.WriteLine("User added successfully.");
        }

        public void EditUser(string username, User user)
        {
            int index = users.FindIndex(u => u.Username == username);
            if (index >= 0)
            {
                users[index] = user;
                Console.WriteLine("User edited successfully.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

        public void ViewUser(string username)
        {
            int index = users.FindIndex(u => u.Username == username);
            if (index >= 0)
            {
                Console.WriteLine("Username: {0}", users[index].Username);
                Console.WriteLine("Role: {0}", users[index].Role);
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
    }

}

