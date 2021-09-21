using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entidades;
using WindowsFormsApp1.Negocio;
using WindowsFormsApp1.Vistas;

namespace WindowsFormsApp1
{
    //Ventas ventas = new Ventas();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = texCapturarDatos.Text;
            ClsPersona clsPersona = new ClsPersona();
            String nombre = clsPersona.MostrarNombre(persona);
            MessageBox.Show(nombre);
            persona.Nombre = texCapturarDatos.Text;
            persona.Contra = texContra.Text;
            int valor = clsPersona.Acceso(persona);
            //_= valor;
            if(valor == 1)
            {
                //MessageBox.Show("Welcom");
                Ventas ventas = new Ventas();
                ventas.Show();
            }
            else
            {
                MessageBox.Show("Error");

            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void texCapturarDatos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
