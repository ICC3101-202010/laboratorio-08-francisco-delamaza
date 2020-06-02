using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_8
{
    public partial class Form2 : Form
    {
        public Form2(List<Locales> l)
        {
            InitializeComponent();
            foreach(Locales i in l)
            {
               
                richTextBox1.Text += "Nombre: "+ i.nombre.ToString() +"  ID: " + i.id.ToString() + "  Dueño: " + i.n_dueño.ToString() +"\n";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
