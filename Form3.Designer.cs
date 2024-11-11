namespace ViseFormi
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxVrsta = new System.Windows.Forms.ComboBox();
            this.comboBoxVelicina = new System.Windows.Forms.ComboBox();
            this.comboBoxBoja = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Veličina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Boja";
            // 
            // comboBoxVrsta
            // 
            this.comboBoxVrsta.FormattingEnabled = true;
            this.comboBoxVrsta.Location = new System.Drawing.Point(12, 25);
            this.comboBoxVrsta.Name = "comboBoxVrsta";
            this.comboBoxVrsta.Size = new System.Drawing.Size(156, 21);
            this.comboBoxVrsta.TabIndex = 3;
            // 
            // comboBoxVelicina
            // 
            this.comboBoxVelicina.FormattingEnabled = true;
            this.comboBoxVelicina.Location = new System.Drawing.Point(12, 81);
            this.comboBoxVelicina.Name = "comboBoxVelicina";
            this.comboBoxVelicina.Size = new System.Drawing.Size(156, 21);
            this.comboBoxVelicina.TabIndex = 4;
            // 
            // comboBoxBoja
            // 
            this.comboBoxBoja.FormattingEnabled = true;
            this.comboBoxBoja.Location = new System.Drawing.Point(12, 132);
            this.comboBoxBoja.Name = "comboBoxBoja";
            this.comboBoxBoja.Size = new System.Drawing.Size(156, 21);
            this.comboBoxBoja.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Otkaži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 202);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxBoja);
            this.Controls.Add(this.comboBoxVelicina);
            this.Controls.Add(this.comboBoxVrsta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Font";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxVrsta;
        private System.Windows.Forms.ComboBox comboBoxVelicina;
        private System.Windows.Forms.ComboBox comboBoxBoja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}