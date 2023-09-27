using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fast_Crud
{
    [Dapper.Contrib.Extensions.Table("users")]
    public class UserDTO
    {
        [Column("id")]
        [Key]
        public int id { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("password")]
        public string? Password { get; set; }
        [Column("state")]
        public int State { get; set; } = 1;
        [Column("id_role")]
        public int Id_Role { get; set; } = 1;

        public override string ToString()
        {
            if (this.State == 1)
            {
                return $"Nombre: {Name}, Disponible: Si";
            }
            else
            {
                return $"Nombre: {Name}, Disponible: No";
            }
        }
    }
}
