namespace Magazyn2
{
    partial class UsuńKlienta
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bazaMagazynDataSet = new Magazyn2.BazaMagazynDataSet();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klienciTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.KlienciTableAdapter();
            this.idKlientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUsuń = new System.Windows.Forms.Button();
            this.bWyjdz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKlientaDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.nIPDataGridViewTextBoxColumn,
            this.rEGONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klienciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(118, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 364);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // bazaMagazynDataSet
            // 
            this.bazaMagazynDataSet.DataSetName = "BazaMagazynDataSet";
            this.bazaMagazynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataMember = "Klienci";
            this.klienciBindingSource.DataSource = this.bazaMagazynDataSet;
            // 
            // klienciTableAdapter
            // 
            this.klienciTableAdapter.ClearBeforeFill = true;
            // 
            // idKlientaDataGridViewTextBoxColumn
            // 
            this.idKlientaDataGridViewTextBoxColumn.DataPropertyName = "Id_Klienta";
            this.idKlientaDataGridViewTextBoxColumn.HeaderText = "Id_Klienta";
            this.idKlientaDataGridViewTextBoxColumn.Name = "idKlientaDataGridViewTextBoxColumn";
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            // 
            // rEGONDataGridViewTextBoxColumn
            // 
            this.rEGONDataGridViewTextBoxColumn.DataPropertyName = "REGON";
            this.rEGONDataGridViewTextBoxColumn.HeaderText = "REGON";
            this.rEGONDataGridViewTextBoxColumn.Name = "rEGONDataGridViewTextBoxColumn";
            // 
            // bUsuń
            // 
            this.bUsuń.Location = new System.Drawing.Point(13, 76);
            this.bUsuń.Name = "bUsuń";
            this.bUsuń.Size = new System.Drawing.Size(75, 23);
            this.bUsuń.TabIndex = 1;
            this.bUsuń.Text = "Usuń";
            this.bUsuń.UseVisualStyleBackColor = true;
            this.bUsuń.Click += new System.EventHandler(this.bUsuń_Click);
            // 
            // bWyjdz
            // 
            this.bWyjdz.Location = new System.Drawing.Point(13, 119);
            this.bWyjdz.Name = "bWyjdz";
            this.bWyjdz.Size = new System.Drawing.Size(75, 23);
            this.bWyjdz.TabIndex = 2;
            this.bWyjdz.Text = "Wyjdź";
            this.bWyjdz.UseVisualStyleBackColor = true;
            this.bWyjdz.Click += new System.EventHandler(this.bWyjdz_Click);
            // 
            // UsuńKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 409);
            this.Controls.Add(this.bWyjdz);
            this.Controls.Add(this.bUsuń);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UsuńKlienta";
            this.Text = "UsuńKlienta";
            this.Load += new System.EventHandler(this.UsuńKlienta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BazaMagazynDataSet bazaMagazynDataSet;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private BazaMagazynDataSetTableAdapters.KlienciTableAdapter klienciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKlientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGONDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bUsuń;
        private System.Windows.Forms.Button bWyjdz;
    }
}