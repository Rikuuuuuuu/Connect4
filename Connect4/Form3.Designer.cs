namespace Connect4
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
            this.NextPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NextPlayer
            // 
            this.NextPlayer.AutoSize = true;
            this.NextPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPlayer.Location = new System.Drawing.Point(646, 237);
            this.NextPlayer.Name = "NextPlayer";
            this.NextPlayer.Size = new System.Drawing.Size(228, 55);
            this.NextPlayer.TabIndex = 0;
            this.NextPlayer.Text = "Punainen";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 537);
            this.Controls.Add(this.NextPlayer);
            this.Name = "Form3";
            this.Text = "Pelilauta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NextPlayer;
    }
}