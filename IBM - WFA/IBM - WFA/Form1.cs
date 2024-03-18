using IBM___WFA.User_Controls.Companies_Menu;
using IBM___WFA.User_Controls.Schedule_Menu;
using IBM___WFA.View.User_Controls.Info_Menu;

namespace IBM___WFA
{
    public partial class Form1 : Form
    {
        private Home home = new Home();
        private Companies companies = new Companies();
        private Schedule schedule = new Schedule();
        private Info info= new Info();

        public Form1()
        {
            InitializeComponent();

            SetActiveUserControl(home);
            SetSidePanelPostition(button4);
        }


        //метод за визуализиране на текущото меню
        private void SetActiveUserControl(UserControl userControl)
        {
            MainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(userControl);
        }

        //метод за задаване на позицията на страничното меню
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
            SetActiveUserControl(schedule);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetSidePanelPostition(button2);
            SetActiveUserControl(companies);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetSidePanelPostition(button4);
            SetActiveUserControl(home);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetSidePanelPostition(button5);
            SetActiveUserControl(info);
        }
    }
}
