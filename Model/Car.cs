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
    [Table("cars")]
    class Car
    {
        [Key]
        [Column("carid")]
        public int Id { get; set; }
        [Column("brand")]
        public string Brand { get; set; }
        [Column("type")]
        public string Type { get; set; }
        [Column("plate")]
        public string Plate { get; set; }
        [Column("km")]
        public int Km { get; set; }

        public Car(string brand, string type, string plate, int km)
        {
            this.Brand = brand;
            this.Type = type;
            this.Plate = plate;
            this.Km = km;
        }
    }
}
