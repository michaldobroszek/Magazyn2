namespace Magazyn2
{
    partial class Zamówienie
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
            this.dataGridViewProdukty = new System.Windows.Forms.DataGridView();
            this.idProduktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaNettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaMagazynDataSet = new Magazyn2.BazaMagazynDataSet();
            this.produktyTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.ProduktyTableAdapter();
            this.dataGridViewProduktyZamowienia = new System.Windows.Forms.DataGridView();
            this.produktyZamówieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produkty_ZamówieniaTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.Produkty_ZamówieniaTableAdapter();
            this.zamówieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamówieniaTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.ZamówieniaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.bDodajDoKoszyka = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNazwa = new System.Windows.Forms.TextBox();
            this.textIlosc = new System.Windows.Forms.TextBox();
            this.textCenaNetto = new System.Windows.Forms.TextBox();
            this.bAnuluj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textZamawianaIlosc = new System.Windows.Forms.TextBox();
            this.bWprowadzKlienta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdukty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduktyZamowienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyZamówieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamówieniaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProdukty
            // 
            this.dataGridViewProdukty.AutoGenerateColumns = false;
            this.dataGridViewProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdukty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduktDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.ilośćDataGridViewTextBoxColumn,
            this.cenaNettoDataGridViewTextBoxColumn});
            this.dataGridViewProdukty.DataSource = this.produktyBindingSource;
            this.dataGridViewProdukty.Location = new System.Drawing.Point(273, 23);
            this.dataGridViewProdukty.Name = "dataGridViewProdukty";
            this.dataGridViewProdukty.Size = new System.Drawing.Size(318, 231);
            this.dataGridViewProdukty.TabIndex = 0;
            this.dataGridViewProdukty.SelectionChanged += new System.EventHandler(this.dataGridViewProdukty_SelectionChanged);
            // 
            // idProduktDataGridViewTextBoxColumn
            // 
            this.idProduktDataGridViewTextBoxColumn.DataPropertyName = "Id_Produkt";
            this.idProduktDataGridViewTextBoxColumn.HeaderText = "Id_Produkt";
            this.idProduktDataGridViewTextBoxColumn.Name = "idProduktDataGridViewTextBoxColumn";
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // ilośćDataGridViewTextBoxColumn
            // 
            this.ilośćDataGridViewTextBoxColumn.DataPropertyName = "Ilość";
            this.ilośćDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.ilośćDataGridViewTextBoxColumn.Name = "ilośćDataGridViewTextBoxColumn";
            // 
            // cenaNettoDataGridViewTextBoxColumn
            // 
            this.cenaNettoDataGridViewTextBoxColumn.DataPropertyName = "Cena_Netto";
            this.cenaNettoDataGridViewTextBoxColumn.HeaderText = "Cena_Netto";
            this.cenaNettoDataGridViewTextBoxColumn.Name = "cenaNettoDataGridViewTextBoxColumn";
            // 
            // produktyBindingSource
            // 
            this.produktyBindingSource.DataMember = "Produkty";
            this.produktyBindingSource.DataSource = this.bazaMagazynDataSet;
            // 
            // bazaMagazynDataSet
            // 
            this.bazaMagazynDataSet.DataSetName = "BazaMagazynDataSet";
            this.bazaMagazynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produktyTableAdapter
            // 
            this.produktyTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewProduktyZamowienia
            // 
            this.dataGridViewProduktyZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduktyZamowienia.Location = new System.Drawing.Point(26, 317);
            this.dataGridViewProduktyZamowienia.Name = "dataGridViewProduktyZamowienia";
            this.dataGridViewProduktyZamowienia.Size = new System.Drawing.Size(415, 150);
            this.dataGridViewProduktyZamowienia.TabIndex = 1;
            // 
            // produktyZamówieniaBindingSource
            // 
            this.produktyZamówieniaBindingSource.DataMember = "Produkty_Zamówienia";
            this.produktyZamówieniaBindingSource.DataSource = this.bazaMagazynDataSet;
            // 
            // produkty_ZamówieniaTableAdapter
            // 
            this.produkty_ZamówieniaTableAdapter.ClearBeforeFill = true;
            // 
            // zamówieniaBindingSource
            // 
            this.zamówieniaBindingSource.DataMember = "Zamówienia";
            this.zamówieniaBindingSource.DataSource = this.bazaMagazynDataSet;
            // 
            // zamówieniaTableAdapter
            // 
            this.zamówieniaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // bDodajDoKoszyka
            // 
            this.bDodajDoKoszyka.Location = new System.Drawing.Point(12, 220);
            this.bDodajDoKoszyka.Name = "bDodajDoKoszyka";
            this.bDodajDoKoszyka.Size = new System.Drawing.Size(88, 34);
            this.bDodajDoKoszyka.TabIndex = 3;
            this.bDodajDoKoszyka.Text = "Dodaj Do Koszyka";
            this.bDodajDoKoszyka.UseVisualStyleBackColor = true;
            this.bDodajDoKoszyka.Click += new System.EventHandler(this.bDodajDoKoszyka_Click);
            // 
            // textId
            // 
            this.textId.Enabled = false;
            this.textId.Location = new System.Drawing.Point(88, 46);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(118, 20);
            this.textId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ilość";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cena Netto";
            // 
            // textNazwa
            // 
            this.textNazwa.Enabled = false;
            this.textNazwa.Location = new System.Drawing.Point(88, 78);
            this.textNazwa.Name = "textNazwa";
            this.textNazwa.Size = new System.Drawing.Size(118, 20);
            this.textNazwa.TabIndex = 8;
            // 
            // textIlosc
            // 
            this.textIlosc.Enabled = false;
            this.textIlosc.Location = new System.Drawing.Point(88, 104);
            this.textIlosc.Name = "textIlosc";
            this.textIlosc.Size = new System.Drawing.Size(118, 20);
            this.textIlosc.TabIndex = 9;
            // 
            // textCenaNetto
            // 
            this.textCenaNetto.Enabled = false;
            this.textCenaNetto.Location = new System.Drawing.Point(88, 136);
            this.textCenaNetto.Name = "textCenaNetto";
            this.textCenaNetto.Size = new System.Drawing.Size(118, 20);
            this.textCenaNetto.TabIndex = 10;
            // 
            // bAnuluj
            // 
            this.bAnuluj.Location = new System.Drawing.Point(118, 220);
            this.bAnuluj.Name = "bAnuluj";
            this.bAnuluj.Size = new System.Drawing.Size(88, 34);
            this.bAnuluj.TabIndex = 11;
            this.bAnuluj.Text = "Anuluj";
            this.bAnuluj.UseVisualStyleBackColor = true;
            this.bAnuluj.Click += new System.EventHandler(this.bAnuluj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-4, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Zamawiana Ilość";
            // 
            // textZamawianaIlosc
            // 
            this.textZamawianaIlosc.Location = new System.Drawing.Point(89, 172);
            this.textZamawianaIlosc.Name = "textZamawianaIlosc";
            this.textZamawianaIlosc.Size = new System.Drawing.Size(118, 20);
            this.textZamawianaIlosc.TabIndex = 13;
            // 
            // bWprowadzKlienta
            // 
            this.bWprowadzKlienta.Location = new System.Drawing.Point(468, 356);
            this.bWprowadzKlienta.Name = "bWprowadzKlienta";
            this.bWprowadzKlienta.Size = new System.Drawing.Size(123, 35);
            this.bWprowadzKlienta.TabIndex = 14;
            this.bWprowadzKlienta.Text = "Wprowadź Klienta";
            this.bWprowadzKlienta.UseVisualStyleBackColor = true;
            this.bWprowadzKlienta.Click += new System.EventHandler(this.bWprowadzKlienta_Click);
            // 
            // Zamówienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 509);
            this.Controls.Add(this.bWprowadzKlienta);
            this.Controls.Add(this.textZamawianaIlosc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bAnuluj);
            this.Controls.Add(this.textCenaNetto);
            this.Controls.Add(this.textIlosc);
            this.Controls.Add(this.textNazwa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.bDodajDoKoszyka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewProduktyZamowienia);
            this.Controls.Add(this.dataGridViewProdukty);
            this.Name = "Zamówienie";
            this.Text = "Zamówienie";
            this.Load += new System.EventHandler(this.Zamówienie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdukty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduktyZamowienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyZamówieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamówieniaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProdukty;
        private BazaMagazynDataSet bazaMagazynDataSet;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private BazaMagazynDataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaNettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewProduktyZamowienia;
        private System.Windows.Forms.BindingSource produktyZamówieniaBindingSource;
        private BazaMagazynDataSetTableAdapters.Produkty_ZamówieniaTableAdapter produkty_ZamówieniaTableAdapter;
        private System.Windows.Forms.BindingSource zamówieniaBindingSource;
        private BazaMagazynDataSetTableAdapters.ZamówieniaTableAdapter zamówieniaTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bDodajDoKoszyka;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNazwa;
        private System.Windows.Forms.TextBox textIlosc;
        private System.Windows.Forms.TextBox textCenaNetto;
        private System.Windows.Forms.Button bAnuluj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textZamawianaIlosc;
        private System.Windows.Forms.Button bWprowadzKlienta;
    }
}