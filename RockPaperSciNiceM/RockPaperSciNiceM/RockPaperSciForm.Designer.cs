namespace RockPaperSciNiceM
{
    partial class RockPaperSciForm
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
            this.radRockComp = new System.Windows.Forms.RadioButton();
            this.radScissorsComp = new System.Windows.Forms.RadioButton();
            this.radPaperComp = new System.Windows.Forms.RadioButton();
            this.radRockUser = new System.Windows.Forms.RadioButton();
            this.radPaperUser = new System.Windows.Forms.RadioButton();
            this.radScissorsUser = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radRockComp
            // 
            this.radRockComp.AutoSize = true;
            this.radRockComp.Image = global::RockPaperSciNiceM.Properties.Resources.rock__left2222;
            this.radRockComp.Location = new System.Drawing.Point(455, 82);
            this.radRockComp.Name = "radRockComp";
            this.radRockComp.Size = new System.Drawing.Size(134, 118);
            this.radRockComp.TabIndex = 3;
            this.radRockComp.TabStop = true;
            this.radRockComp.UseVisualStyleBackColor = true;
            // 
            // radScissorsComp
            // 
            this.radScissorsComp.AutoSize = true;
            this.radScissorsComp.Image = global::RockPaperSciNiceM.Properties.Resources.scissors__left1;
            this.radScissorsComp.Location = new System.Drawing.Point(455, 197);
            this.radScissorsComp.Name = "radScissorsComp";
            this.radScissorsComp.Size = new System.Drawing.Size(134, 118);
            this.radScissorsComp.TabIndex = 4;
            this.radScissorsComp.TabStop = true;
            this.radScissorsComp.UseVisualStyleBackColor = true;
            // 
            // radPaperComp
            // 
            this.radPaperComp.AutoSize = true;
            this.radPaperComp.Image = global::RockPaperSciNiceM.Properties.Resources.paper__left1;
            this.radPaperComp.Location = new System.Drawing.Point(455, 342);
            this.radPaperComp.Name = "radPaperComp";
            this.radPaperComp.Size = new System.Drawing.Size(134, 118);
            this.radPaperComp.TabIndex = 5;
            this.radPaperComp.TabStop = true;
            this.radPaperComp.UseVisualStyleBackColor = true;
            // 
            // radRockUser
            // 
            this.radRockUser.AutoSize = true;
            this.radRockUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRockUser.Image = global::RockPaperSciNiceM.Properties.Resources.rock__left2222;
            this.radRockUser.Location = new System.Drawing.Point(75, 88);
            this.radRockUser.Name = "radRockUser";
            this.radRockUser.Size = new System.Drawing.Size(134, 118);
            this.radRockUser.TabIndex = 6;
            this.radRockUser.TabStop = true;
            this.radRockUser.UseVisualStyleBackColor = true;
            // 
            // radPaperUser
            // 
            this.radPaperUser.AutoSize = true;
            this.radPaperUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPaperUser.Image = global::RockPaperSciNiceM.Properties.Resources.paper__left1;
            this.radPaperUser.Location = new System.Drawing.Point(75, 336);
            this.radPaperUser.Name = "radPaperUser";
            this.radPaperUser.Size = new System.Drawing.Size(134, 118);
            this.radPaperUser.TabIndex = 2;
            this.radPaperUser.TabStop = true;
            this.radPaperUser.UseVisualStyleBackColor = true;
            // 
            // radScissorsUser
            // 
            this.radScissorsUser.AutoSize = true;
            this.radScissorsUser.Image = global::RockPaperSciNiceM.Properties.Resources.scissors__left1;
            this.radScissorsUser.Location = new System.Drawing.Point(75, 212);
            this.radScissorsUser.Name = "radScissorsUser";
            this.radScissorsUser.Size = new System.Drawing.Size(134, 118);
            this.radScissorsUser.TabIndex = 1;
            this.radScissorsUser.TabStop = true;
            this.radScissorsUser.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monospac821 BT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(187, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(372, 35);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Rock, Paper, Scissors";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Nueva Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(279, 132);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(119, 40);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // RockPaperSciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 524);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.radRockUser);
            this.Controls.Add(this.radPaperComp);
            this.Controls.Add(this.radScissorsComp);
            this.Controls.Add(this.radRockComp);
            this.Controls.Add(this.radPaperUser);
            this.Controls.Add(this.radScissorsUser);
            this.Name = "RockPaperSciForm";
            this.Text = "frnRockPaperSci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radScissorsUser;
        private System.Windows.Forms.RadioButton radPaperUser;
        private System.Windows.Forms.RadioButton radRockComp;
        private System.Windows.Forms.RadioButton radScissorsComp;
        private System.Windows.Forms.RadioButton radPaperComp;
        private System.Windows.Forms.RadioButton radRockUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPlay;
    }
}

