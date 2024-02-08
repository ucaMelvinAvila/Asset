using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Asset
{
    public partial class frmcontabilidad : Form
    {
        public frmcontabilidad()
        {
            InitializeComponent();
        }

        private void frmcontabilidad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetcontrolDataSet10.Responsible' table. You can move, or remove it, as needed.
            this.responsibleTableAdapter.Fill(this.assetcontrolDataSet10.Responsible);
            // TODO: This line of code loads data into the 'assetcontrolDataSet9.AccountingV' table. You can move, or remove it, as needed.
            this.accountingVTableAdapter1.Fill(this.assetcontrolDataSet9.AccountingV);
            // TODO: This line of code loads data into the 'assetcontrolDataSet8.AccountingV' table. You can move, or remove it, as needed.
            //this.accountingVTableAdapter.Fill(this.assetcontrolDataSet8.AccountingV);
            // TODO: This line of code loads data into the 'assetcontrolDataSet4.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.assetcontrolDataSet4.Department);
            // TODO: This line of code loads data into the 'assetcontrolDataSet3.DepreciationExpenseGLAcct' table. You can move, or remove it, as needed.
            this.depreciationExpenseGLAcctTableAdapter.Fill(this.assetcontrolDataSet3.DepreciationExpenseGLAcct);
            // TODO: This line of code loads data into the 'assetcontrolDataSet2.AccumulatedDepreciationGLAcct' table. You can move, or remove it, as needed.
            this.accumulatedDepreciationGLAcctTableAdapter.Fill(this.assetcontrolDataSet2.AccumulatedDepreciationGLAcct);
            // TODO: This line of code loads data into the 'assetcontrolDataSet1.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.assetcontrolDataSet1.Projects);
            // TODO: This line of code loads data into the 'assetcontrolDataSet.AssetCostGLACCT' table. You can move, or remove it, as needed.
            this.assetCostGLACCTTableAdapter.Fill(this.assetcontrolDataSet.AssetCostGLACCT);


        }


        private string ConnectionString = "Data Source=UCAWVMW\\ASSET;Initial Catalog=Assetcontrol;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
                try
                {
                    if (TodosLosCamposEstanLlenos())
                    {

                        using (SqlConnection connection = new SqlConnection(ConnectionString))
                        {
                            connection.Open();

                            using (SqlCommand command = new SqlCommand("INSERT INTO Accounting (IdAssetCostGLACCT, IdProject, IdAccumlatedDepGLA, IdDeprecationExpenseGL, IdDepartment, CategoryType, AssetID, AssetType, Brand, ModelNumber, TagNumber, NewTagNumber, SerialNumber, IdAssetResponsible, InvoiceNumber, DateAcquired, PlacedinService, Life, Cost, DepreciableBasis, Comments, Status) VALUES (@IdAssetCostGLACCT, @IdProject, @IdAccumlatedDepGLA, @IdDeprecationExpenseGL, @IdDepartment, @CategoryType, @AssetID, @AssetType, @Brand, @ModelNumber, @TagNumber, @NewTagNumber, @SerialNumber, @IdAssetResponsible, @InvoiceNumber, @DateAcquired, @PlacedinService, @Life, @Cost, @DepreciableBasis, @Comments, @status)", connection))
                            {
                                // Configurar parámetros
                                command.Parameters.AddWithValue("@IdAssetCostGLACCT", comboBox1.SelectedValue);
                                command.Parameters.AddWithValue("@IdProject", comboBox2.SelectedValue);
                                command.Parameters.AddWithValue("@IdAccumlatedDepGLA", comboBox3.SelectedValue);
                                command.Parameters.AddWithValue("@IdDeprecationExpenseGL", comboBox4.SelectedValue);
                                command.Parameters.AddWithValue("@IdDepartment", comboBox5.SelectedValue);
                                command.Parameters.AddWithValue("@CategoryType", textBox1.Text);
                                command.Parameters.AddWithValue("@AssetID", textBox2.Text);
                                command.Parameters.AddWithValue("@AssetType", textBox3.Text);
                                command.Parameters.AddWithValue("@TagNumber", textBox9.Text);
                                command.Parameters.AddWithValue("@NewTagNumber", textBox10.Text);
                                command.Parameters.AddWithValue("@Brand", textBox11.Text);
                                command.Parameters.AddWithValue("@ModelNumber", textBox12.Text);
                                command.Parameters.AddWithValue("@SerialNumber", textBox13.Text);
                                command.Parameters.AddWithValue("@IdAssetResponsible", comboBox6.SelectedValue);
                                command.Parameters.AddWithValue("@InvoiceNumber", textBox14.Text);
                                command.Parameters.AddWithValue("@DateAcquired", dateTimePicker1.Value);
                                command.Parameters.AddWithValue("@PlacedinService", dateTimePicker2.Value);
                                command.Parameters.AddWithValue("@Life", textBox5.Text);
                                command.Parameters.AddWithValue("@Cost", textBox6.Text);
                                command.Parameters.AddWithValue("@depreciableBasis", textBox7.Text);
                                command.Parameters.AddWithValue("@Comments", textBox4.Text);
                                //parámetro que activa o inactiva un registro de un activo fijo.
                                command.Parameters.AddWithValue("@status", checkBox1.Checked ? 1 : 0);
                                // Ejecutar la consulta
                                command.ExecuteNonQuery();
                                this.accountingVTableAdapter1.Fill(this.assetcontrolDataSet9.AccountingV);
                            }

                            MessageBox.Show("Registro guardado correctamente.");
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

        private void button4_Click(object sender, EventArgs e)
        {
            frmprintlabels frmprintlabels = new frmprintlabels(); // Crear una instancia del formulario frmcompras
            frmprintlabels.ShowDialog(); // Mostrar el formulario frmcompras
        }

        private bool TodosLosCamposEstanLlenos()
        {
            // Verificar cada campo y devolver false si alguno está vacío
            return !string.IsNullOrWhiteSpace(textBox1.Text) &&
                   !string.IsNullOrWhiteSpace(textBox2.Text) &&
                   !string.IsNullOrWhiteSpace(textBox3.Text) &&
                   !string.IsNullOrWhiteSpace(textBox9.Text) &&
                   !string.IsNullOrWhiteSpace(textBox10.Text) &&
                   !string.IsNullOrWhiteSpace(textBox11.Text) &&
                   !string.IsNullOrWhiteSpace(textBox12.Text) &&
                   !string.IsNullOrWhiteSpace(textBox13.Text) &&
                   !string.IsNullOrWhiteSpace(textBox14.Text) &&
                   true; // Devolver true si todos los campos están llenos
        }
    }
}
