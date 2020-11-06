using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N00029793T3.Models
{
    public class Rutina
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdUsuario { get; set; }
        public int Nivel { get; set; }
        public DateTime FechaCreacion { get; set; }
        public User users { get; set; }

    }
}
