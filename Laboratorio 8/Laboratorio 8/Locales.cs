using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    public abstract class Locales
    {
        
        public string nombre;
        public string n_dueño;
        public string id;
        public string horario;

        public Locales(string nombre, string n_dueño, string id, string horario)
        {
            this.nombre = nombre;
            this.n_dueño = n_dueño;
            this.id = id;
            this.horario = horario;
        }

       
    }
}
