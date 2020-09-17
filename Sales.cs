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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void Sales_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.sales.Hide();
            Main.main.Show();
            e.Cancel = true;
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.databaseDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.databaseDataSet.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.databaseDataSet.Sales);
            fixDataGridColumnsText();
        }

        private void fixDataGridColumnsText() {
            for (int i=0; i<dataGridView1.RowCount;i++) {
                comboBox1.SelectedValue = int.Parse(dataGridView1[1, i].Value.ToString());
                dataGridView1[2, i].Value = comboBox1.Text;

                comboBox2.SelectedValue = int.Parse(dataGridView1[3, i].Value.ToString());
                dataGridView1[4, i].Value = comboBox2.Text;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
            if (comboBox1.Text.Length < 1) return false;
            if (comboBox2.Text.Length < 1) return false;
            if (textBox1.TextLength < 1) return false;
            if (dateTimePicker1.Text.Length < 1) return false;
            if (textBox2.TextLength < 1) return false;
            return true;
        }
        private void clearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void AddPost()
        {
            if (isCanAdd())
                try
                {
                    DataRowView row = (DataRowView)salesBindingSource.AddNew();

                    row[1] = comboBox1.SelectedValue;
                    row[2] = comboBox2.SelectedValue;
                    row[3] = textBox1.Text;
                    row[4] = dateTimePicker1.Value;
                    row[5] = textBox2.Text;

                    salesBindingSource.EndEdit();
                    this.salesTableAdapter.Update(databaseDataSet);
                    this.salesTableAdapter.Fill(this.databaseDataSet.Sales);
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
                    dataGridView1.CurrentRow.Cells[1].Value = comboBox1.SelectedValue;
                    dataGridView1.CurrentRow.Cells[3].Value = comboBox2.SelectedValue;
                    dataGridView1.CurrentRow.Cells[5].Value = textBox1.Text;
                    dataGridView1.CurrentRow.Cells[6].Value = dateTimePicker1.Value;
                    dataGridView1.CurrentRow.Cells[7].Value = textBox2.Text;

                    salesBindingSource.EndEdit();
                    this.salesTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);
                    Main.helper.UpdatedMessage();
                    this.salesTableAdapter.Fill(this.databaseDataSet.Sales);
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
                    salesBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    salesTableAdapter.Update(databaseDataSet.Sales);
                    Main.helper.RemovedMessage();
                    this.salesTableAdapter.Fill(this.databaseDataSet.Sales);
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
                comboBox1.SelectedValue = int.Parse(dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString());
                comboBox2.SelectedValue = int.Parse(dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString());
                textBox1.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                dateTimePicker1.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox2.Text = dataGridView1[7, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }

        private void comboBox2_TextUpdate(object sender, EventArgs e)
        {
            
            int id= productsBindingSource.Find("Код", comboBox2.SelectedValue.ToString());
            int price=(int)((DataRowView)(productsBindingSource[id]))[6];

            try
            {
                int summ = int.Parse(textBox1.Text) * price;
                textBox2.Text = summ + "";
            }
            catch (Exception ex)
            {
                textBox1.Text = 1 + "";
                textBox2.Text = price + "";
            }
        }
    }
}
