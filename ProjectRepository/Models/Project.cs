using System;
namespace ProjectRepository.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
