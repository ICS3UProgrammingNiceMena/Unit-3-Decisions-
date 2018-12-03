namespace RunningAverageNiceM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEnter = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.BackColor = System.Drawing.Color.Turquoise;
            this.lblEnter.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(50, 53);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(422, 25);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter your mark (number from 1-100)";
  
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Turquoise;
            this.btnCalculate.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(121, 218);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(152, 76);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate Average";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // txtMark
            // 
            this.txtMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMark.Location = new System.Drawing.Point(229, 105);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(100, 26);
            this.txtMark.TabIndex = 2;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.BackColor = System.Drawing.Color.Turquoise;
            this.lblAverage.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(52, 316);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(59, 18);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(548, 393);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblEnter);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Label lblAverage;
    }
}

