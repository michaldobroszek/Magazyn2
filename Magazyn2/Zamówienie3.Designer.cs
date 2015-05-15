namespace Magazyn2
{
    partial class Zamówienie3
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
            this.produktyZamówieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaMagazynDataSet = new Magazyn2.BazaMagazynDataSet();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produkty_ZamówieniaTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.Produkty_ZamówieniaTableAdapter();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktyTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.ProduktyTableAdapter();
            this.klienciTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.KlienciTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewKlient = new System.Windows.Forms.DataGridView();
            this.klienciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idKlientaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEGONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewZamowioneProdukty = new System.Windows.Forms.DataGridView();
            this.bZamow = new System.Windows.Forms.Button();
            this.bCofnij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produktyZamówieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZamowioneProdukty)).BeginInit();
            this.SuspendLayout();
            // 
            // produktyZamówieniaBindingSource
            // 
            this.produktyZamówieniaBindingSource.DataMember = "Produkty_Zamówienia";
            this.produktyZamówieniaBindingSource.DataSource = this.bazaMagazynDataSet;
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
            // produkty_ZamówieniaTableAdapter
            // 
            this.produkty_ZamówieniaTableAdapter.ClearBeforeFill = true;
            // 
            // produktyBindingSource
            // 
            this.produktyBindingSource.DataMember = "Produkty";
            this.produktyBindingSource.DataSource = this.bazaMagazynDataSet;
            // 
            // produktyTableAdapter
            // 
            this.produktyTableAdapter.ClearBeforeFill = true;
            // 
            // klienciTableAdapter
            // 
            this.klienciTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "PODSUMOWAIE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewKlient
            // 
            this.dataGridViewKlient.AutoGenerateColumns = false;
            this.dataGridViewKlient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idKlientaDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.nIPDataGridViewTextBoxColumn,
            this.rEGONDataGridViewTextBoxColumn});
            this.dataGridViewKlient.DataSource = this.klienciBindingSource1;
            this.dataGridViewKlient.Location = new System.Drawing.Point(21, 76);
            this.dataGridViewKlient.Name = "dataGridViewKlient";
            this.dataGridViewKlient.Size = new System.Drawing.Size(445, 150);
            this.dataGridViewKlient.TabIndex = 1;
            // 
            // klienciBindingSource1
            // 
            this.klienciBindingSource1.DataMember = "Klienci";
            this.klienciBindingSource1.DataSource = this.bazaMagazynDataSet;
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
            // dataGridViewZamowioneProdukty
            // 
            this.dataGridViewZamowioneProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZamowioneProdukty.Location = new System.Drawing.Point(21, 250);
            this.dataGridViewZamowioneProdukty.Name = "dataGridViewZamowioneProdukty";
            this.dataGridViewZamowioneProdukty.Size = new System.Drawing.Size(547, 150);
            this.dataGridViewZamowioneProdukty.TabIndex = 2;
            // 
            // bZamow
            // 
            this.bZamow.Location = new System.Drawing.Point(100, 407);
            this.bZamow.Name = "bZamow";
            this.bZamow.Size = new System.Drawing.Size(75, 23);
            this.bZamow.TabIndex = 3;
            this.bZamow.Text = "Zamów";
            this.bZamow.UseVisualStyleBackColor = true;
            this.bZamow.Click += new System.EventHandler(this.bZamow_Click);
            // 
            // bCofnij
            // 
            this.bCofnij.Location = new System.Drawing.Point(243, 407);
            this.bCofnij.Name = "bCofnij";
            this.bCofnij.Size = new System.Drawing.Size(75, 23);
            this.bCofnij.TabIndex = 4;
            this.bCofnij.Text = "Cofnij";
            this.bCofnij.UseVisualStyleBackColor = true;
            this.bCofnij.Click += new System.EventHandler(this.bCofnij_Click);
            // 
            // Zamówienie3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 458);
            this.Controls.Add(this.bCofnij);
            this.Controls.Add(this.bZamow);
            this.Controls.Add(this.dataGridViewZamowioneProdukty);
            this.Controls.Add(this.dataGridViewKlient);
            this.Controls.Add(this.label1);
            this.Name = "Zamówienie3";
            this.Text = "Zamówienie3";
            this.Load += new System.EventHandler(this.Zamówienie3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produktyZamówieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZamowioneProdukty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BazaMagazynDataSet bazaMagazynDataSet;
        private System.Windows.Forms.BindingSource produktyZamówieniaBindingSource;
        private BazaMagazynDataSetTableAdapters.Produkty_ZamówieniaTableAdapter produkty_ZamówieniaTableAdapter;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private BazaMagazynDataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private BazaMagazynDataSetTableAdapters.KlienciTableAdapter klienciTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewKlient;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKlientaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEGONDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource klienciBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewZamowioneProdukty;
        private System.Windows.Forms.Button bZamow;
        private System.Windows.Forms.Button bCofnij;

    }
}