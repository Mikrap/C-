﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_statistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newForm = new Form2();
            newForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form3 newForm = new Form3();
            newForm.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
