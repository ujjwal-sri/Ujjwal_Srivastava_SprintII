using System;
using Microsoft.EntityFrameworkCore;
using Ujjwal_Srivastava_Sprint_II.Models;

namespace Ujjwal_Srivastava_Sprint_II.DBAccess
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
