namespace WindowsFormsApplication1
{
    partial class frmMainMenu
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
            this.btnGuessTheWord = new System.Windows.Forms.Button();
            this.btnConundrum = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuessTheWord
            // 
            this.btnGuessTheWord.Location = new System.Drawing.Point(14, 29);
            this.btnGuessTheWord.Name = "btnGuessTheWord";
            this.btnGuessTheWord.Size = new System.Drawing.Size(376, 118);
            this.btnGuessTheWord.TabIndex = 0;
            this.btnGuessTheWord.Text = "Guess The Word";
            this.btnGuessTheWord.UseVisualStyleBackColor = true;
            this.btnGuessTheWord.Click += new System.EventHandler(this.btnGuessTheWord_Click);
            // 
            // btnConundrum
            // 
            this.btnConundrum.Location = new System.Drawing.Point(15, 163);
            this.btnConundrum.Name = "btnConundrum";
            this.btnConundrum.Size = new System.Drawing.Size(374, 103);
            this.btnConundrum.TabIndex = 1;
            this.btnConundrum.Text = "Conundrum";
            this.btnConundrum.UseVisualStyleBackColor = true;
            this.btnConundrum.Click += new System.EventHandler(this.btnConundrum_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 280);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(372, 98);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 390);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConundrum);
            this.Controls.Add(this.btnGuessTheWord);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frmMainMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuessTheWord;
        private System.Windows.Forms.Button btnConundrum;
        private System.Windows.Forms.Button btnExit;
    }
}

