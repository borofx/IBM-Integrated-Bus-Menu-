namespace IBM___WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Home home = new Home();
            SetActiveUserControl(home);
            SetSidePanelPostition(button4);
        }


        //method for visualization the current menu
        private void SetActiveUserControl(UserControl userControl)
        {
            MainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(userControl);
        }


        private void SetSidePanelPostition(Button button)
        {
            SidePanel.Height = button.Height;
            SidePanel.Top = button.Top;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetSidePanelPostition(button3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetSidePanelPostition(button2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetSidePanelPostition(button4);
        }
    }
}
