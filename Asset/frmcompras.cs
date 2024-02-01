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
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}");
            }

        }

    }
}
