namespace Asset
{
    partial class frmimportexport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmimportexport));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label28 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.htsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hTSdataset = new Asset.HTSdataset();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.uOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetcontrolDataSet11 = new Asset.AssetcontrolDataSet11();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.htsTableAdapter = new Asset.HTSdatasetTableAdapters.htsTableAdapter();
            this.uOMTableAdapter = new Asset.AssetcontrolDataSet11TableAdapters.UOMTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.assetcontrolDataSet12 = new Asset.AssetcontrolDataSet12();
            this.importExportvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.importExport_vTableAdapter = new Asset.AssetcontrolDataSet12TableAdapters.ImportExport_vTableAdapter();
            this.goodsDeclarationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDeclarationReferenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDeclarationSelectivityDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffItemNumberHTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameImportExportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsDeclarationAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newTagNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.htsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTSdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetcontrolDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetcontrolDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.importExportvBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(285, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero DM:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(805, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(277, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label28.Location = new System.Drawing.Point(634, 28);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(169, 20);
            this.label28.TabIndex = 23;
            this.label28.Text = "Fecha de Selectividad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero de Referencia:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(285, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 26);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "HTS:";
            // 
            // comboBox5
            // 
            this.comboBox5.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.htsBindingSource, "HTS", true));
            this.comboBox5.DataSource = this.htsBindingSource;
            this.comboBox5.DisplayMember = "HTS";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(285, 88);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(266, 21);
            this.comboBox5.TabIndex = 3;
            this.comboBox5.ValueMember = "HTS";
            // 
            // htsBindingSource
            // 
            this.htsBindingSource.DataMember = "hts";
            this.htsBindingSource.DataSource = this.hTSdataset;
            // 
            // hTSdataset
            // 
            this.hTSdataset.DataSetName = "HTSdataset";
            this.hTSdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre Proveedor Import Export:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(285, 173);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(403, 26);
            this.textBox3.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero de Tag:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(285, 257);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(185, 26);
            this.textBox4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(693, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 66);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Monto De la Declaracion $:";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(285, 219);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(185, 26);
            this.textBox5.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Unidad de Medida:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uOMBindingSource, "UOM", true));
            this.comboBox1.DataSource = this.uOMBindingSource;
            this.comboBox1.DisplayMember = "UOM";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(285, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(266, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "UOM";
            // 
            // uOMBindingSource
            // 
            this.uOMBindingSource.DataMember = "UOM";
            this.uOMBindingSource.DataSource = this.assetcontrolDataSet11;
            // 
            // assetcontrolDataSet11
            // 
            this.assetcontrolDataSet11.DataSetName = "AssetcontrolDataSet11";
            this.assetcontrolDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(634, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Comentario:";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(805, 85);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(567, 79);
            this.textBox7.TabIndex = 9;
            // 
            // htsTableAdapter
            // 
            this.htsTableAdapter.ClearBeforeFill = true;
            // 
            // uOMTableAdapter
            // 
            this.uOMTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsDeclarationNumberDataGridViewTextBoxColumn,
            this.goodsDeclarationReferenceDataGridViewTextBoxColumn,
            this.goodsDeclarationSelectivityDateDataGridViewTextBoxColumn,
            this.tariffItemNumberHTSDataGridViewTextBoxColumn,
            this.supplierNameImportExportDataGridViewTextBoxColumn,
            this.goodsDeclarationAmountDataGridViewTextBoxColumn,
            this.newTagNumberDataGridViewTextBoxColumn,
            this.invoiceNumberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.importExportvBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 344);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1346, 342);
            this.dataGridView1.TabIndex = 24;
            // 
            // assetcontrolDataSet12
            // 
            this.assetcontrolDataSet12.DataSetName = "AssetcontrolDataSet12";
            this.assetcontrolDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // importExportvBindingSource
            // 
            this.importExportvBindingSource.DataMember = "ImportExport_v";
            this.importExportvBindingSource.DataSource = this.assetcontrolDataSet12;
            // 
            // importExport_vTableAdapter
            // 
            this.importExport_vTableAdapter.ClearBeforeFill = true;
            // 
            // goodsDeclarationNumberDataGridViewTextBoxColumn
            // 
            this.goodsDeclarationNumberDataGridViewTextBoxColumn.DataPropertyName = "GoodsDeclarationNumber";
            this.goodsDeclarationNumberDataGridViewTextBoxColumn.HeaderText = "GoodsDeclarationNumber";
            this.goodsDeclarationNumberDataGridViewTextBoxColumn.Name = "goodsDeclarationNumberDataGridViewTextBoxColumn";
            this.goodsDeclarationNumberDataGridViewTextBoxColumn.Width = 154;
            // 
            // goodsDeclarationReferenceDataGridViewTextBoxColumn
            // 
            this.goodsDeclarationReferenceDataGridViewTextBoxColumn.DataPropertyName = "GoodsDeclarationReference";
            this.goodsDeclarationReferenceDataGridViewTextBoxColumn.HeaderText = "GoodsDeclarationReference";
            this.goodsDeclarationReferenceDataGridViewTextBoxColumn.Name = "goodsDeclarationReferenceDataGridViewTextBoxColumn";
            this.goodsDeclarationReferenceDataGridViewTextBoxColumn.Width = 167;
            // 
            // goodsDeclarationSelectivityDateDataGridViewTextBoxColumn
            // 
            this.goodsDeclarationSelectivityDateDataGridViewTextBoxColumn.DataPropertyName = "GoodsDeclarationSelectivityDate";
            this.goodsDeclarationSelectivityDateDataGridViewTextBoxColumn.HeaderText = "GoodsDeclarationSelectivityDate";
            this.goodsDeclarationSelectivityDateDataGridViewTextBoxColumn.Name = "goodsDeclarationSelectivityDateDataGridViewTextBoxColumn";
            this.goodsDeclarationSelectivityDateDataGridViewTextBoxColumn.Width = 188;
            // 
            // tariffItemNumberHTSDataGridViewTextBoxColumn
            // 
            this.tariffItemNumberHTSDataGridViewTextBoxColumn.DataPropertyName = "TariffItemNumberHTS";
            this.tariffItemNumberHTSDataGridViewTextBoxColumn.HeaderText = "TariffItemNumberHTS";
            this.tariffItemNumberHTSDataGridViewTextBoxColumn.Name = "tariffItemNumberHTSDataGridViewTextBoxColumn";
            this.tariffItemNumberHTSDataGridViewTextBoxColumn.Width = 135;
            // 
            // supplierNameImportExportDataGridViewTextBoxColumn
            // 
            this.supplierNameImportExportDataGridViewTextBoxColumn.DataPropertyName = "SupplierNameImportExport";
            this.supplierNameImportExportDataGridViewTextBoxColumn.HeaderText = "SupplierNameImportExport";
            this.supplierNameImportExportDataGridViewTextBoxColumn.Name = "supplierNameImportExportDataGridViewTextBoxColumn";
            this.supplierNameImportExportDataGridViewTextBoxColumn.Width = 157;
            // 
            // goodsDeclarationAmountDataGridViewTextBoxColumn
            // 
            this.goodsDeclarationAmountDataGridViewTextBoxColumn.DataPropertyName = "GoodsDeclarationAmount";
            this.goodsDeclarationAmountDataGridViewTextBoxColumn.HeaderText = "GoodsDeclarationAmount";
            this.goodsDeclarationAmountDataGridViewTextBoxColumn.Name = "goodsDeclarationAmountDataGridViewTextBoxColumn";
            this.goodsDeclarationAmountDataGridViewTextBoxColumn.Width = 153;
            // 
            // newTagNumberDataGridViewTextBoxColumn
            // 
            this.newTagNumberDataGridViewTextBoxColumn.DataPropertyName = "NewTagNumber";
            this.newTagNumberDataGridViewTextBoxColumn.HeaderText = "NewTagNumber";
            this.newTagNumberDataGridViewTextBoxColumn.Name = "newTagNumberDataGridViewTextBoxColumn";
            this.newTagNumberDataGridViewTextBoxColumn.Width = 110;
            // 
            // invoiceNumberDataGridViewTextBoxColumn
            // 
            this.invoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn.HeaderText = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn.Name = "invoiceNumberDataGridViewTextBoxColumn";
            this.invoiceNumberDataGridViewTextBoxColumn.Width = 104;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 85;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 76;
            // 
            // frmimportexport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 713);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmimportexport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Export";
            this.Load += new System.EventHandler(this.frmimportexport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.htsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTSdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetcontrolDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetcontrolDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.importExportvBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private HTSdataset hTSdataset;
        private System.Windows.Forms.BindingSource htsBindingSource;
        private HTSdatasetTableAdapters.htsTableAdapter htsTableAdapter;
        private AssetcontrolDataSet11 assetcontrolDataSet11;
        private System.Windows.Forms.BindingSource uOMBindingSource;
        private AssetcontrolDataSet11TableAdapters.UOMTableAdapter uOMTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AssetcontrolDataSet12 assetcontrolDataSet12;
        private System.Windows.Forms.BindingSource importExportvBindingSource;
        private AssetcontrolDataSet12TableAdapters.ImportExport_vTableAdapter importExport_vTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDeclarationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDeclarationReferenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDeclarationSelectivityDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffItemNumberHTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameImportExportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsDeclarationAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newTagNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}