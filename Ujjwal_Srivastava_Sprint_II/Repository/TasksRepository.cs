using System;
using System.Linq;
using System.Collections.Generic;
using Ujjwal_Srivastava_Sprint_II.Models;
using Ujjwal_Srivastava_Sprint_II.DBAccess;

namespace Ujjwal_Srivastava_Sprint_II.Repository
{
    public class TasksRepository : ITasksRepository
    {
        private readonly DBContext _context;
        public TasksRepository(DBContext context)
        {
            _context = context;
        }

        public void CreateTasks(Tasks tasks)
        {
            _context.Tasks.Add(tasks);
            _context.SaveChanges();
        }

        public List<Tasks> GetAllTasks()
        {
            return _context.Tasks.ToList();
        }

        public Tasks GetTasksFromId(int id)
        {
            return _context.Tasks.FirstOrDefault(x => x.ID == id);
        }

        public void UpdateTasks(Tasks tasks)
        {
            _context.Tasks.Update(tasks);
            _context.SaveChanges();
        }
    }
}
