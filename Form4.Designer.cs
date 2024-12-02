namespace ViseFormi
{
    partial class Form4
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonUpisiIzostanak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(149, 8);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(8, 26);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxIme.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // buttonUpisiIzostanak
            // 
            this.buttonUpisiIzostanak.Location = new System.Drawing.Point(8, 147);
            this.buttonUpisiIzostanak.Name = "buttonUpisiIzostanak";
            this.buttonUpisiIzostanak.Size = new System.Drawing.Size(90, 23);
            this.buttonUpisiIzostanak.TabIndex = 3;
            this.buttonUpisiIzostanak.Text = "Upiši izostanak";
            this.buttonUpisiIzostanak.UseVisualStyleBackColor = true;
            this.buttonUpisiIzostanak.Click += new System.EventHandler(this.buttonUpisiIzostanak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 192);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpisiIzostanak);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form4";
            this.Text = "Upiši izostanke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonUpisiIzostanak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}