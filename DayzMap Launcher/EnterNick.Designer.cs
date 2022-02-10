namespace DayzMap_Launcher
{
    partial class EnterNick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterNick));
            this.label1 = new System.Windows.Forms.Label();
            this.MyNick = new System.Windows.Forms.TextBox();
            this.BtnStart = new BtnNEw.DayzMapButtonVersion2();
            this.BtnEnd = new BtnNEw.DayzMapButtonVersion2();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gotham Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введтие ваш ник";
            // 
            // MyNick
            // 
            this.MyNick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MyNick.Font = new System.Drawing.Font("Gotham Pro", 36F, System.Drawing.FontStyle.Bold);
            this.MyNick.Location = new System.Drawing.Point(26, 83);
            this.MyNick.Name = "MyNick";
            this.MyNick.Size = new System.Drawing.Size(430, 55);
            this.MyNick.TabIndex = 1;
            this.MyNick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MyNick_KeyPress);
            // 
            // BtnStart
            // 
            this.BtnStart.AnimationInterval = 1;
            this.BtnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(211)))));
            this.BtnStart.BackgroundSpeed = 40;
            this.BtnStart.BackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.CustomButtonText = "Применить";
            this.BtnStart.FlatAppearance.BorderSize = 0;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("Gotham Pro Light", 15.75F);
            this.BtnStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnStart.Location = new System.Drawing.Point(26, 151);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(210, 51);
            this.BtnStart.SmoothCorrectionFactor = 1.5D;
            this.BtnStart.TabIndex = 17;
            this.BtnStart.TextHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnStart.UseSmoothSpeedIncrement = true;
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnEnd
            // 
            this.BtnEnd.AnimationInterval = 1;
            this.BtnEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(211)))));
            this.BtnEnd.BackgroundSpeed = 40;
            this.BtnEnd.BackHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(184)))), ((int)(((byte)(241)))));
            this.BtnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnd.CustomButtonText = "Отмена";
            this.BtnEnd.FlatAppearance.BorderSize = 0;
            this.BtnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnd.Font = new System.Drawing.Font("Gotham Pro Light", 15.75F);
            this.BtnEnd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEnd.Location = new System.Drawing.Point(246, 151);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(210, 51);
            this.BtnEnd.SmoothCorrectionFactor = 1.5D;
            this.BtnEnd.TabIndex = 18;
            this.BtnEnd.TextHoverColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEnd.UseSmoothSpeedIncrement = true;
            this.BtnEnd.UseVisualStyleBackColor = false;
            this.BtnEnd.Click += new System.EventHandler(this.BtnEnd_Click);
            // 
            // EnterNick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DayzMap_Launcher.Properties.Resources.NickPLS;
            this.ClientSize = new System.Drawing.Size(482, 223);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.MyNick);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnterNick";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nick";
            this.Load += new System.EventHandler(this.EnterNick_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MyNick;
        private BtnNEw.DayzMapButtonVersion2 BtnStart;
        private BtnNEw.DayzMapButtonVersion2 BtnEnd;
    }
}