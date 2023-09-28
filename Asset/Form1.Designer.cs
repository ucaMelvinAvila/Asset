
namespace Asset
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnimportexport = new System.Windows.Forms.Button();
            this.btncontabilidad = new System.Windows.Forms.Button();
            this.btncompras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnimportexport);
            this.splitContainer1.Panel1.Controls.Add(this.btncontabilidad);
            this.splitContainer1.Panel1.Controls.Add(this.btncompras);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(2606, 1062);
            this.splitContainer1.SplitterDistance = 359;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnimportexport
            // 
            this.btnimportexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimportexport.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnimportexport.Image = ((System.Drawing.Image)(resources.GetObject("btnimportexport.Image")));
            this.btnimportexport.Location = new System.Drawing.Point(309, 9);
            this.btnimportexport.Name = "btnimportexport";
            this.btnimportexport.Size = new System.Drawing.Size(292, 344);
            this.btnimportexport.TabIndex = 2;
            this.btnimportexport.Text = "ImportExport";
            this.btnimportexport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnimportexport.UseVisualStyleBackColor = true;
            // 
            // btncontabilidad
            // 
            this.btncontabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontabilidad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btncontabilidad.Image = ((System.Drawing.Image)(resources.GetObject("btncontabilidad.Image")));
            this.btncontabilidad.Location = new System.Drawing.Point(610, 9);
            this.btncontabilidad.Margin = new System.Windows.Forms.Padding(6);
            this.btncontabilidad.Name = "btncontabilidad";
            this.btncontabilidad.Size = new System.Drawing.Size(288, 344);
            this.btncontabilidad.TabIndex = 1;
            this.btncontabilidad.Text = "Contabilidad";
            this.btncontabilidad.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncontabilidad.UseVisualStyleBackColor = true;
            this.btncontabilidad.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncompras
            // 
            this.btncompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompras.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btncompras.Image = ((System.Drawing.Image)(resources.GetObject("btncompras.Image")));
            this.btncompras.Location = new System.Drawing.Point(24, 6);
            this.btncompras.Margin = new System.Windows.Forms.Padding(6);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(276, 344);
            this.btncompras.TabIndex = 0;
            this.btncompras.Text = "Compras";
            this.btncompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncompras.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2606, 1062);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.Button btncontabilidad;
        private System.Windows.Forms.Button btnimportexport;
    }
}

