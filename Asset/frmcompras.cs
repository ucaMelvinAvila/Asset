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

namespace Asset
{
    public partial class frmcompras : Form
    {
        public frmcompras()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        

        private void frmcompras_Load(object sender, EventArgs e)
        {
            using (Assetcontrol db = new Assetcontrol())
            {
                var lst = from d in db.Purchasings
                          select d;
                dataGridView2.DataSource = lst.ToList();

            }
            
            
        }

        public void ClearData()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = String.Empty;
        }

        //private void Refresh()
        //{
        //    using (Models.Assetcontrol db = new Models.Assetcontrol())
        //    {
        //        dataGridView1.DataSource = db.Purchasings.ToList();
        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            string PO = textBox1.Text.Trim();
            string descripcion = textBox2.Text.Trim();
            string NProveedor = textBox3.Text.Trim();

            dataGridView1.Rows.Add(new object[] { PO, descripcion, NProveedor });

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    using (Models.Assetcontrol db=new Models.Assetcontrol())
        //    {
        //        using(var dbContextAsset = db.Database.BeginTransaction())
        //        {
        //            try
        //            {
        //                Models.Purchasing po = new Models.Purchasing();
                        

        //                dbContextAsset.Commit();
        //            }
        //            catch(Exception ex)
        //            {
        //                dbContextAsset.Rollback();
        //            }
        //        }
        //    }
        //}
    }
}
