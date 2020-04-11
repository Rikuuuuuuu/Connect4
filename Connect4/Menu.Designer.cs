namespace Connect4
{
    partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.P1vari = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.P2vari = new System.Windows.Forms.ComboBox();
            this.database = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.P1Name = new System.Windows.Forms.TextBox();
            this.P2Name = new System.Windows.Forms.TextBox();
            this.Ohjeet = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pelaa!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // P1vari
            // 
            this.P1vari.FormattingEnabled = true;
            this.P1vari.Items.AddRange(new object[] {
            "Punainen",
            "Keltainen",
            "Sininen",
            "Musta",
            "Vihreä",
            "Violetti",
            "Pinkki",
            "Oranssi",
            "Turkoosi"});
            this.P1vari.Location = new System.Drawing.Point(89, 114);
            this.P1vari.Name = "P1vari";
            this.P1vari.Size = new System.Drawing.Size(121, 21);
            this.P1vari.TabIndex = 1;
            this.P1vari.Text = "Punainen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pelaaja1 väri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pelaaja2 väri:";
            // 
            // P2vari
            // 
            this.P2vari.FormattingEnabled = true;
            this.P2vari.Items.AddRange(new object[] {
            "Keltainen",
            "Punainen",
            "Sininen",
            "Musta",
            "Vihreä",
            "Violetti",
            "Pinkki",
            "Oranssi",
            "Turkoosi"});
            this.P2vari.Location = new System.Drawing.Point(89, 163);
            this.P2vari.Name = "P2vari";
            this.P2vari.Size = new System.Drawing.Size(121, 21);
            this.P2vari.TabIndex = 4;
            this.P2vari.Text = "Keltainen";
            // 
            // database
            // 
            this.database.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database.Location = new System.Drawing.Point(138, 207);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(125, 41);
            this.database.TabIndex = 6;
            this.database.Text = "Database";
            this.database.UseVisualStyleBackColor = true;
            this.database.Click += new System.EventHandler(this.database_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pelaaja1 nimi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pelaaja2 nimi:";
            // 
            // P1Name
            // 
            this.P1Name.Location = new System.Drawing.Point(89, 30);
            this.P1Name.Name = "P1Name";
            this.P1Name.Size = new System.Drawing.Size(100, 20);
            this.P1Name.TabIndex = 9;
            this.P1Name.Text = "Pelaaja1";
            this.P1Name.Click += new System.EventHandler(this.P1Name_Click);
            // 
            // P2Name
            // 
            this.P2Name.Location = new System.Drawing.Point(89, 71);
            this.P2Name.Name = "P2Name";
            this.P2Name.Size = new System.Drawing.Size(100, 20);
            this.P2Name.TabIndex = 10;
            this.P2Name.Text = "Pelaaja2";
            this.P2Name.Click += new System.EventHandler(this.P2Name_Click);
            // 
            // Ohjeet
            // 
            this.Ohjeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ohjeet.Location = new System.Drawing.Point(12, 207);
            this.Ohjeet.Name = "Ohjeet";
            this.Ohjeet.Size = new System.Drawing.Size(120, 41);
            this.Ohjeet.TabIndex = 11;
            this.Ohjeet.Text = "Ohjeet";
            this.Ohjeet.UseVisualStyleBackColor = true;
            this.Ohjeet.Click += new System.EventHandler(this.Ohjeet_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(275, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 317);
            this.Controls.Add(this.Ohjeet);
            this.Controls.Add(this.P2Name);
            this.Controls.Add(this.P1Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.database);
            this.Controls.Add(this.P2vari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P1vari);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox P1vari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox P2vari;
        private System.Windows.Forms.Button database;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox P1Name;
        private System.Windows.Forms.TextBox P2Name;
        private System.Windows.Forms.Button Ohjeet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

