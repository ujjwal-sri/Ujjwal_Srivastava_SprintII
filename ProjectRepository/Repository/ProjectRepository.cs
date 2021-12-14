using System;
using System.Linq;
using System.Collections.Generic;
using ProjectRepository.DBAccess;
using ProjectRepository.Models;

namespace ProjectRepository.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly DBContext _context;
        public ProjectRepository(DBContext context)
        {
            _context = context;
        }

        public void CreateProject(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public List<Project> GetAllProject()
        {
            return _context.Projects.ToList();
        }

        public Project GetProjectFromId(int id)
        {
            return _context.Projects.FirstOrDefault(x => x.ID == id);
        }

        public void UpdateProject(Project project)
        {
            _context.Projects.Update(project);
            _context.SaveChanges();
        }
    }
}
