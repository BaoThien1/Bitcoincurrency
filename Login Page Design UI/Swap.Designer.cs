namespace Login_Page_Design_UI
{
    partial class Swap
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.FromCurrencyBox = new System.Windows.Forms.ComboBox();
            this.ToCurrencyBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountToConvertBox = new System.Windows.Forms.TextBox();
            this.ConvertedAmountDisplay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RateDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(31, 15);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(305, 155);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Swap";
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Black;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(146, 323);
            this.guna2CircleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.PressedColor = System.Drawing.Color.Blue;
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(155, 138);
            this.guna2CircleButton1.TabIndex = 6;
            this.guna2CircleButton1.Text = "Exchange";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(499, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "From currency";
            // 
            // FromCurrencyBox
            // 
            this.FromCurrencyBox.FormattingEnabled = true;
            this.FromCurrencyBox.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP"});
            this.FromCurrencyBox.Location = new System.Drawing.Point(504, 370);
            this.FromCurrencyBox.Name = "FromCurrencyBox";
            this.FromCurrencyBox.Size = new System.Drawing.Size(173, 24);
            this.FromCurrencyBox.TabIndex = 8;
            // 
            // ToCurrencyBox
            // 
            this.ToCurrencyBox.FormattingEnabled = true;
            this.ToCurrencyBox.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "BitCoin"});
            this.ToCurrencyBox.Location = new System.Drawing.Point(504, 468);
            this.ToCurrencyBox.Name = "ToCurrencyBox";
            this.ToCurrencyBox.Size = new System.Drawing.Size(178, 24);
            this.ToCurrencyBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(499, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "To currency";
            // 
            // AmountToConvertBox
            // 
            this.AmountToConvertBox.Location = new System.Drawing.Point(504, 279);
            this.AmountToConvertBox.Name = "AmountToConvertBox";
            this.AmountToConvertBox.Size = new System.Drawing.Size(173, 22);
            this.AmountToConvertBox.TabIndex = 12;
            // 
            // ConvertedAmountDisplay
            // 
            this.ConvertedAmountDisplay.AutoSize = true;
            this.ConvertedAmountDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ConvertedAmountDisplay.Location = new System.Drawing.Point(499, 173);
            this.ConvertedAmountDisplay.Name = "ConvertedAmountDisplay";
            this.ConvertedAmountDisplay.Size = new System.Drawing.Size(238, 25);
            this.ConvertedAmountDisplay.TabIndex = 13;
            this.ConvertedAmountDisplay.Text = "Converted amount: ???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(499, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Amount to convert";
            // 
            // RateDisplay
            // 
            this.RateDisplay.AutoSize = true;
            this.RateDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.RateDisplay.Location = new System.Drawing.Point(499, 124);
            this.RateDisplay.Name = "RateDisplay";
            this.RateDisplay.Size = new System.Drawing.Size(257, 25);
            this.RateDisplay.TabIndex = 15;
            this.RateDisplay.Text = "Conversion Rate 1$ =???";
            // 
            // Swap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 780);
            this.Controls.Add(this.RateDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConvertedAmountDisplay);
            this.Controls.Add(this.AmountToConvertBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ToCurrencyBox);
            this.Controls.Add(this.FromCurrencyBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Swap";
            this.Text = "Swap";
            this.Load += new System.EventHandler(this.Swap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FromCurrencyBox;
        private System.Windows.Forms.ComboBox ToCurrencyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AmountToConvertBox;
        private System.Windows.Forms.Label ConvertedAmountDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label RateDisplay;
    }
}