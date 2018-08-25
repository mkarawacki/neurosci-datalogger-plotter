namespace ArduinoPlotterDataLogger_WinForms
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BaudRateCB = new System.Windows.Forms.ComboBox();
            this.COMPortsCB = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Wykres = new LiveCharts.WinForms.CartesianChart();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ArduinoOutputDbg = new System.Windows.Forms.RichTextBox();
            this.ParametricPlotToggle = new MetroFramework.Controls.MetroToggle();
            this.DataColumnsSelect = new System.Windows.Forms.CheckedListBox();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ArduConnStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaudRateCB
            // 
            this.BaudRateCB.FormattingEnabled = true;
            this.BaudRateCB.Location = new System.Drawing.Point(21, 50);
            this.BaudRateCB.Name = "BaudRateCB";
            this.BaudRateCB.Size = new System.Drawing.Size(121, 21);
            this.BaudRateCB.TabIndex = 2;
            this.BaudRateCB.SelectedIndexChanged += new System.EventHandler(this.BaudRateCB_SelectedIndexChanged);
            // 
            // COMPortsCB
            // 
            this.COMPortsCB.FormattingEnabled = true;
            this.COMPortsCB.Location = new System.Drawing.Point(21, 23);
            this.COMPortsCB.Name = "COMPortsCB";
            this.COMPortsCB.Size = new System.Drawing.Size(151, 21);
            this.COMPortsCB.TabIndex = 3;
            this.COMPortsCB.SelectedIndexChanged += new System.EventHandler(this.COMPortsCB_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Wykres);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1133, 649);
            this.splitContainer1.SplitterDistance = 451;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // Wykres
            // 
            this.Wykres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wykres.Location = new System.Drawing.Point(0, 0);
            this.Wykres.Name = "Wykres";
            this.Wykres.Size = new System.Drawing.Size(1133, 451);
            this.Wykres.TabIndex = 0;
            this.Wykres.Text = "cartesianChart1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ArduinoOutputDbg);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.ParametricPlotToggle);
            this.splitContainer2.Panel2.Controls.Add(this.DataColumnsSelect);
            this.splitContainer2.Panel2.Controls.Add(this.ConnectBtn);
            this.splitContainer2.Panel2.Controls.Add(this.COMPortsCB);
            this.splitContainer2.Panel2.Controls.Add(this.BaudRateCB);
            this.splitContainer2.Size = new System.Drawing.Size(1133, 194);
            this.splitContainer2.SplitterDistance = 659;
            this.splitContainer2.TabIndex = 6;
            // 
            // ArduinoOutputDbg
            // 
            this.ArduinoOutputDbg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArduinoOutputDbg.Location = new System.Drawing.Point(0, 0);
            this.ArduinoOutputDbg.Name = "ArduinoOutputDbg";
            this.ArduinoOutputDbg.ReadOnly = true;
            this.ArduinoOutputDbg.Size = new System.Drawing.Size(659, 194);
            this.ArduinoOutputDbg.TabIndex = 5;
            this.ArduinoOutputDbg.Text = "";
            this.ArduinoOutputDbg.TextChanged += new System.EventHandler(this.ArduinoOutputDbg_TextChanged);
            // 
            // ParametricPlotToggle
            // 
            this.ParametricPlotToggle.AutoSize = true;
            this.ParametricPlotToggle.DisplayStatus = false;
            this.ParametricPlotToggle.Location = new System.Drawing.Point(155, 163);
            this.ParametricPlotToggle.Name = "ParametricPlotToggle";
            this.ParametricPlotToggle.Size = new System.Drawing.Size(50, 17);
            this.ParametricPlotToggle.Style = MetroFramework.MetroColorStyle.Green;
            this.ParametricPlotToggle.TabIndex = 7;
            this.ParametricPlotToggle.Text = "Off";
            this.ParametricPlotToggle.ThreeState = true;
            this.ParametricPlotToggle.UseSelectable = true;
            this.ParametricPlotToggle.CheckedChanged += new System.EventHandler(this.ParametricPlotToggle_CheckedChanged);
            // 
            // DataColumnsSelect
            // 
            this.DataColumnsSelect.CheckOnClick = true;
            this.DataColumnsSelect.Dock = System.Windows.Forms.DockStyle.Right;
            this.DataColumnsSelect.FormattingEnabled = true;
            this.DataColumnsSelect.Items.AddRange(new object[] {
            "a_x",
            "a_y",
            "a_z",
            "w_x",
            "w_y",
            "w_z"});
            this.DataColumnsSelect.Location = new System.Drawing.Point(241, 0);
            this.DataColumnsSelect.Name = "DataColumnsSelect";
            this.DataColumnsSelect.Size = new System.Drawing.Size(229, 194);
            this.DataColumnsSelect.TabIndex = 5;
            this.DataColumnsSelect.SelectedIndexChanged += new System.EventHandler(this.DataColumnsSelect_SelectedIndexChanged);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(21, 89);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 4;
            this.ConnectBtn.Text = "Połącz";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1133, 649);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1133, 695);
            this.toolStripContainer1.TabIndex = 5;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArduConnStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1133, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // ArduConnStatusLabel
            // 
            this.ArduConnStatusLabel.Name = "ArduConnStatusLabel";
            this.ArduConnStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1133, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zamknijToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 695);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Okno Główne";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox BaudRateCB;
        private System.Windows.Forms.ComboBox COMPortsCB;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.RichTextBox ArduinoOutputDbg;
        private LiveCharts.WinForms.CartesianChart Wykres;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ArduConnStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private MetroFramework.Controls.MetroToggle ParametricPlotToggle;
        private System.Windows.Forms.CheckedListBox DataColumnsSelect;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
    }
}

