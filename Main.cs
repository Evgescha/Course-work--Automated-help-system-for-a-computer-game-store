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
    public partial class Main : Form
    {
        public static Main main;
        public static Sales sales = new Sales();
        public static Products products = new Products();
        public static Employees employees = new Employees();
        public static Genres genres = new Genres();
        public static Publisher publicher = new Publisher();
        public static WorkingPositions workingPositions = new WorkingPositions();


        public Main()
        {
            InitializeComponent();
            main = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.Hide();
            sales.Show();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.Hide();
            products.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.Hide();
            employees.Show();
        }

        private void жанрыИгрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.Hide();
            genres.Show();
        }

        private void изданияИгрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.Hide();
            publicher.Show();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.Hide();
            workingPositions.Show();
        }
    }
}
