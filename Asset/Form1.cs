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
    public partial class frmimportexport : Form
    {
        private const string ConnectionString = "Data Source=UCAWVMW\\ASSET;Initial Catalog=Assetcontrol;Integrated Security=true;";
        public frmimportexport()
        {
            InitializeComponent();
        }

        private void frmimportexport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetcontrolDataSet12.ImportExport_v' table. You can move, or remove it, as needed.
            this.importExport_vTableAdapter.Fill(this.assetcontrolDataSet12.ImportExport_v);
            // TODO: This line of code loads data into the 'assetcontrolDataSet11.UOM' table. You can move, or remove it, as needed.
            this.uOMTableAdapter.Fill(this.assetcontrolDataSet11.UOM);
            // TODO: This line of code loads data into the 'hTSdataset.hts' table. You can move, or remove it, as needed.
            this.htsTableAdapter.Fill(this.hTSdataset.hts);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TodosLosCamposEstanLlenos())
            {
                // Validar si el NewTagNumber existe en la tabla [Assetcontrol].[dbo].[Accounting]
                if (!ExisteNewTagNumber(textBox5.Text))
                {
                    MessageBox.Show("Debe solicitar a Contabilidad que asigne un Tag para este artículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método sin realizar el insert
                }
                try
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("INSERT INTO [Assetcontrol].[dbo].[ImportExport] " +
                                                                   "(GoodsDeclarationNumber, GoodsDeclarationReference, TariffItemNumberHTS, " +
                                                                   "SupplierNameImportExport, GoodsDeclarationAmount, NewTagNumber, " +
                                                                   "GoodsDeclarationSelectivityDate, Comment) " +
                                                                   "VALUES (@GoodsDeclarationNumber, @GoodsDeclarationReference, @TariffItemNumberHTS, " +
                                                                   "@SupplierNameImportExport, @GoodsDeclarationAmount, @NewTagNumber, " +
                                                                   "@GoodsDeclarationSelectivityDate, @Comment)", connection))
                        {
                            // Configurar parámetros
                            command.Parameters.AddWithValue("@GoodsDeclarationNumber", textBox1.Text);
                            command.Parameters.AddWithValue("@GoodsDeclarationReference", textBox2.Text);
                            command.Parameters.AddWithValue("@TariffItemNumberHTS", comboBox5.Text);
                            command.Parameters.AddWithValue("@SupplierNameImportExport", comboBox1.Text);
                            command.Parameters.AddWithValue("@GoodsDeclarationAmount", textBox3.Text);
                            command.Parameters.AddWithValue("@NewTagNumber", textBox5.Text);
                            command.Parameters.AddWithValue("@GoodsDeclarationSelectivityDate", dateTimePicker1.Value);
                            command.Parameters.AddWithValue("@Comment", textBox7.Text);

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

        private bool TodosLosCamposEstanLlenos()
        {
            return !string.IsNullOrWhiteSpace(textBox1.Text) &&
                   !string.IsNullOrWhiteSpace(textBox2.Text) &&
                   !string.IsNullOrWhiteSpace(comboBox5.Text) &&
                   !string.IsNullOrWhiteSpace(comboBox1.Text) &&
                   !string.IsNullOrWhiteSpace(textBox3.Text) &&
                   !string.IsNullOrWhiteSpace(textBox5.Text) &&
                   dateTimePicker1.Value != DateTime.MinValue &&
                   !string.IsNullOrWhiteSpace(textBox7.Text);
        }
        private bool ExisteNewTagNumber(string newTagNumber)
        {
            // Consultar si el NewTagNumber existe en la tabla [Assetcontrol].[dbo].[Accounting]
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [Assetcontrol].[dbo].[Accounting] WHERE NewTagNumber = @NewTagNumber", connection))
                {
                    command.Parameters.AddWithValue("@NewTagNumber", newTagNumber);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
