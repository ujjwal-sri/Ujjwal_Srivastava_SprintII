using System;
using System.Collections.Generic;
using Ujjwal_Srivastava_Sprint_II.Models;
namespace Ujjwal_Srivastava_Sprint_II.Repository
{
    public interface ITasksRepository
    {
        void CreateTasks(Tasks tasks);
        List<Tasks> GetAllTasks();
        Tasks GetTasksFromId(int id);
        void UpdateTasks(Tasks tasks);
    }
}
