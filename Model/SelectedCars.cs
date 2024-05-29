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
    [Table("selectedcars")]
    class SelectedCars
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("driverid")]
        public int DriverId { get; set; }
        [Column("carid")]
        public int CarId { get; set; }

        public SelectedCars()
        {
            
        }
        public SelectedCars(int driverid, int carid)
        {
            this.DriverId = driverid;
            this.CarId = carid;
        }
    }
    
}
