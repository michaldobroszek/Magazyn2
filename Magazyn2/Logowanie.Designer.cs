namespace Magazyn2
{
    partial class Logowanie
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
            this.textHaslo = new System.Windows.Forms.TextBox();
            this.bZaloguj = new System.Windows.Forms.Button();
            this.bPrzegladaj = new System.Windows.Forms.Button();
            this.bZamknij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasło";
            // 
            // textHaslo
            // 
            this.textHaslo.Location = new System.Drawing.Point(213, 71);
            this.textHaslo.Name = "textHaslo";
            this.textHaslo.Size = new System.Drawing.Size(131, 20);
            this.textHaslo.TabIndex = 1;
            this.textHaslo.UseSystemPasswordChar = true;
            // 
            // bZaloguj
            // 
            this.bZaloguj.Location = new System.Drawing.Point(139, 134);
            this.bZaloguj.Name = "bZaloguj";
            this.bZaloguj.Size = new System.Drawing.Size(75, 42);
            this.bZaloguj.TabIndex = 2;
            this.bZaloguj.Text = "Zaloguj";
            this.bZaloguj.UseVisualStyleBackColor = true;
            this.bZaloguj.Click += new System.EventHandler(this.bZaloguj_Click);
            // 
            // bPrzegladaj
            // 
            this.bPrzegladaj.Location = new System.Drawing.Point(229, 134);
            this.bPrzegladaj.Name = "bPrzegladaj";
            this.bPrzegladaj.Size = new System.Drawing.Size(75, 42);
            this.bPrzegladaj.TabIndex = 3;
            this.bPrzegladaj.Text = "Przeglądaj";
            this.bPrzegladaj.UseVisualStyleBackColor = true;
            this.bPrzegladaj.Click += new System.EventHandler(this.bPrzegladaj_Click);
            // 
            // bZamknij
            // 
            this.bZamknij.Location = new System.Drawing.Point(319, 134);
            this.bZamknij.Name = "bZamknij";
            this.bZamknij.Size = new System.Drawing.Size(75, 42);
            this.bZamknij.TabIndex = 4;
            this.bZamknij.Text = "Zamknij";
            this.bZamknij.UseVisualStyleBackColor = true;
            this.bZamknij.Click += new System.EventHandler(this.bZamknij_Click);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 281);
            this.Controls.Add(this.bZamknij);
            this.Controls.Add(this.bPrzegladaj);
            this.Controls.Add(this.bZaloguj);
            this.Controls.Add(this.textHaslo);
            this.Controls.Add(this.label1);
            this.Name = "Logowanie";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textHaslo;
        private System.Windows.Forms.Button bZaloguj;
        private System.Windows.Forms.Button bPrzegladaj;
        private System.Windows.Forms.Button bZamknij;
    }
}