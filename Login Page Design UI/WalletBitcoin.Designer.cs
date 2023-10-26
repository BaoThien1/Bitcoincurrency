namespace Login_Page_Design_UI
{
    partial class WalletBitcoin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateSeed = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.btnPrivatekey = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lbprivatekey = new System.Windows.Forms.Label();
            this.lbprivateaddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbmenmonic = new System.Windows.Forms.Label();
            this.lbaddressmenmonic = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbbalance1 = new System.Windows.Forms.Label();
            this.lbbalance2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(210, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate Address  by  Private Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Private Key";
            // 
            // btnGenerateSeed
            // 
            this.btnGenerateSeed.Animated = true;
            this.btnGenerateSeed.AutoRoundedCorners = true;
            this.btnGenerateSeed.BorderRadius = 21;
            this.btnGenerateSeed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateSeed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerateSeed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateSeed.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerateSeed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerateSeed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnGenerateSeed.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGenerateSeed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerateSeed.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateSeed.Location = new System.Drawing.Point(12, 319);
            this.btnGenerateSeed.Name = "btnGenerateSeed";
            this.btnGenerateSeed.Size = new System.Drawing.Size(180, 45);
            this.btnGenerateSeed.TabIndex = 8;
            this.btnGenerateSeed.Text = "Generate Via Seed Pharse";
            this.btnGenerateSeed.Click += new System.EventHandler(this.btnGenerateSeed_Click);
            // 
            // btnPrivatekey
            // 
            this.btnPrivatekey.Animated = true;
            this.btnPrivatekey.AutoRoundedCorners = true;
            this.btnPrivatekey.BorderRadius = 21;
            this.btnPrivatekey.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrivatekey.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrivatekey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrivatekey.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrivatekey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrivatekey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPrivatekey.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPrivatekey.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrivatekey.ForeColor = System.Drawing.Color.Black;
            this.btnPrivatekey.Location = new System.Drawing.Point(12, 67);
            this.btnPrivatekey.Name = "btnPrivatekey";
            this.btnPrivatekey.Size = new System.Drawing.Size(180, 45);
            this.btnPrivatekey.TabIndex = 9;
            this.btnPrivatekey.Text = "Generate Via Private key";
            this.btnPrivatekey.Click += new System.EventHandler(this.btnPrivatekey_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Address";
            // 
            // lbprivatekey
            // 
            this.lbprivatekey.AutoSize = true;
            this.lbprivatekey.Location = new System.Drawing.Point(179, 146);
            this.lbprivatekey.Name = "lbprivatekey";
            this.lbprivatekey.Size = new System.Drawing.Size(0, 16);
            this.lbprivatekey.TabIndex = 11;
            // 
            // lbprivateaddress
            // 
            this.lbprivateaddress.AutoSize = true;
            this.lbprivateaddress.Location = new System.Drawing.Point(179, 192);
            this.lbprivateaddress.Name = "lbprivateaddress";
            this.lbprivateaddress.Size = new System.Drawing.Size(0, 16);
            this.lbprivateaddress.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(210, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(499, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Generate Address  by  Seed Pharse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Mnemonic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Address";
            // 
            // lbmenmonic
            // 
            this.lbmenmonic.AutoSize = true;
            this.lbmenmonic.Location = new System.Drawing.Point(179, 400);
            this.lbmenmonic.Name = "lbmenmonic";
            this.lbmenmonic.Size = new System.Drawing.Size(0, 16);
            this.lbmenmonic.TabIndex = 16;
            // 
            // lbaddressmenmonic
            // 
            this.lbaddressmenmonic.AutoSize = true;
            this.lbaddressmenmonic.Location = new System.Drawing.Point(179, 448);
            this.lbaddressmenmonic.Name = "lbaddressmenmonic";
            this.lbaddressmenmonic.Size = new System.Drawing.Size(0, 16);
            this.lbaddressmenmonic.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Balance";
            // 
            // lbbalance1
            // 
            this.lbbalance1.AutoSize = true;
            this.lbbalance1.Location = new System.Drawing.Point(179, 237);
            this.lbbalance1.Name = "lbbalance1";
            this.lbbalance1.Size = new System.Drawing.Size(0, 16);
            this.lbbalance1.TabIndex = 21;
            // 
            // lbbalance2
            // 
            this.lbbalance2.AutoSize = true;
            this.lbbalance2.Location = new System.Drawing.Point(179, 488);
            this.lbbalance2.Name = "lbbalance2";
            this.lbbalance2.Size = new System.Drawing.Size(0, 16);
            this.lbbalance2.TabIndex = 22;
            // 
            // WalletBitcoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 536);
            this.Controls.Add(this.lbbalance2);
            this.Controls.Add(this.lbbalance1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbaddressmenmonic);
            this.Controls.Add(this.lbmenmonic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbprivateaddress);
            this.Controls.Add(this.lbprivatekey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrivatekey);
            this.Controls.Add(this.btnGenerateSeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WalletBitcoin";
            this.Text = "WalletBitcoin";
            this.Load += new System.EventHandler(this.WalletBitcoin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnGenerateSeed;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton btnPrivatekey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbprivatekey;
        private System.Windows.Forms.Label lbprivateaddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbmenmonic;
        private System.Windows.Forms.Label lbaddressmenmonic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbbalance1;
        private System.Windows.Forms.Label lbbalance2;
    }
}