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
using Zebra.Sdk.Comm;
using Zebra.Sdk.Printer;

namespace Asset
{
    public partial class frmprintlabels : Form
    {
        private const string ZebraPrinterIpAddress = "10.60.5.47";
        public frmprintlabels()
        {
            InitializeComponent();
        }

        private const string ConnectionString = "Data Source=UCAWVMW\\ASSET;Initial Catalog=Assetcontrol;Integrated Security=true;";

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("ObtenerDatosPorTag", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("@TagNumber", SqlDbType.NVarChar).Value = txtBuscar.Text;

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Llenar los TextBox con los datos obtenidos
                            txtNewTagNumber.Text = reader["NewTagNumber"].ToString();
                            txtAssetID.Text = reader["AssetID"].ToString();
                            txtDescription.Text = reader["Description"].ToString();
                            txtSupplierName.Text = reader["supplierName"].ToString();
                            txtPlacedInService.Text = reader["PlacedinService"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron resultados para el NewTagNumber proporcionado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar datos: {ex.Message}");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Configurar la impresión en la impresora Zebra by Melvin Avila
            try
            {
                Connection thePrinterConn = new TcpConnection(ZebraPrinterIpAddress, TcpConnection.DEFAULT_ZPL_TCP_PORT);
                thePrinterConn.Open();

                ZebraPrinter thePrinter = ZebraPrinterFactory.GetInstance(thePrinterConn);
                thePrinterConn.Write(Encoding.Default.GetBytes("^XA"));
                //thePrinterConn.Write(Encoding.Default.GetBytes($"^FO175,15^A0N,25^FD{txtNewTagNumber.Text}^FS"));
                thePrinterConn.Write(Encoding.Default.GetBytes($"^FO73,15^B3N,N,40,Y,N^FD>{txtNewTagNumber.Text}^FS"));//Codigo de Barras Centrado
                thePrinterConn.Write(Encoding.Default.GetBytes($"^FO520,60^B3N,N,75,Y,N^FD>{txtNewTagNumber.Text}^FS"));//Codigo de Barras en otra label
                thePrinterConn.Write(Encoding.Default.GetBytes($"^FO15,95^A0N,25^FD{txtAssetID.Text}^FS"));
                thePrinterConn.Write(Encoding.Default.GetBytes($"^FO15,125^A0N,25^FD{txtDescription.Text}^FS"));
                thePrinterConn.Write(Encoding.Default.GetBytes($"^FO15,155^A0N,25^FD{txtSupplierName.Text}^FS"));
                thePrinterConn.Write(Encoding.Default.GetBytes($"^FO265,180^A0N,25^FD{txtPlacedInService.Text}^FS^XZ"));
                thePrinterConn.Write(Encoding.Default.GetBytes("^XZ"));
                thePrinterConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al imprimir: {ex.Message}");
            }
        }

        private void txtAssetID_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmprintlabels_Load(object sender, EventArgs e)
        {

        }
    }
 }

