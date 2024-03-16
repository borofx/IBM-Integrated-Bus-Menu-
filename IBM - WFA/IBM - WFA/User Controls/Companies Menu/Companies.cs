using IBM___WFA.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using IBM___WFA.Data.Models;

namespace IBM___WFA.User_Controls.Companies_Menu
{
    public partial class Companies : UserControl
    {
        private ApplicationBusiness controller = new ApplicationBusiness();
        public Companies()
        {
            InitializeComponent();
            UpdateGrid();
        }

        //метод за ъпдейтване на dataGridView 
        private void UpdateGrid()
        {

            dataGridView1.DataSource = controller.GetAllFirmis();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SetSizeOfDataGridView();
        }

        //метод за ъпдейтване на dataGridView по име възходящо
        private void UpdateGridAsc()
        {

            dataGridView1.DataSource = controller.GetAllFirmisSortedByName();
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


        //метод за задаване на размерите на всяка колона в dataGridView
        private void SetSizeOfDataGridView()
        {
            dataGridView1.Columns[0].Width = dataGridView1.Width / 2 - 26;
            dataGridView1.Columns[1].Width = dataGridView1.Width / 2 - 26;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateGridAsc();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateGridAsc();
            ReverseDataGridView(ref dataGridView1);
        }


        //бутон за добавяне на фирма
        private void button1_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Enter name");

            if (controller.Firm_Exist(name))
            {
                MessageBox.Show("The firm already exist");
            }

            else
            {
                Firmi new_Firm = new Firmi();
                new_Firm.Ime = name;
                controller.AddFirm(new_Firm);
                MessageBox.Show("The firm is added successfully");
                UpdateGrid();
            }
        }


        //бутон за премахване на фирма
        private void button2_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Enter name");
            if (controller.Firm_Exist(name))
            {
                controller.RemoveFirm(name);
                MessageBox.Show("The firm was deleted successfully");
                UpdateGrid();
            }
            else
            {
                MessageBox.Show("The firm is not found!");
            }

        }



        //бутон за ъпдейтване на фирма
        private void button3_Click(object sender, EventArgs e)
        {
            int id = -1;
            string input = null;
            do
            {
                input = Interaction.InputBox("Enter id");
            }
            while (!int.TryParse(input, out id));

            string name = Interaction.InputBox("Enter name");

            Firmi firm = new Firmi();
            firm.IdFirma = id;
            firm.Ime = name;
            controller.UpdateFirm(firm);
            MessageBox.Show("The update was successfull");
            UpdateGrid();
            
        }

        private void Companies_Load(object sender, EventArgs e)
        {

        }
    }
}
