namespace ViseFormi
{
    partial class Form1
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
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisiStudenta = new System.Windows.Forms.Button();
            this.buttonObrisiSve = new System.Windows.Forms.Button();
            this.listBoxStudenti = new System.Windows.Forms.ListBox();
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.buttonCitaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(12, 12);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisiStudenta
            // 
            this.buttonObrisiStudenta.Location = new System.Drawing.Point(338, 97);
            this.buttonObrisiStudenta.Name = "buttonObrisiStudenta";
            this.buttonObrisiStudenta.Size = new System.Drawing.Size(97, 23);
            this.buttonObrisiStudenta.TabIndex = 1;
            this.buttonObrisiStudenta.Text = "Obriši studenta";
            this.buttonObrisiStudenta.UseVisualStyleBackColor = true;
            this.buttonObrisiStudenta.Click += new System.EventHandler(this.buttonObrisiStudenta_Click);
            // 
            // buttonObrisiSve
            // 
            this.buttonObrisiSve.Location = new System.Drawing.Point(12, 181);
            this.buttonObrisiSve.Name = "buttonObrisiSve";
            this.buttonObrisiSve.Size = new System.Drawing.Size(75, 23);
            this.buttonObrisiSve.TabIndex = 2;
            this.buttonObrisiSve.Text = "Obriši sve";
            this.buttonObrisiSve.UseVisualStyleBackColor = true;
            this.buttonObrisiSve.Click += new System.EventHandler(this.buttonObrisiSve_Click);
            // 
            // listBoxStudenti
            // 
            this.listBoxStudenti.FormattingEnabled = true;
            this.listBoxStudenti.Location = new System.Drawing.Point(12, 41);
            this.listBoxStudenti.Name = "listBoxStudenti";
            this.listBoxStudenti.Size = new System.Drawing.Size(307, 134);
            this.listBoxStudenti.TabIndex = 3;
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(128, 181);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(75, 23);
            this.buttonSpremi.TabIndex = 4;
            this.buttonSpremi.Text = "Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // buttonCitaj
            // 
            this.buttonCitaj.Location = new System.Drawing.Point(244, 181);
            this.buttonCitaj.Name = "buttonCitaj";
            this.buttonCitaj.Size = new System.Drawing.Size(75, 23);
            this.buttonCitaj.TabIndex = 6;
            this.buttonCitaj.Text = "Čitaj";
            this.buttonCitaj.UseVisualStyleBackColor = true;
            this.buttonCitaj.Click += new System.EventHandler(this.buttonCitaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 219);
            this.Controls.Add(this.buttonCitaj);
            this.Controls.Add(this.buttonSpremi);
            this.Controls.Add(this.listBoxStudenti);
            this.Controls.Add(this.buttonObrisiSve);
            this.Controls.Add(this.buttonObrisiStudenta);
            this.Controls.Add(this.buttonDodaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisiStudenta;
        private System.Windows.Forms.Button buttonObrisiSve;
        private System.Windows.Forms.ListBox listBoxStudenti;
        private System.Windows.Forms.Button buttonSpremi;
        private System.Windows.Forms.Button buttonCitaj;
    }
}

