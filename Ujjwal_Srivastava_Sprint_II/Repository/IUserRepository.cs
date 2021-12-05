using System;
using System.Collections.Generic;
using Ujjwal_Srivastava_Sprint_II.Models;
namespace Ujjwal_Srivastava_Sprint_II.Repository
{
    public interface IUserRepository
    {
        void CreateUser(User user);
        List<User> GetAllUsers();
        User GetUserFromId(int id);
        void UpdateUser(User user);
        User ValidateUser(string email, string pwd);
    }
}
