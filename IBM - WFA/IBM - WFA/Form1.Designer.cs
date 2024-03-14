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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TabsPanel = new Panel();
            button4 = new Button();
            button3 = new Button();
            SidePanel = new Panel();
            button2 = new Button();
            TopPanel = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            MainPanel = new Panel();
            TabsPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TabsPanel
            // 
            TabsPanel.BackColor = SystemColors.WindowFrame;
            TabsPanel.Controls.Add(button4);
            TabsPanel.Controls.Add(button3);
            TabsPanel.Controls.Add(SidePanel);
            TabsPanel.Controls.Add(button2);
            TabsPanel.Location = new Point(0, 0);
            TabsPanel.Name = "TabsPanel";
            TabsPanel.Size = new Size(241, 631);
            TabsPanel.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.WindowFrame;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(12, 107);
            button4.Name = "button4";
            button4.Size = new Size(227, 61);
            button4.TabIndex = 1;
            button4.Text = "     Home";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.WindowFrame;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(12, 239);
            button3.Name = "button3";
            button3.Size = new Size(227, 61);
            button3.TabIndex = 1;
            button3.Text = "     Schedule";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = SystemColors.Control;
            SidePanel.Location = new Point(0, 108);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(13, 61);
            SidePanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.WindowFrame;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(12, 173);
            button2.Name = "button2";
            button2.Size = new Size(227, 61);
            button2.TabIndex = 0;
            button2.Text = "     Companies";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = SystemColors.WindowFrame;
            TopPanel.Controls.Add(button1);
            TopPanel.Controls.Add(panel3);
            TopPanel.Location = new Point(241, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(903, 47);
            TopPanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.WindowFrame;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(869, 0);
            button1.Name = "button1";
            button1.Size = new Size(31, 28);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            TabsPanel.ResumeLayout(false);
            TopPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TabsPanel;
        private Panel TopPanel;
        private Panel panel3;
        private Panel MainPanel;
        private Button button1;
        private Button button2;
        private Panel SidePanel;
        private Button button3;
        private Button button4;
    }
}
