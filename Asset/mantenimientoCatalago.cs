using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
        private const string ConnectionString = "Data Source=UCAWVMW\\ASSET;Initial Catalog=Assetcontrol;Integrated Security=true;";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("INSERT INTO hts (HTS, Description, Comment) VALUES (@nhts, @descripcion, @comentario)", connection))
                    {
                        // Obtener valores de los controles
                        string nhts = txtnhts.Text;
                        string descripcion = txtdescripcion.Text;
                        string comentario = txtcomentario.Text;

                        // Configurar parámetros
                        command.Parameters.AddWithValue("@nhts", nhts);
                        command.Parameters.AddWithValue("@descripcion", descripcion);
                        command.Parameters.AddWithValue("@comentario", comentario);

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Datos almacenados en la tabla 'HTS' con éxito.",
                                    "Operación Exitosa",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al almacenar datos: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
