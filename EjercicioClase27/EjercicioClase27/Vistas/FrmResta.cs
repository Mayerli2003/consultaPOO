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
    public partial class FrmResta : Form
    {
        public FrmResta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                Double Operacion1 = Convert.ToDouble(Valor1.Text);
                Double Operacion2 = Convert.ToDouble(Valor2.Text);
                
                
                Operaciones operaciones = new Operaciones();
                ClsOperaciones clsOperaciones = new ClsOperaciones();
                operaciones.Resultado.ToString();

                MessageBox.Show("El resultado de la resta es  " + clsOperaciones.resta(operaciones));


                
            }catch (Exception ex)
            {
                 MessageBox.Show("Operacion incompleta");

            }



          

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
