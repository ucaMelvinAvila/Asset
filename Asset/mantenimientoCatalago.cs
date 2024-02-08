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
            if (TodosLosCamposEstanLlenosHTS())
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
            else
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool TodosLosCamposEstanLlenosHTS()
        {
            return !string.IsNullOrWhiteSpace(txtnhts.Text) &&
                   !string.IsNullOrWhiteSpace(txtdescripcion.Text) &&
                   !string.IsNullOrWhiteSpace(txtcomentario.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TodosLosCamposEstanLlenosSupplier())
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("INSERT INTO [Assetcontrol].[dbo].[Supplier] " +
                                                                   "([supplierName], [NIT], [Address], [ContactName], [Telephone]) " +
                                                                   "VALUES (@supplierName, @NIT, @Address, @ContactName, @Telephone)", connection))
                        {
                            // Configurar parámetros
                            command.Parameters.AddWithValue("@supplierName", textBox1.Text);
                            command.Parameters.AddWithValue("@NIT", textBox2.Text);
                            command.Parameters.AddWithValue("@Address", textBox3.Text);
                            command.Parameters.AddWithValue("@ContactName", textBox4.Text);
                            command.Parameters.AddWithValue("@Telephone", textBox5.Text);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Registro guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool TodosLosCamposEstanLlenosSupplier()
        {
            return !string.IsNullOrWhiteSpace(textBox1.Text) &&
                   !string.IsNullOrWhiteSpace(textBox2.Text) &&
                   !string.IsNullOrWhiteSpace(textBox3.Text) &&
                   !string.IsNullOrWhiteSpace(textBox4.Text) &&
                   !string.IsNullOrWhiteSpace(textBox5.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(TodosLosCamposEstanLlenosProjects())
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("INSERT INTO [Assetcontrol].[dbo].[Projects] " +
                                                                    "([projectNumber], [Comment], [area])" +
                                                                    "VALUES (@projectNumber, @Comment, @area)", connection))
                        {
                            command.Parameters.AddWithValue("@projectNumber", textBox6.Text);
                            command.Parameters.AddWithValue("@Comment", textBox7.Text);
                            command.Parameters.AddWithValue("@area", textBox8.Text);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Registro de Proyecto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show($"Error al intentar guardar la informacion del proyecto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private bool TodosLosCamposEstanLlenosProjects()
        {
            return !string.IsNullOrWhiteSpace(textBox6.Text) &&
                   !string.IsNullOrWhiteSpace(textBox7.Text) &&
                   !string.IsNullOrWhiteSpace(textBox8.Text);
        }
    }
}
