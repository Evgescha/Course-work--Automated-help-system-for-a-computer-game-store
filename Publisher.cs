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
    public partial class Publisher : Form
    {
        public Publisher()
        {
            InitializeComponent();
        }

        private void Publisher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.publicher.Hide();
            Main.main.Show();
            e.Cancel = true;
        }
       

        private void Publisher_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Publisher". При необходимости она может быть перемещена или удалена.
            this.publisherTableAdapter.Fill(this.databaseDataSet.Publisher);

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
            return true;
        }
        private void clearFields()
        {
            textBox1.Text = "";
        }
        private void AddPost()
        {
            if (isCanAdd())
                try
                {
                    DataRowView row = (DataRowView)publisherBindingSource.AddNew();

                    row[0] = textBox1.Text;

                    publisherBindingSource.EndEdit();
                    this.publisherTableAdapter.Update(databaseDataSet);
                    this.publisherTableAdapter.Fill(this.databaseDataSet.Publisher);
                    Main.helper.AddedMessage();
                    clearFields();
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
                    dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
                    publisherBindingSource.EndEdit();
                    this.publisherTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);
                    Main.helper.UpdatedMessage();
                    this.publisherTableAdapter.Fill(this.databaseDataSet.Publisher);
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
                    publisherBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    publisherTableAdapter.Update(databaseDataSet.Publisher);
                    Main.helper.RemovedMessage();
                    this.publisherTableAdapter.Fill(this.databaseDataSet.Publisher);
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
                textBox1.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }
    }
}
