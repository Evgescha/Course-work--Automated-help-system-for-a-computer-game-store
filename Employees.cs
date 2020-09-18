using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automated_help_system_for_a_computer_game_store
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }
        private void Employees_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.employees.Hide();
            Main.main.Show();
            e.Cancel = true;
        }


        private void Employees_Load(object sender, EventArgs e)
        {
            updateAll();
          
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Main.helper.isNumberOrControlChar(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddPost();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdatePost();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemovePost();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            updateAll();
        }
        private void updateAll()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.WorkingPositions". При необходимости она может быть перемещена или удалена.
            this.workingPositionsTableAdapter.Fill(this.databaseDataSet.WorkingPositions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.databaseDataSet.Employees);
            fixDataGridColumnsText();
        }
        private bool isCanUpdate()
        {
            if (!isCanRemove()) return false;
            if (!isCanAdd()) return false;
            return true;
        }
        private bool isCanRemove()
        {
            if (dataGridView1.RowCount == 0) return false;
            if (dataGridView1.CurrentRow == null) return false;
            return true;
        }
        private bool isCanAdd()
        {
            if (textBox1.TextLength < 1) return false;
            if (textBox2.TextLength < 1) return false;
            return true;
        }
        private void clearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void AddPost()
        {
            if (isCanAdd())
                try
                {
                    DataRowView row = (DataRowView)employeesBindingSource.AddNew();

                    row[1] = textBox1.Text;
                    row[2] = comboBox1.SelectedValue;
                    row[3] = textBox2.Text;
                    row[4] = textBox3.Text;

                    employeesBindingSource.EndEdit();
                    this.employeesTableAdapter.Update(databaseDataSet);
                    this.employeesTableAdapter.Fill(this.databaseDataSet.Employees);
                    Main.helper.AddedMessage();
                    clearFields();

                    fixDataGridColumnsText();
                }
                catch (Exception e)
                {
                    Main.helper.ErrorMessage(e.Message);
                }

        }
        private void UpdatePost()
        {
            if (isCanUpdate())
                try
                {
                    dataGridView1.CurrentRow.Cells[1].Value = textBox1.Text;
                    dataGridView1.CurrentRow.Cells[2].Value = comboBox1.SelectedValue;
                    dataGridView1.CurrentRow.Cells[4].Value = textBox2.Text;
                    dataGridView1.CurrentRow.Cells[5].Value = textBox3.Text;

                    employeesBindingSource.EndEdit();
                    this.employeesTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);
                    Main.helper.UpdatedMessage();
                    this.employeesTableAdapter.Fill(this.databaseDataSet.Employees);

                    fixDataGridColumnsText();
                }
                catch (Exception e)
                {
                    Main.helper.ErrorMessage(e.Message);
                }
        }
        private void RemovePost()
        {
            if (isCanRemove())
                try
                {
                    employeesBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    employeesTableAdapter.Update(databaseDataSet.Employees);
                    Main.helper.RemovedMessage();
                    this.employeesTableAdapter.Fill(this.databaseDataSet.Employees);

                    fixDataGridColumnsText();
                }
                catch (Exception e)
                {
                    Main.helper.ErrorMessage(e.Message);
                }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (isCanRemove())
            {
                textBox1.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                comboBox1.SelectedValue = int.Parse(dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString());
                textBox2.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox3.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }

        private void fixDataGridColumnsText()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                comboBox1.SelectedValue = int.Parse(dataGridView1[2, i].Value.ToString());
                dataGridView1[3, i].Value = comboBox1.Text;
            }
        }


    }
}
