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
        //add
        private void button1_Click(object sender, EventArgs e)
        {

        }
        //update
        private void button2_Click(object sender, EventArgs e)
        {

        }
        //remove
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
