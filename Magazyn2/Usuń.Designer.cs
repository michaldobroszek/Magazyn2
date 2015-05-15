namespace Magazyn2
{
    partial class Usuń
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
            this.idProduktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaNettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaMagazynDataSet = new Magazyn2.BazaMagazynDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.textIdProdukt = new System.Windows.Forms.TextBox();
            this.bUsun = new System.Windows.Forms.Button();
            this.bWyjdz = new System.Windows.Forms.Button();
            this.produktyTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.ProduktyTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(323, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Produktu";
            // 
            // textIdProdukt
            // 
            this.textIdProdukt.Enabled = false;
            this.textIdProdukt.Location = new System.Drawing.Point(93, 87);
            this.textIdProdukt.Name = "textIdProdukt";
            this.textIdProdukt.Size = new System.Drawing.Size(100, 20);
            this.textIdProdukt.TabIndex = 2;
            // 
            // bUsun
            // 
            this.bUsun.Location = new System.Drawing.Point(28, 186);
            this.bUsun.Name = "bUsun";
            this.bUsun.Size = new System.Drawing.Size(75, 23);
            this.bUsun.TabIndex = 3;
            this.bUsun.Text = "Usuń";
            this.bUsun.UseVisualStyleBackColor = true;
            this.bUsun.Click += new System.EventHandler(this.bUsun_Click);
            // 
            // bWyjdz
            // 
            this.bWyjdz.Location = new System.Drawing.Point(143, 186);
            this.bWyjdz.Name = "bWyjdz";
            this.bWyjdz.Size = new System.Drawing.Size(75, 23);
            this.bWyjdz.TabIndex = 4;
            this.bWyjdz.Text = "Wyjdz";
            this.bWyjdz.UseVisualStyleBackColor = true;
            this.bWyjdz.Click += new System.EventHandler(this.bWyjdz_Click);
            // 
            // produktyTableAdapter
            // 
            this.produktyTableAdapter.ClearBeforeFill = true;
            // 
            // Usuń
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 369);
            this.Controls.Add(this.bWyjdz);
            this.Controls.Add(this.bUsun);
            this.Controls.Add(this.textIdProdukt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Usuń";
            this.Text = "Usuń";
            this.Load += new System.EventHandler(this.Usuń_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIdProdukt;
        private System.Windows.Forms.Button bUsun;
        private System.Windows.Forms.Button bWyjdz;
        private BazaMagazynDataSet bazaMagazynDataSet;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private BazaMagazynDataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaNettoDataGridViewTextBoxColumn;
    }
}