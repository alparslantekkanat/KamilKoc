using CloudTours.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudTours.Management.Application.Users
{
    public class FakeUserService : IUserService
    {

        private List<User> users;
        public FakeUserService()
        {
            users = new List<User>
            {
                new User
                {
                    Id = 1,

                    Eposta = "user1@test.com",
                    FullName = "UserOne",
                    UserName = "user1",
                    Password = "123",
                    Role = "Admin"
                },
                new User
                {
                    Id = 2,
                    FullName = "UserTwo",
                    Eposta = "user2@test.com",
                    UserName = "user2",
                    Password = "123",
                    Role = "Client"
                },
                new User
                {
                    Id = 3,
                    FullName = "UserThree",
                    Eposta = "user3@test.com",
                    UserName = "user3",
                    Password = "123",
                    Role = "Editor"
                },
            };
        }

        public User ValidateUser(string userName, string password)
        {
            return users.FirstOrDefault(u => u.UserName == userName && u.Password == password);
        }
    }

}

