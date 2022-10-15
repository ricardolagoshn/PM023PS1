using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace PM023PS1.Models
{
    public class Empleado
    {
        [PrimaryKey, AutoIncrement]
        public int id {get; set;}

        [MaxLength(100)]
        public String nombres { get; set; }

        [MaxLength(100)]
        public String apellidos { get; set; }
        public int edad { get; set; }
        public String correo { get; set; }
    }
}
