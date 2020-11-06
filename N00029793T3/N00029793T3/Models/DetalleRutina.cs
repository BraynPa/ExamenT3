using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N00029793T3.Models
{
    public class DetalleRutina
    {
        public int Id { get; set; }
        public int IdEjercicio { get; set; }
        public int IdRutina { get; set; }
        public string Time { get; set; }

        public Ejercicio ejercicio { get; set; }
    }
}
