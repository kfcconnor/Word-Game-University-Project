namespace WindowsFormsApplication1
{
    partial class frmGuessTheWord
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
            this.lblGuessTheWord = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblScrambleWord = new System.Windows.Forms.Label();
            this.lblYourWord = new System.Windows.Forms.Label();
            this.lblRemainingAttempts = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGuessTheWord
            // 
            this.lblGuessTheWord.AutoSize = true;
            this.lblGuessTheWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessTheWord.Location = new System.Drawing.Point(12, 9);
            this.lblGuessTheWord.Name = "lblGuessTheWord";
            this.lblGuessTheWord.Size = new System.Drawing.Size(274, 37);
            this.lblGuessTheWord.TabIndex = 0;
            this.lblGuessTheWord.Text = "Guess The Word";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(270, 275);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(242, 142);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(103, 23);
            this.btnGuess.TabIndex = 9;
            this.btnGuess.Text = "Submit Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(82, 145);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(154, 20);
            this.txtGuess.TabIndex = 8;
            // 
            // lblScrambleWord
            // 
            this.lblScrambleWord.AutoSize = true;
            this.lblScrambleWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScrambleWord.Location = new System.Drawing.Point(165, 116);
            this.lblScrambleWord.Name = "lblScrambleWord";
            this.lblScrambleWord.Size = new System.Drawing.Size(0, 20);
            this.lblScrambleWord.TabIndex = 7;
            // 
            // lblYourWord
            // 
            this.lblYourWord.AutoSize = true;
            this.lblYourWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourWord.Location = new System.Drawing.Point(49, 80);
            this.lblYourWord.Name = "lblYourWord";
            this.lblYourWord.Size = new System.Drawing.Size(156, 25);
            this.lblYourWord.TabIndex = 6;
            this.lblYourWord.Text = "Your Word Is:";
            // 
            // lblRemainingAttempts
            // 
            this.lblRemainingAttempts.AutoSize = true;
            this.lblRemainingAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingAttempts.Location = new System.Drawing.Point(64, 198);
            this.lblRemainingAttempts.Name = "lblRemainingAttempts";
            this.lblRemainingAttempts.Size = new System.Drawing.Size(249, 25);
            this.lblRemainingAttempts.TabIndex = 17;
            this.lblRemainingAttempts.Text = "Attempts Remaining: 5";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemaining.Location = new System.Drawing.Point(64, 235);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(208, 25);
            this.lblTimeRemaining.TabIndex = 18;
            this.lblTimeRemaining.Text = "Time Remining: 60";
            // 
            // frmGuessTheWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 298);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.lblRemainingAttempts);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblScrambleWord);
            this.Controls.Add(this.lblYourWord);
            this.Controls.Add(this.lblGuessTheWord);
            this.Name = "frmGuessTheWord";
            this.Text = "Guess The Word";
            this.Load += new System.EventHandler(this.frmGuessTheWord_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(frmGuessTheWord_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuessTheWord;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblScrambleWord;
        private System.Windows.Forms.Label lblYourWord;
        private System.Windows.Forms.Label lblRemainingAttempts;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimeRemaining;
    }
}