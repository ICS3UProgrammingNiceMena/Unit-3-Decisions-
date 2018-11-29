namespace ForEachNiceM
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
            this.btnClick = new System.Windows.Forms.Button();
            this.lblPlease = new System.Windows.Forms.Label();
            this.chkYes = new System.Windows.Forms.CheckBox();
            this.chkNo = new System.Windows.Forms.CheckBox();
            this.lblPlease3 = new System.Windows.Forms.Label();
            this.lblPlease2 = new System.Windows.Forms.Label();
            this.lblPlease4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(378, 202);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(126, 40);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click Me";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblPlease
            // 
            this.lblPlease.AutoSize = true;
            this.lblPlease.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlease.Location = new System.Drawing.Point(272, 91);
            this.lblPlease.Name = "lblPlease";
            this.lblPlease.Size = new System.Drawing.Size(84, 25);
            this.lblPlease.TabIndex = 1;
            this.lblPlease.Text = "Please";
            // 
            // chkYes
            // 
            this.chkYes.AutoSize = true;
            this.chkYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYes.Location = new System.Drawing.Point(219, 257);
            this.chkYes.Name = "chkYes";
            this.chkYes.Size = new System.Drawing.Size(192, 29);
            this.chkYes.TabIndex = 2;
            this.chkYes.Text = "Already clicked";
            this.chkYes.UseVisualStyleBackColor = true;
            // 
            // chkNo
            // 
            this.chkNo.AutoSize = true;
            this.chkNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNo.Location = new System.Drawing.Point(473, 257);
            this.chkNo.Name = "chkNo";
            this.chkNo.Size = new System.Drawing.Size(230, 29);
            this.chkNo.TabIndex = 3;
            this.chkNo.Text = "Haven\'t clicked yet";
            this.chkNo.UseVisualStyleBackColor = true;
            // 
            // lblPlease3
            // 
            this.lblPlease3.AutoSize = true;
            this.lblPlease3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlease3.Location = new System.Drawing.Point(373, 136);
            this.lblPlease3.Name = "lblPlease3";
            this.lblPlease3.Size = new System.Drawing.Size(84, 25);
            this.lblPlease3.TabIndex = 4;
            this.lblPlease3.Text = "Please";
            this.lblPlease3.Click += new System.EventHandler(this.lblPlease3_Click);
            // 
            // lblPlease2
            // 
            this.lblPlease2.AutoSize = true;
            this.lblPlease2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlease2.Location = new System.Drawing.Point(468, 108);
            this.lblPlease2.Name = "lblPlease2";
            this.lblPlease2.Size = new System.Drawing.Size(84, 25);
            this.lblPlease2.TabIndex = 5;
            this.lblPlease2.Text = "Please";
            // 
            // lblPlease4
            // 
            this.lblPlease4.AutoSize = true;
            this.lblPlease4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlease4.Location = new System.Drawing.Point(373, 69);
            this.lblPlease4.Name = "lblPlease4";
            this.lblPlease4.Size = new System.Drawing.Size(84, 25);
            this.lblPlease4.TabIndex = 6;
            this.lblPlease4.Text = "Please";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 600);
            this.Controls.Add(this.lblPlease4);
            this.Controls.Add(this.lblPlease2);
            this.Controls.Add(this.lblPlease3);
            this.Controls.Add(this.chkNo);
            this.Controls.Add(this.chkYes);
            this.Controls.Add(this.lblPlease);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblPlease;
        private System.Windows.Forms.CheckBox chkYes;
        private System.Windows.Forms.CheckBox chkNo;
        private System.Windows.Forms.Label lblPlease3;
        private System.Windows.Forms.Label lblPlease2;
        private System.Windows.Forms.Label lblPlease4;
    }
}

