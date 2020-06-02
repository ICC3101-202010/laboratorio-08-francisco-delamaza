using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    class Restaurante:Locales
    {
        private bool mesas_exclusivas;

        public Restaurante(string nombre, string n_dueño, string id, string horario, bool mesas_exclusivas) : base(nombre, n_dueño, id, horario)
        {
            this.mesas_exclusivas = mesas_exclusivas;
        }
        public void aña(Restaurante r)
        {
            
        }
    }
}
