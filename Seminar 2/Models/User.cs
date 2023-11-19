﻿namespace Seminar_2.Models
{
    public class User
    {
        public User()
        {
            UserName = string.Empty;
            Password= string.Empty;
            Surname = string.Empty;
            Name = string.Empty;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public String Surname { get; set; }

        public string Name { get; set; }

        public DateTime? LastLogin { get; set; }

        public static List<User> GetAll()
        {
            var users = new List<User>();

            users.Add(new User() { Id = 1, UserName = "aciobote", Password = "andreea"});
            users.Add(new User() { Id = 2, UserName = "Mihai", Password = "200" });
            users.Add(new User() { Id = 3, UserName = "Ioana", Password = "300" });

            return users;
        }
    }
}