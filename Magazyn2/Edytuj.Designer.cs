namespace Magazyn2
{
    partial class Edytuj
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
            this.label1 = new System.Windows.Forms.Label();
            this.bEdytuj = new System.Windows.Forms.Button();
            this.textNazwa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textIlosc = new System.Windows.Forms.TextBox();
            this.textCenaNetto = new System.Windows.Forms.TextBox();
            this.bWyjdz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.bazaMagazynDataSet = new Magazyn2.BazaMagazynDataSet();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktyTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.ProduktyTableAdapter();
            this.idProduktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaNettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduktDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.ilośćDataGridViewTextBoxColumn,
            this.cenaNettoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produktyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(267, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(332, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa";
            // 
            // bEdytuj
            // 
            this.bEdytuj.Location = new System.Drawing.Point(15, 168);
            this.bEdytuj.Name = "bEdytuj";
            this.bEdytuj.Size = new System.Drawing.Size(75, 23);
            this.bEdytuj.TabIndex = 2;
            this.bEdytuj.Text = "Edytuj";
            this.bEdytuj.UseVisualStyleBackColor = true;
            this.bEdytuj.Click += new System.EventHandler(this.bEdytuj_Click);
            // 
            // textNazwa
            // 
            this.textNazwa.Location = new System.Drawing.Point(77, 63);
            this.textNazwa.Name = "textNazwa";
            this.textNazwa.Size = new System.Drawing.Size(161, 20);
            this.textNazwa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ilość";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cena Netto";
            // 
            // textIlosc
            // 
            this.textIlosc.Location = new System.Drawing.Point(77, 95);
            this.textIlosc.Name = "textIlosc";
            this.textIlosc.Size = new System.Drawing.Size(161, 20);
            this.textIlosc.TabIndex = 6;
            // 
            // textCenaNetto
            // 
            this.textCenaNetto.Location = new System.Drawing.Point(77, 124);
            this.textCenaNetto.Name = "textCenaNetto";
            this.textCenaNetto.Size = new System.Drawing.Size(161, 20);
            this.textCenaNetto.TabIndex = 7;
            // 
            // bWyjdz
            // 
            this.bWyjdz.Location = new System.Drawing.Point(124, 168);
            this.bWyjdz.Name = "bWyjdz";
            this.bWyjdz.Size = new System.Drawing.Size(75, 23);
            this.bWyjdz.TabIndex = 8;
            this.bWyjdz.Text = "Wyjdź";
            this.bWyjdz.UseVisualStyleBackColor = true;
            this.bWyjdz.Click += new System.EventHandler(this.bWyjdz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID";
            // 
            // textId
            // 
            this.textId.Enabled = false;
            this.textId.Location = new System.Drawing.Point(77, 34);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(161, 20);
            this.textId.TabIndex = 10;
            // 
            // bazaMagazynDataSet
            // 
            this.bazaMagazynDataSet.DataSetName = "BazaMagazynDataSet";
            this.bazaMagazynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Edytuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 330);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bWyjdz);
            this.Controls.Add(this.textCenaNetto);
            this.Controls.Add(this.textIlosc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNazwa);
            this.Controls.Add(this.bEdytuj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Edytuj";
            this.Text = "Edytuj";
            this.Load += new System.EventHandler(this.Edytuj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bEdytuj;
        private System.Windows.Forms.TextBox textNazwa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIlosc;
        private System.Windows.Forms.TextBox textCenaNetto;
        private System.Windows.Forms.Button bWyjdz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textId;
        private BazaMagazynDataSet bazaMagazynDataSet;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private BazaMagazynDataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaNettoDataGridViewTextBoxColumn;
    }
}