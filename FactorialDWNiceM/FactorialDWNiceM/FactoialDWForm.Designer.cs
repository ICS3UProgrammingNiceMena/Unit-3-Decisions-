namespace FactorialDWNiceM
{
    partial class FactoialDWForm
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblMultiply = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Monospac821 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(86, 71);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(251, 29);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Enter the number:";
            // 
            // lblMultiply
            // 
            this.lblMultiply.AutoSize = true;
            this.lblMultiply.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiply.Location = new System.Drawing.Point(12, 184);
            this.lblMultiply.Name = "lblMultiply";
            this.lblMultiply.Size = new System.Drawing.Size(532, 25);
            this.lblMultiply.TabIndex = 1;
            this.lblMultiply.Text = "Multiply the following numbers together:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStart.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(262, 121);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(98, 43);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(353, 74);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 26);
            this.txtNumber.TabIndex = 3;
            // 
            // lstNumbers
            // 
            this.lstNumbers.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lstNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 20;
            this.lstNumbers.Location = new System.Drawing.Point(91, 230);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(206, 144);
            this.lstNumbers.TabIndex = 4;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(88, 431);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(66, 24);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "label1";
            // 
            // FactoialDWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(701, 498);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lstNumbers);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblMultiply);
            this.Controls.Add(this.lblNumber);
            this.Name = "FactoialDWForm";
            this.Text = "FactorialDoWhile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblMultiply;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.Label lblAnswer;
    }
}

