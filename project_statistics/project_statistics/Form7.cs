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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "datebaseDataSet1.Отчеты". При необходимости она может быть перемещена или удалена.
            this.отчетыTableAdapter1.Fill(this.datebaseDataSet1.Отчеты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "datebaseDataSet.сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.datebaseDataSet.сотрудники);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
