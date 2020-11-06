using N00029793T3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N00029793T3.IClases
{
    public interface IIntermedio
    {
        public void IntermedioR(int id);
    }
    public class Intermedio : IIntermedio
    {
        private readonly N00029793Context _context;
        public Intermedio(N00029793Context context)
        {
            this._context = context;
        }
        public void IntermedioR(int id)
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int vejercicio = random.Next(1, 20);
                var tiempo = random.Next(60, 120);
                DetalleRutina det = new DetalleRutina { IdEjercicio = vejercicio, IdRutina = id, Time = Convert.ToString(tiempo) };
                _context.DetalleRutinas.Add(det);
                _context.SaveChanges();
            }
        }
    }
}
