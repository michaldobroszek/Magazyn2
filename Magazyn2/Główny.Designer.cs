namespace Magazyn2
{
    partial class Główny
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bOK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bazaMagazynDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaMagazynDataSet = new Magazyn2.BazaMagazynDataSet();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klienciTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.KlienciTableAdapter();
            this.klienciZamówieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klienci_ZamówieniaTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.Klienci_ZamówieniaTableAdapter();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktyTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.ProduktyTableAdapter();
            this.produktyZamówieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produkty_ZamówieniaTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.Produkty_ZamówieniaTableAdapter();
            this.zamówieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamówieniaTableAdapter = new Magazyn2.BazaMagazynDataSetTableAdapters.ZamówieniaTableAdapter();
            this.bUsun = new System.Windows.Forms.Button();
            this.bEdytuj = new System.Windows.Forms.Button();
            this.bZamówienie = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciZamówieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyZamówieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamówieniaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wylogToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wylogToolStripMenuItem
            // 
            this.wylogToolStripMenuItem.Name = "wylogToolStripMenuItem";
            this.wylogToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.wylogToolStripMenuItem.Text = "Wyloguj";
            this.wylogToolStripMenuItem.Click += new System.EventHandler(this.wylogToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(175, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(302, 27);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(37, 23);
            this.bOK.TabIndex = 2;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(175, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 427);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dodaj Produkt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bazaMagazynDataSetBindingSource
            // 
            this.bazaMagazynDataSetBindingSource.DataSource = this.bazaMagazynDataSet;
            this.bazaMagazynDataSetBindingSource.Position = 0;
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
            // klienciZamówieniaBindingSource
            // 
            this.klienciZamówieniaBindingSource.DataMember = "Klienci_Zamówienia";
            this.klienciZamówieniaBindingSource.DataSource = this.bazaMagazynDataSet;
            // 
            // klienci_ZamówieniaTableAdapter
            // 
            this.klienci_ZamówieniaTableAdapter.ClearBeforeFill = true;
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
            // bUsun
            // 
            this.bUsun.Location = new System.Drawing.Point(13, 125);
            this.bUsun.Name = "bUsun";
            this.bUsun.Size = new System.Drawing.Size(121, 23);
            this.bUsun.TabIndex = 5;
            this.bUsun.Text = "Usuń Produkt";
            this.bUsun.UseVisualStyleBackColor = true;
            this.bUsun.Click += new System.EventHandler(this.bUsun_Click);
            // 
            // bEdytuj
            // 
            this.bEdytuj.Location = new System.Drawing.Point(13, 163);
            this.bEdytuj.Name = "bEdytuj";
            this.bEdytuj.Size = new System.Drawing.Size(120, 23);
            this.bEdytuj.TabIndex = 6;
            this.bEdytuj.Text = "Edytuj Produkt";
            this.bEdytuj.UseVisualStyleBackColor = true;
            this.bEdytuj.Click += new System.EventHandler(this.bEdytuj_Click);
            // 
            // bZamówienie
            // 
            this.bZamówienie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bZamówienie.Location = new System.Drawing.Point(12, 202);
            this.bZamówienie.Name = "bZamówienie";
            this.bZamówienie.Size = new System.Drawing.Size(120, 23);
            this.bZamówienie.TabIndex = 7;
            this.bZamówienie.Text = "Zamówienie";
            this.bZamówienie.UseVisualStyleBackColor = true;
            this.bZamówienie.Click += new System.EventHandler(this.bZamówienie_Click);
            // 
            // Główny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 521);
            this.Controls.Add(this.bZamówienie);
            this.Controls.Add(this.bEdytuj);
            this.Controls.Add(this.bUsun);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Główny";
            this.Text = "Główny";
            this.Load += new System.EventHandler(this.Główny_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaMagazynDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciZamówieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyZamówieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamówieniaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bazaMagazynDataSetBindingSource;
        private BazaMagazynDataSet bazaMagazynDataSet;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private BazaMagazynDataSetTableAdapters.KlienciTableAdapter klienciTableAdapter;
        private System.Windows.Forms.BindingSource klienciZamówieniaBindingSource;
        private BazaMagazynDataSetTableAdapters.Klienci_ZamówieniaTableAdapter klienci_ZamówieniaTableAdapter;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private BazaMagazynDataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.BindingSource produktyZamówieniaBindingSource;
        private BazaMagazynDataSetTableAdapters.Produkty_ZamówieniaTableAdapter produkty_ZamówieniaTableAdapter;
        private System.Windows.Forms.BindingSource zamówieniaBindingSource;
        private BazaMagazynDataSetTableAdapters.ZamówieniaTableAdapter zamówieniaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bUsun;
        private System.Windows.Forms.Button bEdytuj;
        private System.Windows.Forms.Button bZamówienie;
    }
}