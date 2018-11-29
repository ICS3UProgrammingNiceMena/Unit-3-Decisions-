namespace PassByRefNiceM
{
    partial class frmPassByValue
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtCelcius = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(22, 133);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(331, 28);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter the temperature in celcius:";
            // 
            // txtCelcius
            // 
            this.txtCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelcius.Location = new System.Drawing.Point(253, 176);
            this.txtCelcius.Name = "txtCelcius";
            this.txtCelcius.Size = new System.Drawing.Size(100, 26);
            this.txtCelcius.TabIndex = 3;
            this.txtCelcius.TextChanged += new System.EventHandler(this.txtCelcius_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(98, 230);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(156, 78);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert to Farenheit";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // frmPassByValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PassByRefNiceM.Properties.Resources.Color_Temperature;
            this.ClientSize = new System.Drawing.Size(629, 507);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtCelcius);
            this.Controls.Add(this.lblEnter);
            this.Name = "frmPassByValue";
            this.Text = "PassByValue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtCelcius;
        private System.Windows.Forms.Button btnConvert;
    }
}

