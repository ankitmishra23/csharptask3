using System;
using System.Collections.Generic;
namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();

            //printing all users in the list by using Users() method 
            foreach(User item in userRepository.Users())
            {
                Console.WriteLine(item.id + "\t" + item.name + "\t" + item.email + "\t" + item.location + "\t" + item.address + "\t" + item.isActive);
            }

            Console.WriteLine("Enter any key to see output of other method");
            Console.ReadLine();



            //retriving data of user with given id using GetUser() method.
            Console.WriteLine("Enter the id you want to search");
            int id = Convert.ToInt32(Console.ReadLine());

            User resultUser = userRepository.GetUser(id);
            if (resultUser != null)
                Console.WriteLine("Required user is " + resultUser.id + "\t" + resultUser.name + "\t" + resultUser.email + "\t" + resultUser.location + "\t" + resultUser.address + "\t" + resultUser.isActive);
            else
                Console.WriteLine("No user found with given id.");

            Console.WriteLine("Enter any key to see output of other method");
            Console.ReadLine();

            //removing a particular user using DeleteUser() method.
            Console.WriteLine("Enter id to remove user");
            int deleteId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultant list after deleting is \n");
            foreach (User item in userRepository.DeleteUser(deleteId))
            {
                Console.WriteLine( item.id + "\t" + item.name + "\t" + item.email + "\t" + item.location + "\t" + item.address + "\t" + item.isActive);
            }


            Console.WriteLine("Enter any key to see all the active users.");
            Console.ReadLine();

            //checking for active users using ActiveUsers() method.
            Console.WriteLine("Active Users are\n");
            foreach (User item in userRepository.ActiveUsers())
            {
                Console.WriteLine(item.id + "\t" + item.name + "\t" + item.email + "\t" + item.location + "\t" + item.address + "\t" + item.isActive);
            }


            Console.WriteLine("Enter any key to see output of AddUser() method");
            Console.ReadLine();

            //adding new user in the list using AddUser() method.
            Console.WriteLine("Enter the details of new user");
            Console.WriteLine("Enter id");
            int newUserId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            string newName = Console.ReadLine();
            Console.WriteLine("Enter email");
            string newEmail = Console.ReadLine();
            Console.WriteLine("Enter loaction");
            string newLocation = Console.ReadLine();
            Console.WriteLine("Enter address");
            string newAddress = Console.ReadLine();
            Console.WriteLine("Enter 1 for active and 0 for inactive");
            byte newIsActive = Convert.ToByte(Console.ReadLine());
            User newUser = new User();
            newUser.id = newUserId;
            newUser.name = newName;
            newUser.email = newEmail;
            newUser.location = newLocation;
            newUser.address = newAddress;
            newUser.isActive = newIsActive;

            Console.WriteLine(" Users including newly added user are\n");
            foreach (User item in userRepository.AddUser(newUser))
            {
                Console.WriteLine(item.id + "\t" + item.name + "\t" + item.email + "\t" + item.location + "\t" + item.address + "\t" + item.isActive);
            }



            //performing some tasks without LINQ

            //finding the user by id.
            Console.WriteLine("Performing some tasks without using LINQ");

            Console.WriteLine("Enter the id you want to search");
            int newId = Convert.ToInt32(Console.ReadLine());

            User newResultUser = userRepository.GetUserWithOutLinq(newId);
            if (newResultUser != null)
                Console.WriteLine("Required user is " + newResultUser.id + "\t" + newResultUser.name + "\t" + newResultUser.email + "\t" + newResultUser.location + "\t" + newResultUser.address + "\t" + newResultUser.isActive);
            else
                Console.WriteLine("No user found with given id.");

            Console.WriteLine("Enter any key to see output of other method");
            Console.ReadLine();

            //removing a particular user without using LINQ.
            Console.WriteLine("Enter id to remove user");
            int newDeleteId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resultant list after deleting is \n");
            foreach (User item in userRepository.DeleteUserWithOutLinq(newDeleteId))
            {
                Console.WriteLine(item.id + "\t" + item.name + "\t" + item.email + "\t" + item.location + "\t" + item.address + "\t" + item.isActive);
            }


            //finding all the active users without using linq.

            Console.WriteLine("Enter any key to see active users");
            Console.ReadLine();

            Console.WriteLine("Active Users are\n");
            foreach (User item in userRepository.ActiveUsersWithOutLinq())
            {
                Console.WriteLine(item.id + "\t" + item.name + "\t" + item.email + "\t" + item.location + "\t" + item.address + "\t" + item.isActive);
            }

        }
    }
}
