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
using EjercicioClase27.Vistas;

namespace EjercicioClase27.Vistas
{
    public partial class FrmSuma : Form
    {
        public FrmSuma()
        {
            InitializeComponent();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            Operaciones operaciones = new Operaciones();
            ClsOperaciones clsOperaciones = new ClsOperaciones();
            operaciones.Operacion1 = Convert.ToDouble(valor1.Text);
            operaciones.Operacion2 = Convert.ToDouble(Valor2.Text);
            valor1.Text = operaciones.Operacion1.ToString();
            Valor2.Text = operaciones.Operacion2.ToString();
            Double resultado = clsOperaciones.suma(operaciones);

           
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
