namespace Magazyn2
{
    partial class Zamówienie2
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
            this.label1 = new System.Windows.Forms.Label();
            this.bDalej = new System.Windows.Forms.Button();
            this.textNazwaKlienta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textRegon = new System.Windows.Forms.TextBox();
            this.textNip = new System.Windows.Forms.TextBox();
            this.bCofnij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa Klienta";
            // 
            // bDalej
            // 
            this.bDalej.Location = new System.Drawing.Point(120, 236);
            this.bDalej.Name = "bDalej";
            this.bDalej.Size = new System.Drawing.Size(88, 31);
            this.bDalej.TabIndex = 1;
            this.bDalej.Text = "Dalej";
            this.bDalej.UseVisualStyleBackColor = true;
            this.bDalej.Click += new System.EventHandler(this.bDalej_Click);
            // 
            // textNazwaKlienta
            // 
            this.textNazwaKlienta.Location = new System.Drawing.Point(212, 74);
            this.textNazwaKlienta.Name = "textNazwaKlienta";
            this.textNazwaKlienta.Size = new System.Drawing.Size(165, 20);
            this.textNazwaKlienta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "REGON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NIP";
            // 
            // textRegon
            // 
            this.textRegon.Location = new System.Drawing.Point(212, 143);
            this.textRegon.Name = "textRegon";
            this.textRegon.Size = new System.Drawing.Size(165, 20);
            this.textRegon.TabIndex = 5;
            // 
            // textNip
            // 
            this.textNip.Location = new System.Drawing.Point(212, 108);
            this.textNip.Name = "textNip";
            this.textNip.Size = new System.Drawing.Size(165, 20);
            this.textNip.TabIndex = 6;
            // 
            // bCofnij
            // 
            this.bCofnij.Location = new System.Drawing.Point(289, 236);
            this.bCofnij.Name = "bCofnij";
            this.bCofnij.Size = new System.Drawing.Size(88, 31);
            this.bCofnij.TabIndex = 7;
            this.bCofnij.Text = "Cofnij";
            this.bCofnij.UseVisualStyleBackColor = true;
            this.bCofnij.Click += new System.EventHandler(this.bCofnij_Click);
            // 
            // Zamówienie2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 372);
            this.Controls.Add(this.bCofnij);
            this.Controls.Add(this.textNip);
            this.Controls.Add(this.textRegon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNazwaKlienta);
            this.Controls.Add(this.bDalej);
            this.Controls.Add(this.label1);
            this.Name = "Zamówienie2";
            this.Text = "Zamówienie2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bDalej;
        private System.Windows.Forms.TextBox textNazwaKlienta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textRegon;
        private System.Windows.Forms.TextBox textNip;
        private System.Windows.Forms.Button bCofnij;
    }
}