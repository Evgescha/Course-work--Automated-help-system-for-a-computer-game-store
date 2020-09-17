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
    public partial class WorkingPositions : Form
    {
        public WorkingPositions()
        {
            InitializeComponent();
        }

        private void WorkingPositions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.workingPositions.Hide();
            Main.main.Show();
            e.Cancel = true;
        }
        
        private void WorkingPositions_Load(object sender, EventArgs e)
        {
            this.workingPositionsTableAdapter.Fill(this.databaseDataSet.WorkingPositions);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
            if (textBox1.TextLength < 1) return false;
            if (textBox2.TextLength < 1) return false;
            return true;
        }
        private void clearFields() {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void AddPost() {
            if(isCanAdd())
                try
                {
                    DataRowView row = (DataRowView)workingPositionsBindingSource.AddNew();

                    row[1] = textBox1.Text;
                    row[2] = textBox2.Text;

                    workingPositionsBindingSource.EndEdit();
                    this.workingPositionsTableAdapter.Update(databaseDataSet);
                    this.workingPositionsTableAdapter.Fill(this.databaseDataSet.WorkingPositions);
                    Main.helper.AddedMessage();
                    clearFields();
                }
                catch (Exception e) {
                    Main.helper.ErrorMessage(e.Message);
                }
            
        }
        private void UpdatePost() {
            if (isCanUpdate())
                try {
                    dataGridView1.CurrentRow.Cells[1].Value = textBox1.Text;
                    dataGridView1.CurrentRow.Cells[2].Value = textBox2.Text;
                    workingPositionsBindingSource.EndEdit();
                    this.workingPositionsTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);
                    Main.helper.UpdatedMessage();
                    this.workingPositionsTableAdapter.Fill(this.databaseDataSet.WorkingPositions);
                }
                catch (Exception e) {
                    Main.helper.ErrorMessage(e.Message);
                }
        }
        private void RemovePost() {
            if (isCanRemove())
                try
                {
                    workingPositionsBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    workingPositionsTableAdapter.Update(databaseDataSet.WorkingPositions);
                    Main.helper.RemovedMessage();
                    this.workingPositionsTableAdapter.Fill(this.databaseDataSet.WorkingPositions);
                }
                catch (Exception e) {
                    Main.helper.ErrorMessage(e.Message);
                }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (isCanRemove()) {
                textBox1.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox2.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }
    }
}
