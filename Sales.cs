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
    }
}
