using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DhlSystem.Model
{
    [Table("employees")]
    class Employee
    {
        [Key]
        [Column("employeeid")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("position")]
        public string Position { get; set; }
        [Column("tourid")]
        public int TourId { get; set; }

        public Employee()
        {
        }

        public Employee(string name, string position, int tourid)
        {
            this.Name = name;
            this.Position = position;
            this.TourId = tourid;
        }
    }
}