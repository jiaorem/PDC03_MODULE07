using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.EntityFrameworkCore;
using PDC03_MODULE07.Model;
using System.IO;

using Xamarin.Forms;

namespace PDC03_MODULE07.Services
{
    public class DatabaseContext:DbContext
    {
        public DbSet<EmployeeModel> Employee { get; set; }
        public DatabaseContext() 
        { 
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Employee.db");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }

    }
}