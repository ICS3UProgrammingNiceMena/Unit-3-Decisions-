namespace ChocolateBoxesNiceM
{
    partial class ChocolateBoxesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChocolateBoxesForm));
            this.lblNumBoxes = new System.Windows.Forms.Label();
            this.lblReward = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReward = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumBoxes
            // 
            this.lblNumBoxes.AutoSize = true;
            this.lblNumBoxes.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBoxes.Location = new System.Drawing.Point(26, 98);
            this.lblNumBoxes.Name = "lblNumBoxes";
            this.lblNumBoxes.Size = new System.Drawing.Size(336, 28);
            this.lblNumBoxes.TabIndex = 0;
            this.lblNumBoxes.Text = "Enter the nume of sold boxes";
            // 
            // lblReward
            // 
            this.lblReward.AutoSize = true;
            this.lblReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReward.Location = new System.Drawing.Point(102, 222);
            this.lblReward.Name = "lblReward";
            this.lblReward.Size = new System.Drawing.Size(0, 25);
            this.lblReward.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // btnReward
            // 
            this.btnReward.BackColor = System.Drawing.Color.Chocolate;
            this.btnReward.Font = new System.Drawing.Font("Swis721 Blk BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReward.Location = new System.Drawing.Point(237, 149);
            this.btnReward.Name = "btnReward";
            this.btnReward.Size = new System.Drawing.Size(234, 40);
            this.btnReward.TabIndex = 3;
            this.btnReward.Text = "Get Reward";
            this.btnReward.UseVisualStyleBackColor = false;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(371, 106);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 4;
            this.txtNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ChocolateBoxesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(564, 382);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnReward);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblReward);
            this.Controls.Add(this.lblNumBoxes);
            this.Name = "ChocolateBoxesForm";
            this.Text = "ChocolateBoxes";
            this.Load += new System.EventHandler(this.ChocolateBoxesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumBoxes;
        private System.Windows.Forms.Label lblReward;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReward;
        private System.Windows.Forms.TextBox txtNumber;
    }
}

