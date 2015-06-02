namespace Magazyn2
{
    partial class UsunZamowienie
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
            this.klienciZamówieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaMagazynDataSet = new Magazyn2.BazaMagazynDataSet();
            this.bWyjdz = new System.Windows.Forms.Button();
            this.bUsun = new System.Windows.Forms.Button();
            this.klienci_ZamówieniaTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.Klienci_ZamówieniaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textidzamowienia = new System.Windows.Forms.TextBox();
            this.textklienta = new System.Windows.Forms.TextBox();
            this.klienciZamówieniaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zamówieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamówieniaTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.ZamówieniaTableAdapter();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klienciTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.KlienciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.klienciZamówieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciZamówieniaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamówieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // klienciZamówieniaBindingSource
            // 
            this.klienciZamówieniaBindingSource.DataMember = "Klienci_Zamówienia";
            this.klienciZamówieniaBindingSource.DataSource = this.bazaMagazynDataSet;
            // 
            // bazaMagazynDataSet
            // 
            this.bazaMagazynDataSet.DataSetName = "BazaMagazynDataSet";
            this.bazaMagazynDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bWyjdz
            // 
            this.bWyjdz.Location = new System.Drawing.Point(12, 167);
            this.bWyjdz.Name = "bWyjdz";
            this.bWyjdz.Size = new System.Drawing.Size(75, 23);
            this.bWyjdz.TabIndex = 1;
            this.bWyjdz.Text = "Wyjdź";
            this.bWyjdz.UseVisualStyleBackColor = true;
            this.bWyjdz.Click += new System.EventHandler(this.bWyjdz_Click);
            // 
            // bUsun
            // 
            this.bUsun.Location = new System.Drawing.Point(12, 118);
            this.bUsun.Name = "bUsun";
            this.bUsun.Size = new System.Drawing.Size(75, 23);
            this.bUsun.TabIndex = 2;
            this.bUsun.Text = "Usuń";
            this.bUsun.UseVisualStyleBackColor = true;
            this.bUsun.Click += new System.EventHandler(this.bUsun_Click);
            // 
            // klienci_ZamówieniaTableAdapter
            // 
            this.klienci_ZamówieniaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(93, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 395);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // textidzamowienia
            // 
            this.textidzamowienia.Location = new System.Drawing.Point(-3, 36);
            this.textidzamowienia.Name = "textidzamowienia";
            this.textidzamowienia.Size = new System.Drawing.Size(100, 20);
            this.textidzamowienia.TabIndex = 4;
            // 
            // textklienta
            // 
            this.textklienta.Location = new System.Drawing.Point(-3, 239);
            this.textklienta.Name = "textklienta";
            this.textklienta.Size = new System.Drawing.Size(100, 20);
            this.textklienta.TabIndex = 5;
            // 
            // klienciZamówieniaBindingSource1
            // 
            this.klienciZamówieniaBindingSource1.DataMember = "Klienci_Zamówienia";
            this.klienciZamówieniaBindingSource1.DataSource = this.bazaMagazynDataSet;
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
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataMember = "Klienci";
            this.klienciBindingSource.DataSource = this.bazaMagazynDataSet;
            // 
            // klienciTableAdapter
            // 
            this.klienciTableAdapter.ClearBeforeFill = true;
            // 
            // UsunZamowienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 420);
            this.Controls.Add(this.textklienta);
            this.Controls.Add(this.textidzamowienia);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bUsun);
            this.Controls.Add(this.bWyjdz);
            this.Name = "UsunZamowienie";
            this.Text = "UsunZamowienie";
            this.Load += new System.EventHandler(this.UsunZamowienie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klienciZamówieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciZamówieniaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamówieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bWyjdz;
        private System.Windows.Forms.Button bUsun;
        private BazaMagazynDataSet bazaMagazynDataSet;
        private System.Windows.Forms.BindingSource klienciZamówieniaBindingSource;
        private BazaMagazynDataSetTableAdapters.Klienci_ZamówieniaTableAdapter klienci_ZamówieniaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textidzamowienia;
        private System.Windows.Forms.TextBox textklienta;
        private System.Windows.Forms.BindingSource klienciZamówieniaBindingSource1;
        private System.Windows.Forms.BindingSource zamówieniaBindingSource;
        private BazaMagazynDataSetTableAdapters.ZamówieniaTableAdapter zamówieniaTableAdapter;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private BazaMagazynDataSetTableAdapters.KlienciTableAdapter klienciTableAdapter;
    }
}