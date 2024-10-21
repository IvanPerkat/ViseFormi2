namespace ViseFormi
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIndeks = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.comboBoxSmjer = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.buttonSnimi = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxVrstaStudija = new System.Windows.Forms.GroupBox();
            this.radioButtonStudijRedovni = new System.Windows.Forms.RadioButton();
            this.radioButtonStudijIzvanredni = new System.Windows.Forms.RadioButton();
            this.groupBoxVrstaStudija.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum rođenja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Indeks";
            // 
            // textBoxIndeks
            // 
            this.textBoxIndeks.Location = new System.Drawing.Point(247, 40);
            this.textBoxIndeks.Name = "textBoxIndeks";
            this.textBoxIndeks.Size = new System.Drawing.Size(139, 20);
            this.textBoxIndeks.TabIndex = 5;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(39, 117);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(139, 20);
            this.textBoxPrezime.TabIndex = 6;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(39, 40);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(139, 20);
            this.textBoxIme.TabIndex = 7;
            // 
            // comboBoxSmjer
            // 
            this.comboBoxSmjer.FormattingEnabled = true;
            this.comboBoxSmjer.Location = new System.Drawing.Point(39, 200);
            this.comboBoxSmjer.Name = "comboBoxSmjer";
            this.comboBoxSmjer.Size = new System.Drawing.Size(139, 21);
            this.comboBoxSmjer.TabIndex = 8;
            // 
            // dateTimePickerDatumRodjenja
            // 
            this.dateTimePickerDatumRodjenja.Location = new System.Drawing.Point(247, 114);
            this.dateTimePickerDatumRodjenja.Name = "dateTimePickerDatumRodjenja";
            this.dateTimePickerDatumRodjenja.Size = new System.Drawing.Size(139, 20);
            this.dateTimePickerDatumRodjenja.TabIndex = 9;
            // 
            // buttonSnimi
            // 
            this.buttonSnimi.Location = new System.Drawing.Point(66, 283);
            this.buttonSnimi.Name = "buttonSnimi";
            this.buttonSnimi.Size = new System.Drawing.Size(75, 23);
            this.buttonSnimi.TabIndex = 10;
            this.buttonSnimi.Text = "Snimi";
            this.buttonSnimi.UseVisualStyleBackColor = true;
            this.buttonSnimi.Click += new System.EventHandler(this.buttonSnimi_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Otkaži";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Smjer";
            // 
            // groupBoxVrstaStudija
            // 
            this.groupBoxVrstaStudija.Controls.Add(this.radioButtonStudijIzvanredni);
            this.groupBoxVrstaStudija.Controls.Add(this.radioButtonStudijRedovni);
            this.groupBoxVrstaStudija.Location = new System.Drawing.Point(247, 184);
            this.groupBoxVrstaStudija.Name = "groupBoxVrstaStudija";
            this.groupBoxVrstaStudija.Size = new System.Drawing.Size(139, 84);
            this.groupBoxVrstaStudija.TabIndex = 14;
            this.groupBoxVrstaStudija.TabStop = false;
            this.groupBoxVrstaStudija.Text = "Vrsta studija";
            // 
            // radioButtonStudijRedovni
            // 
            this.radioButtonStudijRedovni.AutoSize = true;
            this.radioButtonStudijRedovni.Location = new System.Drawing.Point(6, 24);
            this.radioButtonStudijRedovni.Name = "radioButtonStudijRedovni";
            this.radioButtonStudijRedovni.Size = new System.Drawing.Size(71, 17);
            this.radioButtonStudijRedovni.TabIndex = 0;
            this.radioButtonStudijRedovni.TabStop = true;
            this.radioButtonStudijRedovni.Text = "Redeovni";
            this.radioButtonStudijRedovni.UseVisualStyleBackColor = true;
            // 
            // radioButtonStudijIzvanredni
            // 
            this.radioButtonStudijIzvanredni.AutoSize = true;
            this.radioButtonStudijIzvanredni.Location = new System.Drawing.Point(6, 58);
            this.radioButtonStudijIzvanredni.Name = "radioButtonStudijIzvanredni";
            this.radioButtonStudijIzvanredni.Size = new System.Drawing.Size(74, 17);
            this.radioButtonStudijIzvanredni.TabIndex = 1;
            this.radioButtonStudijIzvanredni.TabStop = true;
            this.radioButtonStudijIzvanredni.Text = "Izvanredni";
            this.radioButtonStudijIzvanredni.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 318);
            this.Controls.Add(this.groupBoxVrstaStudija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonSnimi);
            this.Controls.Add(this.dateTimePickerDatumRodjenja);
            this.Controls.Add(this.comboBoxSmjer);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIndeks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBoxVrstaStudija.ResumeLayout(false);
            this.groupBoxVrstaStudija.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIndeks;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.ComboBox comboBoxSmjer;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatumRodjenja;
        private System.Windows.Forms.Button buttonSnimi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxVrstaStudija;
        private System.Windows.Forms.RadioButton radioButtonStudijIzvanredni;
        private System.Windows.Forms.RadioButton radioButtonStudijRedovni;
    }
}