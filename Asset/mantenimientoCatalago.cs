using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset
{
    public partial class mantenimientoCatalago : Form
    {
        public mantenimientoCatalago()
        {
            InitializeComponent();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox2.Location = new System.Drawing.Point(478, 43);
            groupBox3.Visible = false;
            groupBox3.Location = new System.Drawing.Point(478, 43);
            groupBox1.Visible = true;
            groupBox1.Location = new System.Drawing.Point(22, 43);
        }

        private void crearUnProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox1.Location = new System.Drawing.Point(478, 43);
            groupBox3.Visible = false;
            groupBox3.Location = new System.Drawing.Point(478, 43);
            groupBox2.Visible = true;
            groupBox2.Location = new System.Drawing.Point(22, 43);
        }

        private void crearProyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox1.Location = new System.Drawing.Point(478, 43);
            groupBox2.Visible = false;
            groupBox2.Location = new System.Drawing.Point(478, 43);
            groupBox3.Visible = true;
            groupBox3.Location = new System.Drawing.Point(22, 43);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<mantenimientoCatalago>().Any())
            {
                mantenimientoCatalago formularioMantenimiento = Application.OpenForms.OfType<mantenimientoCatalago>().First();
                formularioMantenimiento.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nhts = txtnhts.Text;
            string descripcion = txtdescricion.Text;
            string comentario = txtcomentario.Text;


            MessageBox.Show($"Valores:\nNumero de HTS: {nhts}\nDescripcion: {descripcion}\nComentario: {comentario}",
                            "Datos Guardados Exitosamente.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

    }
}
