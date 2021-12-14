using System;
using System.Linq;
using System.Collections.Generic;
using ProjectRepository.Models;
using ProjectRepository.DBAccess;

namespace ProjectRepository.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DBContext _context;

        public UserRepository(DBContext context)
        {
            _context = context;
        }

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserFromId(int id)
        {
            return _context.Users.FirstOrDefault(x => x.ID == id);
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public User ValidateUser(string email, string pwd)
        {
            return _context.Users.FirstOrDefault(x => x.Email == email);
        }
    }
}
