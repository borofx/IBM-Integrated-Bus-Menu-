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

namespace IBM___WFA.View.User_Controls.Info_Menu
{
    public partial class Info : UserControl
    {
        private ApplicationBusiness controller = new ApplicationBusiness();
        public Info()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            UpdateGrid();
        }



        //метод за задаване на размерите на всяка колона в dataGridView
        private void SetSizeOfDataGridView()
        {
            dataGridView1.Columns[0].Width = dataGridView1.Width / 2 - 38;
            dataGridView1.Columns[1].Width = dataGridView1.Width / 2 - 38;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }



        //метод за ъпдейтване на dataGridView 
        private void UpdateGrid()
        {

            dataGridView1.DataSource = controller.GetAllRazpisaniqFirmis();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SetSizeOfDataGridView();
        }



        //метод за ъпдейтване на dataGridView по id_marshrut
        private void UpdateGridByIdMarshrut()
        {

            dataGridView1.DataSource = controller.OrderRazpisaniqFirmiByIdMarshrut();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SetSizeOfDataGridView();
        }




        //метод за ъпдейтване на dataGridView по id_marshrut
        private void UpdateGridByIdFirma()
        {

            dataGridView1.DataSource = controller.OrderRazpisaniqFirmiByIdFirma();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SetSizeOfDataGridView();
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






        //метод, който проверява каква опция за сортиране е избрал потребителя
        private OptionsForSorting CheckOptionForSorting()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    return OptionsForSorting.IdMarshrut;

                default:
                    return OptionsForSorting.IdFirma;

            }
        }



        //бутон за сортиране възходящо
        private void button4_Click(object sender, EventArgs e)
        {
            switch (CheckOptionForSorting())
            {
                case OptionsForSorting.IdMarshrut:
                    UpdateGridByIdMarshrut();
                    break;

                case OptionsForSorting.IdFirma:
                    UpdateGridByIdFirma();
                    break;
            }
        }




        //бутон за сортиране низходящо
        private void button5_Click(object sender, EventArgs e)
        {
            switch (CheckOptionForSorting())
            {
                case OptionsForSorting.IdMarshrut:
                    UpdateGridByIdMarshrut();
                    ReverseDataGridView(ref dataGridView1);
                    break;


                case OptionsForSorting.IdFirma:
                    UpdateGridByIdFirma();
                    ReverseDataGridView(ref dataGridView1);
                    break;
            }
        }



        //бутон за добавяне на информация за разписание-фирма
        private void button1_Click(object sender, EventArgs e)
        {
            string input_IdMarshrut = Interaction.InputBox("Enter Id_Marshrut");

            int id_marshrut = 0;

            if (int.TryParse(input_IdMarshrut, out id_marshrut))
            {
                if (!controller.RazpisanieFirm_Exist(id_marshrut))
                {
                    if (controller.Schedule_Exist(id_marshrut))
                    {
                        string Input_IdFirma = Interaction.InputBox("Enter Id_Firma");

                        int id_firma = 0;

                        if (int.TryParse(Input_IdFirma, out id_firma))
                        {
                            if (controller.Firm_Exist(id_firma))
                            {
                                RazpisaniqFirmi newRazpisanieFirma = new RazpisaniqFirmi();

                                newRazpisanieFirma.IdMarshrut = id_marshrut;
                                newRazpisanieFirma.IdFirma = id_firma;

                                controller.AddRazpisanieFirm(newRazpisanieFirma);

                                MessageBox.Show("Added successfully");

                                UpdateGrid();
                            }
                            else
                            {
                                MessageBox.Show("The firm does not exist");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid input");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The schedule does not exist");
                    }
                }
                else
                {
                    MessageBox.Show("There is an already existing information for this schedule");
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }




        //бутон за изтриване на информация за разписание-фирма
        private void button2_Click(object sender, EventArgs e)
        {
            string Input_IdMarshrut = Interaction.InputBox("Enter Id_Marshrut");

            int id_marshrut = 0;

            if (int.TryParse(Input_IdMarshrut, out id_marshrut))
            {
                if (controller.RazpisanieFirm_Exist(id_marshrut))
                {
                    controller.DeleteRazpisanieFirma(id_marshrut);
                    MessageBox.Show("Deleted successfully");
                    UpdateGrid();
                }
                else
                {
                    MessageBox.Show("The information for this schedule does not exist");
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }





        //бутон за обновяване на информация за разписание-фирма
        private void button3_Click(object sender, EventArgs e)
        {
            string input_IdMarshrut = Interaction.InputBox("Enter Id_Marshrut");

            int id_marshrut = 0;

            if (int.TryParse(input_IdMarshrut, out id_marshrut))
            {
                if (controller.RazpisanieFirm_Exist(id_marshrut))
                {
                    string Input_IdFirma = Interaction.InputBox("Enter Id_Firma");

                    int id_firma = 0;

                    if (int.TryParse(Input_IdFirma, out id_firma))
                    {
                        if (controller.Firm_Exist(id_firma))
                        {
                            RazpisaniqFirmi newRazpisanieFirma = new RazpisaniqFirmi();

                            newRazpisanieFirma.IdMarshrut = id_marshrut;
                            newRazpisanieFirma.IdFirma = id_firma;

                            controller.UpdateRazpisanieFirma(newRazpisanieFirma);

                            MessageBox.Show("Updated successfully");

                            UpdateGrid();
                        }
                        else
                        {
                            MessageBox.Show("The firm does not exist");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid input");
                    }
                }
                else
                {
                    MessageBox.Show("There is not information for this schedule");
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }
    






        //списък от възможни подреждания
        enum OptionsForSorting
        {
            IdMarshrut,
            IdFirma,

        }
    }
}
