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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisiStudenta = new System.Windows.Forms.Button();
            this.buttonObrisiSve = new System.Windows.Forms.Button();
            this.listBoxStudenti = new System.Windows.Forms.ListBox();
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.buttonCitaj = new System.Windows.Forms.Button();
            this.statusStripVrijeme = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porukeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxOtvori = new System.Windows.Forms.GroupBox();
            this.buttonStartInfo = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonWord = new System.Windows.Forms.Button();
            this.buttonChrome = new System.Windows.Forms.Button();
            this.buttonUpišiIzostanak = new System.Windows.Forms.Button();
            this.buttonPrikaziIzostanke = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStripVrijeme.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBoxOtvori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(9, 34);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisiStudenta
            // 
            this.buttonObrisiStudenta.Location = new System.Drawing.Point(219, 34);
            this.buttonObrisiStudenta.Name = "buttonObrisiStudenta";
            this.buttonObrisiStudenta.Size = new System.Drawing.Size(97, 23);
            this.buttonObrisiStudenta.TabIndex = 1;
            this.buttonObrisiStudenta.Text = "Obriši studenta";
            this.buttonObrisiStudenta.UseVisualStyleBackColor = true;
            this.buttonObrisiStudenta.Click += new System.EventHandler(this.buttonObrisiStudenta_Click);
            // 
            // buttonObrisiSve
            // 
            this.buttonObrisiSve.Location = new System.Drawing.Point(9, 320);
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
            this.listBoxStudenti.Location = new System.Drawing.Point(9, 62);
            this.listBoxStudenti.Name = "listBoxStudenti";
            this.listBoxStudenti.Size = new System.Drawing.Size(307, 238);
            this.listBoxStudenti.TabIndex = 3;
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(125, 320);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(75, 23);
            this.buttonSpremi.TabIndex = 4;
            this.buttonSpremi.Text = "Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // buttonCitaj
            // 
            this.buttonCitaj.Location = new System.Drawing.Point(241, 320);
            this.buttonCitaj.Name = "buttonCitaj";
            this.buttonCitaj.Size = new System.Drawing.Size(75, 23);
            this.buttonCitaj.TabIndex = 6;
            this.buttonCitaj.Text = "Čitaj";
            this.buttonCitaj.UseVisualStyleBackColor = true;
            this.buttonCitaj.Click += new System.EventHandler(this.buttonCitaj_Click);
            // 
            // statusStripVrijeme
            // 
            this.statusStripVrijeme.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStripVrijeme.Location = new System.Drawing.Point(0, 362);
            this.statusStripVrijeme.Name = "statusStripVrijeme";
            this.statusStripVrijeme.Size = new System.Drawing.Size(555, 22);
            this.statusStripVrijeme.TabIndex = 7;
            this.statusStripVrijeme.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.messageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.fileToolStripMenuItem.Text = "Datoteka";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.openToolStripMenuItem.Text = "Otvori";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.saveToolStripMenuItem.Text = "Spremi";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "Izađi";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.editToolStripMenuItem.Text = "Izmjeni";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.optionsToolStripMenuItem.Text = "Opcije";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porukeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.viewToolStripMenuItem.Text = "Pregled";
            // 
            // porukeToolStripMenuItem
            // 
            this.porukeToolStripMenuItem.Name = "porukeToolStripMenuItem";
            this.porukeToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.porukeToolStripMenuItem.Text = "Poruka";
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAplikacijiToolStripMenuItem});
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.messageToolStripMenuItem.Text = "Pmoć";
            // 
            // oAplikacijiToolStripMenuItem
            // 
            this.oAplikacijiToolStripMenuItem.Name = "oAplikacijiToolStripMenuItem";
            this.oAplikacijiToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.oAplikacijiToolStripMenuItem.Text = "O aplikaciji";
            // 
            // groupBoxOtvori
            // 
            this.groupBoxOtvori.Controls.Add(this.buttonStartInfo);
            this.groupBoxOtvori.Controls.Add(this.buttonExcel);
            this.groupBoxOtvori.Controls.Add(this.buttonWord);
            this.groupBoxOtvori.Controls.Add(this.buttonChrome);
            this.groupBoxOtvori.Location = new System.Drawing.Point(343, 62);
            this.groupBoxOtvori.Name = "groupBoxOtvori";
            this.groupBoxOtvori.Size = new System.Drawing.Size(200, 93);
            this.groupBoxOtvori.TabIndex = 9;
            this.groupBoxOtvori.TabStop = false;
            // 
            // buttonStartInfo
            // 
            this.buttonStartInfo.Location = new System.Drawing.Point(103, 61);
            this.buttonStartInfo.Name = "buttonStartInfo";
            this.buttonStartInfo.Size = new System.Drawing.Size(91, 23);
            this.buttonStartInfo.TabIndex = 3;
            this.buttonStartInfo.Text = "Start Info";
            this.buttonStartInfo.UseVisualStyleBackColor = true;
            this.buttonStartInfo.Click += new System.EventHandler(this.buttonStartInfo_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(6, 61);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(91, 23);
            this.buttonExcel.TabIndex = 2;
            this.buttonExcel.Text = "Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcele_Click);
            // 
            // buttonWord
            // 
            this.buttonWord.Location = new System.Drawing.Point(103, 19);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(91, 23);
            this.buttonWord.TabIndex = 1;
            this.buttonWord.Text = "Word";
            this.buttonWord.UseVisualStyleBackColor = true;
            this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // buttonChrome
            // 
            this.buttonChrome.Location = new System.Drawing.Point(6, 19);
            this.buttonChrome.Name = "buttonChrome";
            this.buttonChrome.Size = new System.Drawing.Size(91, 23);
            this.buttonChrome.TabIndex = 0;
            this.buttonChrome.Text = "Chrome";
            this.buttonChrome.UseVisualStyleBackColor = true;
            this.buttonChrome.Click += new System.EventHandler(this.buttonChrome_Click);
            // 
            // buttonUpišiIzostanak
            // 
            this.buttonUpišiIzostanak.Location = new System.Drawing.Point(446, 161);
            this.buttonUpišiIzostanak.Name = "buttonUpišiIzostanak";
            this.buttonUpišiIzostanak.Size = new System.Drawing.Size(91, 23);
            this.buttonUpišiIzostanak.TabIndex = 10;
            this.buttonUpišiIzostanak.Text = "Upiši izostanak";
            this.buttonUpišiIzostanak.UseVisualStyleBackColor = true;
            this.buttonUpišiIzostanak.Click += new System.EventHandler(this.buttonUpišiIzostanak_Click);
            // 
            // buttonPrikaziIzostanke
            // 
            this.buttonPrikaziIzostanke.Location = new System.Drawing.Point(343, 161);
            this.buttonPrikaziIzostanke.Name = "buttonPrikaziIzostanke";
            this.buttonPrikaziIzostanke.Size = new System.Drawing.Size(97, 23);
            this.buttonPrikaziIzostanke.TabIndex = 11;
            this.buttonPrikaziIzostanke.Text = "Prikaži izostanke";
            this.buttonPrikaziIzostanke.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(343, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(354, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Prikaži sliku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(555, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPrikaziIzostanke);
            this.Controls.Add(this.buttonUpišiIzostanak);
            this.Controls.Add(this.groupBoxOtvori);
            this.Controls.Add(this.statusStripVrijeme);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonCitaj);
            this.Controls.Add(this.buttonSpremi);
            this.Controls.Add(this.listBoxStudenti);
            this.Controls.Add(this.buttonObrisiSve);
            this.Controls.Add(this.buttonObrisiStudenta);
            this.Controls.Add(this.buttonDodaj);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Studenti";
            this.statusStripVrijeme.ResumeLayout(false);
            this.statusStripVrijeme.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxOtvori.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisiStudenta;
        private System.Windows.Forms.Button buttonObrisiSve;
        private System.Windows.Forms.ListBox listBoxStudenti;
        private System.Windows.Forms.Button buttonSpremi;
        private System.Windows.Forms.Button buttonCitaj;
        private System.Windows.Forms.StatusStrip statusStripVrijeme;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porukeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxOtvori;
        private System.Windows.Forms.Button buttonStartInfo;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonWord;
        private System.Windows.Forms.Button buttonChrome;
        private System.Windows.Forms.Button buttonUpišiIzostanak;
        private System.Windows.Forms.Button buttonPrikaziIzostanke;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

