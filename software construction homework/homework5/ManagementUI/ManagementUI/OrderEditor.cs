﻿using homework5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementUI
{
    public partial class OrderEditor : Form
    {
        public OrderEditor()
        {
            InitializeComponent();
        }

        public OrderEditor(Order selectedOrder)
        {
            OrderIdBox.Text = selectedOrder.OrderId;
            ClientBox.Text = selectedOrder.Client;
            orderDetailBindingSource.DataSource = selectedOrder;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void SaveOrderBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddDetailBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
