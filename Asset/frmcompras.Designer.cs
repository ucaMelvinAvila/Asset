
using System;
using System.Windows.Forms;

namespace Asset
{
    partial class frmcompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcompras));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txttagnumber = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.AccountingTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasingVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assetcontrolDataSet7 = new Asset.AssetcontrolDataSet7();
            this.purchasingVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetcontrolDataSet6 = new Asset.AssetcontrolDataSet6();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbproveedor = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetcontrolDataSet5 = new Asset.AssetcontrolDataSet5();
            this.label25 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.purchasing_VTableAdapter = new Asset.AssetcontrolDataSet6TableAdapters.Purchasing_VTableAdapter();
            this.supplierTableAdapter = new Asset.AssetcontrolDataSet5TableAdapters.SupplierTableAdapter();
            this.purchasingVTableAdapter = new Asset.AssetcontrolDataSet7TableAdapters.PurchasingVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasingVBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetcontrolDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasingVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetcontrolDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetcontrolDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Orden de Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion del Articulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del Proveedor";
            // 
            // txtpo
            // 
            this.txtpo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpo.Location = new System.Drawing.Point(211, 27);
            this.txtpo.Name = "txtpo";
            this.txtpo.Size = new System.Drawing.Size(231, 22);
            this.txtpo.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(284, 73);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(771, 0);
            this.textBox2.TabIndex = 4;
            // 
            // txttagnumber
            // 
            this.txttagnumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txttagnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttagnumber.Location = new System.Drawing.Point(211, 151);
            this.txttagnumber.Name = "txttagnumber";
            this.txttagnumber.Size = new System.Drawing.Size(446, 22);
            this.txttagnumber.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountingTag,
            this.purchaseOrderDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.TotalCost});
            this.dataGridView2.DataSource = this.purchasingVBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(33, 246);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.Size = new System.Drawing.Size(1228, 320);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // AccountingTag
            // 
            this.AccountingTag.DataPropertyName = "AccountingTag";
            this.AccountingTag.HeaderText = "AccountingTag";
            this.AccountingTag.Name = "AccountingTag";
            // 
            // purchaseOrderDataGridViewTextBoxColumn
            // 
            this.purchaseOrderDataGridViewTextBoxColumn.DataPropertyName = "PurchaseOrder";
            this.purchaseOrderDataGridViewTextBoxColumn.HeaderText = "PurchaseOrder";
            this.purchaseOrderDataGridViewTextBoxColumn.Name = "purchaseOrderDataGridViewTextBoxColumn";
            this.purchaseOrderDataGridViewTextBoxColumn.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "supplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "supplierName";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            // 
            // TotalCost
            // 
            this.TotalCost.DataPropertyName = "TotalCost";
            this.TotalCost.HeaderText = "TotalCost";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            // 
            // purchasingVBindingSource1
            // 
            this.purchasingVBindingSource1.DataMember = "PurchasingV";
            this.purchasingVBindingSource1.DataSource = this.assetcontrolDataSet7;
            // 
            // assetcontrolDataSet7
            // 
            this.assetcontrolDataSet7.DataSetName = "AssetcontrolDataSet7";
            this.assetcontrolDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // purchasingVBindingSource
            // 
            this.purchasingVBindingSource.DataMember = "Purchasing_V";
            this.purchasingVBindingSource.DataSource = this.assetcontrolDataSet6;
            // 
            // assetcontrolDataSet6
            // 
            this.assetcontrolDataSet6.DataSetName = "AssetcontrolDataSet6";
            this.assetcontrolDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(699, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 69);
            this.button2.TabIndex = 8;
            this.button2.Text = "Guardar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cmbproveedor
            // 
            this.cmbproveedor.DataSource = this.supplierBindingSource;
            this.cmbproveedor.DisplayMember = "supplierName";
            this.cmbproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbproveedor.FormattingEnabled = true;
            this.cmbproveedor.Location = new System.Drawing.Point(211, 183);
            this.cmbproveedor.Name = "cmbproveedor";
            this.cmbproveedor.Size = new System.Drawing.Size(388, 24);
            this.cmbproveedor.TabIndex = 9;
            this.cmbproveedor.ValueMember = "Id_Supplier";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.assetcontrolDataSet5;
            // 
            // assetcontrolDataSet5
            // 
            this.assetcontrolDataSet5.DataSetName = "AssetcontrolDataSet5";
            this.assetcontrolDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(29, 151);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(121, 16);
            this.label25.TabIndex = 19;
            this.label25.Text = "Asset ID (TAG No.)";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(211, 64);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(352, 74);
            this.txtdescripcion.TabIndex = 3;
            // 
            // purchasing_VTableAdapter
            // 
            this.purchasing_VTableAdapter.ClearBeforeFill = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // purchasingVTableAdapter
            // 
            this.purchasingVTableAdapter.ClearBeforeFill = true;
            // 
            // frmcompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 590);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.cmbproveedor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txttagnumber);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtpo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Captura de Datos de Compras";
            this.Load += new System.EventHandler(this.frmcompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasingVBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetcontrolDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasingVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetcontrolDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetcontrolDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void frmcompras_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //calling suplier name to purchasing form
            this.supplierTableAdapter.Fill(this.assetcontrolDataSet5.Supplier);
            //
                 
            this.purchasingVTableAdapter.Fill(this.assetcontrolDataSet7.PurchasingV);
            dataGridView2.DataSource = purchasingVBindingSource1;
        }

     
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txttagnumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbproveedor;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtdescripcion;
        private AssetcontrolDataSet6 assetcontrolDataSet6;
        private System.Windows.Forms.BindingSource purchasingVBindingSource;
        private AssetcontrolDataSet6TableAdapters.Purchasing_VTableAdapter purchasing_VTableAdapter;
        private AssetcontrolDataSet5 assetcontrolDataSet5;
        private BindingSource supplierBindingSource;
        private AssetcontrolDataSet5TableAdapters.SupplierTableAdapter supplierTableAdapter;
        private DataGridView dataGridView2;
        private AssetcontrolDataSet7 assetcontrolDataSet7;
        private BindingSource purchasingVBindingSource1;
        private AssetcontrolDataSet7TableAdapters.PurchasingVTableAdapter purchasingVTableAdapter;
        private DataGridViewTextBoxColumn AccountingTag;
        private DataGridViewTextBoxColumn purchaseOrderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TotalCost;
    }
}

