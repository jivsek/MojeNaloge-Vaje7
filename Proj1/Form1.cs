﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                to_do.Items.Add(textBox1.Text);
            }
        }

        private void btn_odstrani_Click(object sender, EventArgs e)
        {
            if (to_do.SelectedIndex != -1)
            {
                to_do.Items.RemoveAt(to_do.SelectedIndex);
            }
        }
    }
}
