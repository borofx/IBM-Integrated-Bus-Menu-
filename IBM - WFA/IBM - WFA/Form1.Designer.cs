namespace IBM___WFA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TabsPanel = new Panel();
            TopPanel = new Panel();
            panel3 = new Panel();
            MainPanel = new Panel();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TabsPanel
            // 
            TabsPanel.BackColor = SystemColors.WindowFrame;
            TabsPanel.Location = new Point(0, 0);
            TabsPanel.Name = "TabsPanel";
            TabsPanel.Size = new Size(241, 631);
            TabsPanel.TabIndex = 0;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = SystemColors.WindowFrame;
            TopPanel.Controls.Add(panel3);
            TopPanel.Location = new Point(241, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(903, 47);
            TopPanel.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.WindowFrame;
            panel3.Location = new Point(83, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(181, 221);
            panel3.TabIndex = 2;
            // 
            // MainPanel
            // 
            MainPanel.Location = new Point(241, 28);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(903, 603);
            MainPanel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 631);
            Controls.Add(MainPanel);
            Controls.Add(TopPanel);
            Controls.Add(TabsPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            TopPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TabsPanel;
        private Panel TopPanel;
        private Panel panel3;
        private Panel MainPanel;
    }
}
