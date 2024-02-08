using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Asset.Models;
using System.Data.SqlClient;

namespace Asset
{
    public partial class frmcompras : Form
    {
        public frmcompras()
        {
            InitializeComponent();
        }
        private string ConnectionString = "Data Source=UCAWVMW\\ASSET;Initial Catalog=Assetcontrol;Integrated Security=True";

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (TodosLosCamposEstanLlenos())
                {
                    // Validar si el NewTagNumber existe en la tabla [Assetcontrol].[dbo].[Accounting]
                    if (!ExisteNewTagNumber(txttagnumber.Text))
                    {
                        MessageBox.Show("Debe solicitar a Contabilidad que asigne un Tag para este artículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Salir del método sin realizar el insert
                    }

                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("INSERT INTO Purchasing (Id_Supplier, PurchaseOrder, Description, NewTagNumber ) VALUES (@Id_Supplier, @PurchaseOrder, @Description, @NewTagNumber)", connection))
                        {
                            // Configurar parámetros
                            command.Parameters.AddWithValue("@Id_Supplier", cmbproveedor.SelectedValue);
                            command.Parameters.AddWithValue("@PurchaseOrder", txtpo.Text);
                            command.Parameters.AddWithValue("@Description", txtdescripcion.Text);
                            command.Parameters.AddWithValue("@NewTagNumber", txttagnumber.Text);
                            command.ExecuteNonQuery();
                            this.purchasingVTableAdapter.Fill(this.assetcontrolDataSet7.PurchasingV);
                        }

                        MessageBox.Show("Registro de compras guardado correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}");
            }

        }

        private bool TodosLosCamposEstanLlenos()
        {
            // Verificar cada campo y devolver false si alguno está vacío
            return !string.IsNullOrWhiteSpace(txtpo.Text) &&
                   !string.IsNullOrWhiteSpace(txtdescripcion.Text) &&
                   !string.IsNullOrWhiteSpace(txttagnumber.Text) &&
                   true; // Devolver true si todos los campos están llenos
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
