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
        //add
        private void button1_Click(object sender, EventArgs e)
        {
           

        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {

        }
        //delete
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Publisher". При необходимости она может быть перемещена или удалена.
            this.publisherTableAdapter.Fill(this.databaseDataSet.Publisher);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.databaseDataSet.Products);

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Main.helper.isNumberOrControlChar(e);
        }
    }
}
