
namespace EjercicioClase27.Vistas
{
    partial class MenuAplicacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesMatematicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.operacionesMatematicasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioEstudianteToolStripMenuItem,
            this.formularioProfesorToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // formularioEstudianteToolStripMenuItem
            // 
            this.formularioEstudianteToolStripMenuItem.Name = "formularioEstudianteToolStripMenuItem";
            this.formularioEstudianteToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.formularioEstudianteToolStripMenuItem.Text = "Formulario estudiante";
            this.formularioEstudianteToolStripMenuItem.Click += new System.EventHandler(this.formularioEstudianteToolStripMenuItem_Click);
            // 
            // formularioProfesorToolStripMenuItem
            // 
            this.formularioProfesorToolStripMenuItem.Name = "formularioProfesorToolStripMenuItem";
            this.formularioProfesorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.formularioProfesorToolStripMenuItem.Text = "Formulario profesor";
            // 
            // operacionesMatematicasToolStripMenuItem
            // 
            this.operacionesMatematicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem,
            this.multiplicacionToolStripMenuItem,
            this.divisionToolStripMenuItem});
            this.operacionesMatematicasToolStripMenuItem.Name = "operacionesMatematicasToolStripMenuItem";
            this.operacionesMatematicasToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.operacionesMatematicasToolStripMenuItem.Text = "OperacionesMatematicas";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sumaToolStripMenuItem.Text = "Suma";
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restaToolStripMenuItem.Text = "Resta";
            // 
            // multiplicacionToolStripMenuItem
            // 
            this.multiplicacionToolStripMenuItem.Name = "multiplicacionToolStripMenuItem";
            this.multiplicacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.multiplicacionToolStripMenuItem.Text = "Multiplicacion";
            // 
            // divisionToolStripMenuItem
            // 
            this.divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            this.divisionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.divisionToolStripMenuItem.Text = "Division";
            // 
            // MenuAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "MenuAplicacion";
            this.Text = "MenuAplicacion";
            this.Load += new System.EventHandler(this.MenuAplicacion_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesMatematicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionToolStripMenuItem;
    }
}