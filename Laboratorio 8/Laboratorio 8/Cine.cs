using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    class Cine : Locales
    {
        private string salas;

        public Cine(string nombre, string n_dueño, string id, string horario, string salas) : base(nombre, n_dueño, id, horario)
        {
            this.salas = salas;
        }
    }
}
