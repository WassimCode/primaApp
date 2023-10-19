﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoInterattivaForm
{
    public partial class AlterSpeed : Form
    {
        public string choice;
        // Amount of speed in Km/h to gain/lose
        public int value;
        public AlterSpeed()
        {
            InitializeComponent();
        }

        public AlterSpeed(string choice)
        {
            InitializeComponent();
            this.choice = choice;
            label1.Text = "Enter by how many km/h you want to " + choice;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            value = Convert.ToInt32(numericUpDown1.Value);
        }
    }
}
