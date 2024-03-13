namespace IBM___WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Home home = new Home();
            SetActiveUserControl(home);
        }


        //method for visualization the current menu
        private void SetActiveUserControl(UserControl userControl)
        {
            MainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(userControl);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
