﻿using System;
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

        private void Employees_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.employees.Hide();
            Main.main.Show();
            e.Cancel = true;
        }
    }
}