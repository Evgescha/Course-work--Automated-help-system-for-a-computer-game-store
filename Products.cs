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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.products.Hide();
            Main.main.Show();
            e.Cancel = true;
        }

        private void Products_Load(object sender, EventArgs e)
        {            
            updateAll();
        }
        private void updateList(){
            checkedListBox1.Items.Clear();
            DatabaseDataSet.GenresRow[] genresRow = this.databaseDataSet.Genres.ToArray();
            for (int i = 0; i < genresRow.Length; i++)
            {
                checkedListBox1.Items.Add(genresRow[i][0].ToString());
            }
            checkedListBox1.Sorted = true;
        }
        private void updateAll() {
            this.genresTableAdapter.Fill(this.databaseDataSet.Genres);
            this.publisherTableAdapter.Fill(this.databaseDataSet.Publisher);
            this.productsTableAdapter.Fill(this.databaseDataSet.Products);
            updateList();
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Main.helper.isNumberOrControlChar(e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateAll();
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
            if (textBox3.TextLength < 1) return false;
            if (textBox4.TextLength < 1) return false;
            if (checkedListBox1.CheckedItems.Count < 1) return false;
            return true;
        }
        private void clearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            UncheckAllItems();
        }
        private void AddPost()
        {
            if (isCanAdd())
                try
                {
                    DataRowView row = (DataRowView)productsBindingSource.AddNew();

                    row[1] = textBox1.Text;
                    for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                        row[2] += checkedListBox1.CheckedItems[i].ToString()+"; ";
                    row[3] = textBox2.Text;
                    row[4] = textBox3.Text;
                    row[5] = comboBox1.SelectedValue;
                    row[6] = textBox4.Text;
                    productsBindingSource.EndEdit();
                    this.productsTableAdapter.Update(databaseDataSet);
                    this.productsTableAdapter.Fill(this.databaseDataSet.Products);
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
                    dataGridView1.CurrentRow.Cells[1].Value = textBox1.Text;
                    string genres = "";
                    for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                         genres += checkedListBox1.CheckedItems[i].ToString() + "; ";
                    dataGridView1.CurrentRow.Cells[2].Value = genres;
                    dataGridView1.CurrentRow.Cells[3].Value = textBox2.Text;
                    dataGridView1.CurrentRow.Cells[4].Value = textBox3.Text;
                    dataGridView1.CurrentRow.Cells[5].Value = comboBox1.SelectedValue;
                    dataGridView1.CurrentRow.Cells[6].Value = textBox4.Text;


                    productsBindingSource.EndEdit();
                    this.productsTableAdapter.Update(((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row);
                    Main.helper.UpdatedMessage();
                    this.productsTableAdapter.Fill(this.databaseDataSet.Products);
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
                    productsBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                    productsTableAdapter.Update(databaseDataSet.Products);
                    Main.helper.RemovedMessage();
                    this.productsTableAdapter.Fill(this.databaseDataSet.Products);
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
                string[] separator = new string[] { "; " };
                string[] genreArr = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString().Split(separator,StringSplitOptions.None);
                UncheckAllItems();

                string genre; int index;
                for (int i = 0; i < genreArr.Length; i++) {
                    genre= genreArr[i].Trim().Replace(";", "");
                    index = checkedListBox1.FindString(genre);
                    checkedListBox1.SetItemChecked(index, true);
                }
                textBox2.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox3.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
                comboBox1.SelectedValue = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox4.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }
        private void UncheckAllItems()
        {
            while (checkedListBox1.CheckedIndices.Count > 0)
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
            if(checkedListBox1.Items.Count>0)
            checkedListBox1.SetItemChecked(0, false);
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text.Length < 1) return;
                this.productsTableAdapter.FillByНазвание(this.databaseDataSet.Products, $"%{textBox1.Text}%");
            }
            else if (radioButton2.Checked)
            {               
                string genres = "";
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                    genres += checkedListBox1.CheckedItems[i].ToString() + "; ";
                this.productsTableAdapter.FillByЖанр(this.databaseDataSet.Products, $"%{genres}%");
            }
            else if (radioButton3.Checked)
            {
                if (textBox2.Text.Length < 1) return;
                this.productsTableAdapter.FillByВозраст(this.databaseDataSet.Products, int.Parse(textBox2.Text));
            }
            else if (radioButton4.Checked)
            {
                if (textBox3.Text.Length < 1) return;
                this.productsTableAdapter.FillByГодИзд(this.databaseDataSet.Products, int.Parse(textBox3.Text));
            }
            else if (radioButton5.Checked)
            {
                if (comboBox1.Items.Count < 1) return;
                this.productsTableAdapter.FillByИздательство(this.databaseDataSet.Products, comboBox1.Text);
            }
            else if (radioButton6.Checked)
            {
                if (textBox4.Text.Length < 1) return;
                this.productsTableAdapter.FillByЦена(this.databaseDataSet.Products, int.Parse(textBox4.Text));
            }
            updateList();
        }
    }
}
