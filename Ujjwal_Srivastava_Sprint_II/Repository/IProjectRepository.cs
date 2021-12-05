using System;
using System.Collections.Generic;
using Ujjwal_Srivastava_Sprint_II.Models;
namespace Ujjwal_Srivastava_Sprint_II.Repository
{
    public interface IProjectRepository
    {
        void CreateProject(Project project);
        List<Project> GetAllProject();
        Project GetProjectFromId(int id);
        void UpdateProject(Project project);
    }
}
