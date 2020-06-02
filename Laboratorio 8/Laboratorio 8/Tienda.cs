using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    class Tienda : Locales
    {
        private string categoria;

        public Tienda(string nombre, string n_dueño, string id, string horario, string categoria) : base(nombre, n_dueño, id, horario)
        {
            this.categoria = categoria;
        }
    }
}
