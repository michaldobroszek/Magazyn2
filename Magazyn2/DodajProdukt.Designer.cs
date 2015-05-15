namespace Magazyn2
{
    partial class DodajProdukt
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
            this.produktyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bazaMagazynDataSet = new Magazyn2.BazaMagazynDataSet();
            this.produktyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktyTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.ProduktyTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textNazwa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textIlosc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCenaNetto = new System.Windows.Forms.TextBox();
            this.fKProduktyZamówieniaProduktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produkty_ZamówieniaTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.Produkty_ZamówieniaTableAdapter();
            this.bDodaj = new System.Windows.Forms.Button();
            this.bWyjdz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProduktyZamówieniaProduktyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // produktyBindingSource2
            // 
            this.produktyBindingSource2.DataMember = "Produkty";
            this.produktyBindingSource2.DataSource = this.bazaMagazynDataSet;
            // 
            // bazaMagazynDataSet
            // 
            this.bazaMagazynDataSet.DataSetName = "BazaMagazynDataSet";
            this.bazaMagazynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produktyBindingSource1
            // 
            this.produktyBindingSource1.DataMember = "Produkty";
            this.produktyBindingSource1.DataSource = this.bazaMagazynDataSet;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa";
            // 
            // textNazwa
            // 
            this.textNazwa.Location = new System.Drawing.Point(75, 51);
            this.textNazwa.Name = "textNazwa";
            this.textNazwa.Size = new System.Drawing.Size(139, 20);
            this.textNazwa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ilość";
            // 
            // textIlosc
            // 
            this.textIlosc.Location = new System.Drawing.Point(75, 89);
            this.textIlosc.Name = "textIlosc";
            this.textIlosc.Size = new System.Drawing.Size(139, 20);
            this.textIlosc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cenna Netto";
            // 
            // textCenaNetto
            // 
            this.textCenaNetto.Location = new System.Drawing.Point(75, 130);
            this.textCenaNetto.Name = "textCenaNetto";
            this.textCenaNetto.Size = new System.Drawing.Size(139, 20);
            this.textCenaNetto.TabIndex = 6;
            // 
            // fKProduktyZamówieniaProduktyBindingSource
            // 
            this.fKProduktyZamówieniaProduktyBindingSource.DataMember = "FK_Produkty_Zamówienia_Produkty";
            this.fKProduktyZamówieniaProduktyBindingSource.DataSource = this.produktyBindingSource1;
            // 
            // produkty_ZamówieniaTableAdapter
            // 
            this.produkty_ZamówieniaTableAdapter.ClearBeforeFill = true;
            // 
            // bDodaj
            // 
            this.bDodaj.Location = new System.Drawing.Point(12, 182);
            this.bDodaj.Name = "bDodaj";
            this.bDodaj.Size = new System.Drawing.Size(75, 23);
            this.bDodaj.TabIndex = 7;
            this.bDodaj.Text = "Dodaj";
            this.bDodaj.UseVisualStyleBackColor = true;
            this.bDodaj.Click += new System.EventHandler(this.bDodaj_Click);
            // 
            // bWyjdz
            // 
            this.bWyjdz.Location = new System.Drawing.Point(120, 182);
            this.bWyjdz.Name = "bWyjdz";
            this.bWyjdz.Size = new System.Drawing.Size(75, 23);
            this.bWyjdz.TabIndex = 8;
            this.bWyjdz.Text = "Wyjdz";
            this.bWyjdz.UseVisualStyleBackColor = true;
            this.bWyjdz.Click += new System.EventHandler(this.bWyjdz_Click);
            // 
            // DodajProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 289);
            this.Controls.Add(this.bWyjdz);
            this.Controls.Add(this.bDodaj);
            this.Controls.Add(this.textCenaNetto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textIlosc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNazwa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DodajProdukt";
            this.Text = "DodajProdukt";
            this.Load += new System.EventHandler(this.DodajProdukt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProduktyZamówieniaProduktyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BazaMagazynDataSet bazaMagazynDataSet;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private BazaMagazynDataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.BindingSource produktyBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNazwa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIlosc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCenaNetto;
        private System.Windows.Forms.BindingSource fKProduktyZamówieniaProduktyBindingSource;
        private BazaMagazynDataSetTableAdapters.Produkty_ZamówieniaTableAdapter produkty_ZamówieniaTableAdapter;
        private System.Windows.Forms.BindingSource produktyBindingSource2;
        private System.Windows.Forms.Button bDodaj;
        private System.Windows.Forms.Button bWyjdz;
    }
}