namespace ArduinoPlotterDataLogger_WinForms
{
    partial class BasicLineExample
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
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.COMPortsCB = new System.Windows.Forms.ComboBox();
            this.BaudRateCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(325, 247);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 7;
            this.ConnectBtn.Text = "Połącz";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // COMPortsCB
            // 
            this.COMPortsCB.FormattingEnabled = true;
            this.COMPortsCB.Location = new System.Drawing.Point(325, 181);
            this.COMPortsCB.Name = "COMPortsCB";
            this.COMPortsCB.Size = new System.Drawing.Size(151, 21);
            this.COMPortsCB.TabIndex = 6;
            // 
            // BaudRateCB
            // 
            this.BaudRateCB.FormattingEnabled = true;
            this.BaudRateCB.Location = new System.Drawing.Point(325, 208);
            this.BaudRateCB.Name = "BaudRateCB";
            this.BaudRateCB.Size = new System.Drawing.Size(121, 21);
            this.BaudRateCB.TabIndex = 5;
            // 
            // BasicLineExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.COMPortsCB);
            this.Controls.Add(this.BaudRateCB);
            this.Name = "BasicLineExample";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.BasicLineExample_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.ComboBox COMPortsCB;
        private System.Windows.Forms.ComboBox BaudRateCB;
    }
}