using IBM___WFA.Business;
using IBM___WFA.Data.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBM___WFA.User_Controls.Schedule_Menu
{
    public partial class Schedule : UserControl
    {
        private ApplicationBusiness controller = new ApplicationBusiness();
        public Schedule()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

            UpdateGrid();
        }


        //метод за обръщане на редовете в dataGridView
        private void ReverseDataGridView(ref DataGridView dgv)
        {
            int rowCount = dgv.Rows.Count;
            int columnCount = dgv.Columns.Count;

            for (int i = 0; i < rowCount / 2; i++)
            {
                DataGridViewRow topRow = dgv.Rows[i];
                DataGridViewRow bottomRow = dgv.Rows[rowCount - i - 1];

                for (int j = 0; j < columnCount; j++)
                {
                    object temp = topRow.Cells[j].Value;
                    topRow.Cells[j].Value = bottomRow.Cells[j].Value;
                    bottomRow.Cells[j].Value = temp;
                }
            }

        }



        //метод за обновяване на dataGridView
        private void UpdateGrid()
        {

            dataGridView1.DataSource = controller.GetAllSchedules();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SetSizeOfDataGridView();
        }

        //метод за обновяване на dataGridView по град на заминаване
        private void UpdateGridByZaminavaOt()
        {
            dataGridView1.DataSource = controller.SortRazpisaniqByZaminavaOt();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SetSizeOfDataGridView();
        }


        //метод за обновяване на dataGridView по град на пристигане
        private void UpdateGridByPristigaV()
        {
            dataGridView1.DataSource = controller.SortRazpisaniqByPristigaV();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SetSizeOfDataGridView();
        }



        //метод за обновяване на dataGridView по час на заминаване
        private void UpdateGridByChasZaminavane()
        {
            dataGridView1.DataSource = controller.SortRazpisaniqByChasZaminavane();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SetSizeOfDataGridView();
        }



        //метод за обновяване на dataGridView по час на пристигане
        private void UpdateGridByChasPristigane()
        {
            dataGridView1.DataSource = controller.SortRazpisaniqByChasPristigane();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SetSizeOfDataGridView();
        }



        //метод за задаване на размерите на всяка колона в dataGridView
        private void SetSizeOfDataGridView()
        {
            dataGridView1.Columns[0].Width = dataGridView1.Width / 5 - 14;
            dataGridView1.Columns[1].Width = dataGridView1.Width / 5 - 14;
            dataGridView1.Columns[2].Width = dataGridView1.Width / 5 - 14;
            dataGridView1.Columns[3].Width = dataGridView1.Width / 5 - 14;
            dataGridView1.Columns[4].Width = dataGridView1.Width / 5 - 14;
        }



        //метод, който проверява каква опция за сортиране е избрал потребителя
        private OptionsForSorting CheckOptionForSorting()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    return OptionsForSorting.ZaminavaOt;
                case 1:
                    return OptionsForSorting.PristigaV;
                case 2:
                    return OptionsForSorting.ChasPristigane;
                default:
                    return OptionsForSorting.ChasZaminavane;
            }
        }

        //бутон за добавяне на разписание
        private void button1_Click(object sender, EventArgs e)
        {
            string Start_From = Interaction.InputBox("Enter from where does it stars");

            if (Start_From != null && Start_From != "")
            {
                string End_In = Interaction.InputBox("Enter where does it ends");

                if (End_In != null && End_In != "")
                {
                    string input1 = Interaction.InputBox("Enter when does it starts");

                    TimeOnly Hour_Start = TimeOnly.Parse("00:00:00");
                    if (TimeOnly.TryParse(input1!, out Hour_Start))
                    {
                        string input2 = Interaction.InputBox("Enter when does it ends");

                        TimeOnly Hour_End = TimeOnly.Parse("00:00:00");
                        if (TimeOnly.TryParse(input2!, out Hour_End))
                        {
                            Razpisaniq Razpisanie = new Razpisaniq();

                            Razpisanie.ZaminavaOt = Start_From;
                            Razpisanie.PristigaV = End_In;
                            Razpisanie.ChasZaminavane = Hour_Start;
                            Razpisanie.ChasPristigane = Hour_End;

                            if (controller.Schedule_Exist(Razpisanie))
                            {
                                MessageBox.Show("The schedule already exist");
                            }
                            else
                            {
                                controller.AddSchedule(Razpisanie);
                                MessageBox.Show("The schedule is added successfully");
                                UpdateGrid();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Wrong input!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong input!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Input!");
            }
        }




        //бутон за изтриване на разписание
        private void button2_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Enter id of schedule");

            int id = -1;
            if (int.TryParse(input, out id))
            {
                if (controller.Schedule_Exist(id))
                {
                    controller.DeleteSchedule(id);
                    MessageBox.Show("The schedule was deleted successfully");
                    UpdateGrid();
                }
                else
                {
                    MessageBox.Show("The schedule does not exist");
                }
            }
            else
            {
                MessageBox.Show("Wrong input!");
            }
        }



        //бутон за ъпдейтване на разписание
        private void button3_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Enter id");

            int id = -1;
            if (int.TryParse(input, out id))
            {
                if (controller.Schedule_Exist(id))
                {
                    string Start_From = Interaction.InputBox("Enter from where does it stars");

                    if (Start_From != null && Start_From != "")
                    {
                        string End_In = Interaction.InputBox("Enter where does it ends");

                        if (End_In != null && End_In != "")
                        {
                            string input1 = Interaction.InputBox("Enter when does it starts");

                            TimeOnly Hour_Start = TimeOnly.Parse("00:00:00");
                            if (TimeOnly.TryParse(input1!, out Hour_Start))
                            {
                                string input2 = Interaction.InputBox("Enter when does it ends");

                                TimeOnly Hour_End = TimeOnly.Parse("00:00:00");
                                if (TimeOnly.TryParse(input2!, out Hour_End))
                                {
                                    Razpisaniq Razpisanie = new Razpisaniq();

                                    Razpisanie.IdMarshrut = id;
                                    Razpisanie.ZaminavaOt = Start_From;
                                    Razpisanie.PristigaV = End_In;
                                    Razpisanie.ChasZaminavane = Hour_Start;
                                    Razpisanie.ChasPristigane = Hour_End;

                                    controller.UpdateSchedule(Razpisanie);
                                    MessageBox.Show("The schedule is updated successfully");
                                    UpdateGrid();
                                }
                                else
                                {
                                    MessageBox.Show("Wrong input!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Wrong input!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid Input!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Input!");
                    }
                }
                else
                {
                    MessageBox.Show("There is no schedule with this id");
                }
            }
            else
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //бутон за сортиране възходящо
        private void button4_Click(object sender, EventArgs e)
        {
            switch (CheckOptionForSorting())
            {
                case OptionsForSorting.ZaminavaOt:
                    UpdateGridByZaminavaOt();
                    break;

                case OptionsForSorting.PristigaV:
                    UpdateGridByPristigaV();
                    break;

                case OptionsForSorting.ChasPristigane:
                    UpdateGridByChasPristigane();
                    break;

                case OptionsForSorting.ChasZaminavane:
                    UpdateGridByChasZaminavane();
                    break;
            }
        }



        //бутон за сортиране низходящо
        private void button5_Click(object sender, EventArgs e)
        {
            switch (CheckOptionForSorting())
            {
                case OptionsForSorting.ZaminavaOt:
                    UpdateGridByZaminavaOt();
                    ReverseDataGridView(ref dataGridView1);
                    break;

                case OptionsForSorting.PristigaV:
                    UpdateGridByPristigaV();
                    ReverseDataGridView(ref dataGridView1);
                    break;

                case OptionsForSorting.ChasPristigane:
                    UpdateGridByChasPristigane();
                    ReverseDataGridView(ref dataGridView1);
                    break;

                case OptionsForSorting.ChasZaminavane:
                    UpdateGridByChasZaminavane();
                    ReverseDataGridView(ref dataGridView1);
                    break;
            }
        }


        //списък от възможни опции за сортиране
        enum OptionsForSorting
        {
            ZaminavaOt,
            PristigaV,
            ChasZaminavane,
            ChasPristigane,
        }
    }
}
