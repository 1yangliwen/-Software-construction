using homework5;
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

    public partial class OrderManagementSystem : Form
    {
        public OrderManagementSystem()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Ordergrp_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderServicetlp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            // Open a new window for creating a new order
            OrderEditor orderEditor = new OrderEditor();
            orderEditor.ShowDialog();
        }

        private void ModifyOrderBtn_Click(object sender, EventArgs e)
        {
            // Get the selected order from the DataGridView
            Order selectedOrder = (Order)dataGridView1.CurrentRow.DataBoundItem;

            // Open a new window for modifying the selected order
            //构造函数还没有写
            OrderEditor orderDetailsForm = new OrderEditor(selectedOrder);
            orderDetailsForm.ShowDialog();
        }

        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {
            // Get the selected order from the DataGridView
            Order selectedOrder = (Order)dataGridView1.CurrentRow.DataBoundItem;

            // Call the OrderService to delete the selected order
            OrderService.DeleteOrder(selectedOrder);

            // Refresh the DataGridView to reflect the changes
            orderBindingSource.ResetBindings(false);
        }
    }
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OrderManagementSystem());
        }
    }
}
