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
    public partial class Genres : Form
    {
        public Genres()
        {
            InitializeComponent();
        }

        private void Genres_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.genres.Hide();
            Main.main.Show();
            e.Cancel = true;
        }
      

        private void Genres_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Genres". При необходимости она может быть перемещена или удалена.
            this.genresTableAdapter.Fill(this.databaseDataSet.Genres);

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
                    DataRowView row = (DataRowView)genresBindingSource.AddNew();

                    row[0] = textBox1.Text;

                    genresBindingSource.EndEdit();
                    this.genresTableAdapter.Update(databaseDataSet);
                    this.genresTableAdapter.Fill(this.databaseDataSet.Genres);
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
                    genresBindingSource.EndEdit();
                    this.genresTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);
                    Main.helper.UpdatedMessage();
                    this.genresTableAdapter.Fill(this.databaseDataSet.Genres);
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
                    genresBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    genresTableAdapter.Update(databaseDataSet.Genres);
                    Main.helper.RemovedMessage();
                    this.genresTableAdapter.Fill(this.databaseDataSet.Genres);
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
