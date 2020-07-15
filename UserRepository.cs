using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task3
{
    public class UserRepository : IUserRepository
    {
       private List<User> users = new List<User>();

        public UserRepository() 
        {
            for(int i = 0; i < 100; i++)
            { 
            users.Add(new User()
            {
                id = i,
                name = "Ankit" + i,
                email = "Ankit" + i + "@gmail.com",
                location = "hyderabad",
                address = "sector4",
                isActive = (byte)((i % 4 == 0 || i % 5 == 0) ? 1 : 0)
            });
            }
        }
        public List<User> Users() 
        {
            return users;
        }

        public User GetUser(int id)
        {
            User getUser = users.Where(a=>a.id==id).FirstOrDefault();
            return getUser;
        }

        public List<User> DeleteUser(int id) 
        {
            List<User> newList= users.Where(a => a.id == id).ToList();
            foreach (User item in newList)
            {
                users.Remove(item);
            }
            return users;
        }

        public List<User> ActiveUsers() 
        {
            List<User> activeUsers = users.Where(a => a.isActive == 1).ToList();
            return activeUsers;
        }

        public List<User> AddUser(User user)
        {
            users.Add(user);
            return users;
        }

        public User GetUserWithOutLinq(int id)
        {
            foreach (User item in users)
            {
                if (item.id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public List<User> DeleteUserWithOutLinq(int id)
        {
            users.RemoveAll(a => a.id == id);
            return users;
        }

        public List<User> ActiveUsersWithOutLinq()
        {
            List<User> activeList = new List<User>();
            foreach (User item in users)
            {
                if (item.isActive == 1)
                {
                    activeList.Add(item);
                }
            }
            return activeList;
        }
    }
}
