﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Locales> loc = new List<Locales>();


        private void Info(Locales l)
        {
            try
            {
                string hola = l.nombre;
                string este = l.n_dueño;
                string aee = l.id;
                string eea = l.horario;
                richTextBox1.Text = "Local: " + hola.ToString() +"  Dueño: " + este.ToString() + "  ID: "+ aee.ToString()+ "  Horario: " + eea.ToString();
            }
            catch
            {
                richTextBox1.Text = "No existe el Id";
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string dueño = textBox2.Text;
            string id = textBox3.Text;
            string horario = textBox4.Text;
            bool mesas = checkBox1.Checked;
            Restaurante r = new Restaurante(nombre, dueño, id, horario, mesas);
            loc.Add(r);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
        }

        private void Restaurante_Click(object sender, EventArgs e)
        {
            panelc.Visible = false;
            panelt.Visible = false;
            panelr.Visible = true;
        }

        private void Agregar2_Click(object sender, EventArgs e)
        {
            string nombre = textBox5.Text;
            string dueño = textBox6.Text;
            string id = textBox7.Text;
            string horario = textBox8.Text;
            string salas = textBox9.Text;
            Cine c = new Cine(nombre, dueño, id, horario, salas);
            loc.Add(c);
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();


        }

        private void cine_Click(object sender, EventArgs e)
        {
            panelc.Visible = true;
            panelr.Visible = false;
            panelt.Visible = false;
            
        }

        private void Agregar3_Click(object sender, EventArgs e)
        {
            string nombre = textBox10.Text;
            string dueño = textBox11.Text;
            string id = textBox12.Text;
            string horario = textBox13.Text;
            string categoria = textBox14.Text;
            Tienda t = new Tienda(nombre, dueño, id, horario, categoria);
            loc.Add(t);
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelt.Visible = true;
            panelc.Visible = false;
            panelr.Visible = false;
            
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string ids = textBoxID.Text;
            var l = loc.Where(Locales => Locales.id == ids).FirstOrDefault();
            richTextBox1.Clear();
            Info(l);


        }

        private void info_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void Volveri_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void Lista_locales_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(loc);
            f2.Show();
            
        }
    }
}
