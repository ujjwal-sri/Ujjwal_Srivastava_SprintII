using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectRepository.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
