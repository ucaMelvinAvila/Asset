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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
            CargarDatosEnChart();
        }

        private const string ConnectionString = "Data Source=UCAWVMW\\ASSET;Initial Catalog=Assetcontrol;Integrated Security=true;";

        private void CargarDatosEnChart()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Reemplaza "MainChart1" con el nombre real de tu vista
                    using (SqlCommand command = new SqlCommand("SELECT * FROM MainChart1", connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Asigna los datos al DataSource del Chart
                        chart1.DataSource = dataTable;

                        // Especifica los campos que se utilizarán para los ejes X y Y
                        chart1.Series[0].XValueMember = "Responsible";
                        chart1.Series[0].YValueMembers = "Total Cost $";

                        // Actualiza el gráfico
                        chart1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos en el Chart: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btncompras_Click(object sender, EventArgs e)
        {
            frmcompras frmCompras = new frmcompras(); // Crear una instancia del formulario frmcompras
            frmCompras.ShowDialog(); // Mostrar el formulario frmcompras
        }

        private void btncontabilidad_Click(object sender, EventArgs e)
        {
            frmcontabilidad frmcontabilidad = new frmcontabilidad();
            frmcontabilidad.ShowDialog();
        }

        private void btnimportexport_Click(object sender, EventArgs e)
        {
            frmimportexport frmimportexport = new frmimportexport();
            frmimportexport.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mantenimientoCatalago mantenimientoCatalago = new mantenimientoCatalago();
            mantenimientoCatalago.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
        }
    }
}
