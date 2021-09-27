using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioClase27.Entidades;
using EjercicioClase27.Negocio;

namespace EjercicioClase27.Vistas
{
    public partial class MenuAplicacion : Form
    {
        public MenuAplicacion()
        {
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formularioEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.MdiParent = this;
            estudiante.Show();
            
        }

        private void MenuAplicacion_Load(object sender, EventArgs e)
        {

        }
    }
}
