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
            this.klienciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewZamowioneProdukty = new System.Windows.Forms.DataGridView();
            this.bZamow = new System.Windows.Forms.Button();
            this.bCofnij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.produktyZamówieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
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
            // klienciBindingSource1
            // 
            this.klienciBindingSource1.DataMember = "Klienci";
            this.klienciBindingSource1.DataSource = this.bazaMagazynDataSet;
            // 
            // dataGridViewZamowioneProdukty
            // 
            this.dataGridViewZamowioneProdukty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewZamowioneProdukty.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewZamowioneProdukty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewZamowioneProdukty.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewZamowioneProdukty.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewZamowioneProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZamowioneProdukty.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewZamowioneProdukty.EnableHeadersVisualStyles = false;
            this.dataGridViewZamowioneProdukty.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewZamowioneProdukty.Name = "dataGridViewZamowioneProdukty";
            this.dataGridViewZamowioneProdukty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewZamowioneProdukty.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewZamowioneProdukty.RowHeadersVisible = false;
            this.dataGridViewZamowioneProdukty.Size = new System.Drawing.Size(613, 464);
            this.dataGridViewZamowioneProdukty.TabIndex = 2;
            // 
            // bZamow
            // 
            this.bZamow.Location = new System.Drawing.Point(12, 479);
            this.bZamow.Name = "bZamow";
            this.bZamow.Size = new System.Drawing.Size(75, 23);
            this.bZamow.TabIndex = 3;
            this.bZamow.Text = "Zamów";
            this.bZamow.UseVisualStyleBackColor = true;
            this.bZamow.Click += new System.EventHandler(this.bZamow_Click);
            // 
            // bCofnij
            // 
            this.bCofnij.Location = new System.Drawing.Point(103, 479);
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
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(613, 514);
            this.Controls.Add(this.bCofnij);
            this.Controls.Add(this.bZamow);
            this.Controls.Add(this.dataGridViewZamowioneProdukty);
            this.Name = "Zamówienie3";
            this.Text = "Zamówienie3";
            this.Load += new System.EventHandler(this.Zamówienie3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produktyZamówieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource klienciBindingSource1;
        private System.Windows.Forms.DataGridView dataGridViewZamowioneProdukty;
        private System.Windows.Forms.Button bZamow;
        private System.Windows.Forms.Button bCofnij;

    }
}