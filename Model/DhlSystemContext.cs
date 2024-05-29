using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Resources;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DhlSystem.Model
{
    class DhlSystemContext : DbContext
    {
        public string connection = null;
        public DhlSystemContext()
        {
            connection = ConfigurationManager.AppSettings.Get("DBurl");
        }
        public DbSet <User> Users { get; set; }
        public DbSet <Car> Cars { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SelectedCars> SelectedCars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(connection);
        }

    }
}
