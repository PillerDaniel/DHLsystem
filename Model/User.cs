using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DhlSystem.Model
{
    [Table("users")]
    class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("username")]
        public string UserName { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("permission")]
        public string permission { get; set; }
        public User()
        {
            
        }
        public User(string username, string password, string permission)
        {
            this.UserName = username;
            this.Password = password;
            this.permission = permission;
        }
    }
}
