namespace GuessGameNiceM
{
    partial class GuessGameNiceM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuessGameNiceM));
            this.lblUserNum = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUserNum
            // 
            this.lblUserNum.AutoSize = true;
            this.lblUserNum.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNum.Location = new System.Drawing.Point(260, 145);
            this.lblUserNum.Name = "lblUserNum";
            this.lblUserNum.Size = new System.Drawing.Size(237, 21);
            this.lblUserNum.TabIndex = 1;
            this.lblUserNum.Text = "Enter a number from 1-10";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(523, 247);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "label2";
            this.lblAnswer.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(353, 215);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(96, 45);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(146, 87);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(441, 25);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "Can you guess the number I\'m thinking of?";
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(539, 148);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(153, 20);
            this.txtGuess.TabIndex = 5;
            // 
            // GuessGameNiceM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(921, 496);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblUserNum);
            this.Name = "GuessGameNiceM";
            this.Text = "GuessGameNiceM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUserNum;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtGuess;
    }
}

