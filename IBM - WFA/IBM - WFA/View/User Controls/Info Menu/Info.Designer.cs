namespace IBM___WFA.View.User_Controls.Info_Menu
{
    partial class Info
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            label1 = new Label();
            comboBox1 = new ComboBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(371, 41);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 23;
            label1.Text = "Order By";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Control;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "IdMarshrut", "IdFirma" });
            comboBox1.Location = new Point(474, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 31);
            comboBox1.TabIndex = 22;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(755, 29);
            button5.Name = "button5";
            button5.Size = new Size(52, 45);
            button5.TabIndex = 21;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Lime;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(704, 29);
            button4.Name = "button4";
            button4.Size = new Size(52, 45);
            button4.TabIndex = 20;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Aqua;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(600, 439);
            button3.Name = "button3";
            button3.Size = new Size(173, 77);
            button3.TabIndex = 19;
            button3.Text = "    Update";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(353, 439);
            button2.Name = "button2";
            button2.Size = new Size(173, 77);
            button2.TabIndex = 18;
            button2.Text = "    Delete";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(106, 439);
            button1.Name = "button1";
            button1.Size = new Size(173, 77);
            button1.TabIndex = 17;
            button1.Text = "    Add";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(78, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(729, 297);
            dataGridView1.TabIndex = 16;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Info";
            Size = new Size(903, 603);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}
