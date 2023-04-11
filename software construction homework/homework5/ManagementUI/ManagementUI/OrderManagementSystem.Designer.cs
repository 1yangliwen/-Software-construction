namespace ManagementUI
{
    partial class OrderManagementSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagementSystem));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.OrderServicetlp = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.Searchtb = new System.Windows.Forms.TextBox();
            this.Sortbtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.NewOrderBtn = new System.Windows.Forms.Button();
            this.ModifyOrderBtn = new System.Windows.Forms.Button();
            this.DeleteOrderBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Ordergrp = new System.Windows.Forms.GroupBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.OrderDetgrp = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.orderDetailsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.orderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderServicetlp.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.Ordergrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            this.OrderDetgrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderServicetlp
            // 
            this.OrderServicetlp.BackColor = System.Drawing.Color.Ivory;
            this.OrderServicetlp.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.OrderServicetlp.ColumnCount = 1;
            this.OrderServicetlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderServicetlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderServicetlp.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.OrderServicetlp.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.OrderServicetlp.Dock = System.Windows.Forms.DockStyle.Top;
            this.OrderServicetlp.Location = new System.Drawing.Point(0, 0);
            this.OrderServicetlp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderServicetlp.Name = "OrderServicetlp";
            this.OrderServicetlp.RowCount = 2;
            this.OrderServicetlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderServicetlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.OrderServicetlp.Size = new System.Drawing.Size(1579, 216);
            this.OrderServicetlp.TabIndex = 0;
            this.OrderServicetlp.Paint += new System.Windows.Forms.PaintEventHandler(this.OrderServicetlp_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.radioButton1);
            this.flowLayoutPanel1.Controls.Add(this.radioButton2);
            this.flowLayoutPanel1.Controls.Add(this.radioButton3);
            this.flowLayoutPanel1.Controls.Add(this.Searchtb);
            this.flowLayoutPanel1.Controls.Add(this.Sortbtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 113);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 24, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1567, 97);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(50, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0, 4, 20, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 32);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "排序方式";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(204, 34);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 36);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "订单号";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(337, 34);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(113, 36);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "用户名";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(470, 34);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(113, 36);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "总金额";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Searchtb
            // 
            this.Searchtb.AcceptsReturn = true;
            this.Searchtb.Location = new System.Drawing.Point(603, 28);
            this.Searchtb.Margin = new System.Windows.Forms.Padding(10, 4, 30, 4);
            this.Searchtb.Name = "Searchtb";
            this.Searchtb.Size = new System.Drawing.Size(618, 35);
            this.Searchtb.TabIndex = 5;
            this.Searchtb.UseWaitCursor = true;
            // 
            // Sortbtn
            // 
            this.Sortbtn.Location = new System.Drawing.Point(1255, 28);
            this.Sortbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sortbtn.Name = "Sortbtn";
            this.Sortbtn.Size = new System.Drawing.Size(140, 48);
            this.Sortbtn.TabIndex = 4;
            this.Sortbtn.Text = "查询";
            this.Sortbtn.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.NewOrderBtn);
            this.flowLayoutPanel2.Controls.Add(this.ModifyOrderBtn);
            this.flowLayoutPanel2.Controls.Add(this.DeleteOrderBtn);
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 8);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1563, 93);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // NewOrderBtn
            // 
            this.NewOrderBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewOrderBtn.Location = new System.Drawing.Point(20, 20);
            this.NewOrderBtn.Margin = new System.Windows.Forms.Padding(20, 20, 6, 6);
            this.NewOrderBtn.Name = "NewOrderBtn";
            this.NewOrderBtn.Size = new System.Drawing.Size(160, 50);
            this.NewOrderBtn.TabIndex = 0;
            this.NewOrderBtn.Text = "创建订单";
            this.NewOrderBtn.UseVisualStyleBackColor = true;
            this.NewOrderBtn.Click += new System.EventHandler(this.NewOrderBtn_Click);
            // 
            // ModifyOrderBtn
            // 
            this.ModifyOrderBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModifyOrderBtn.Location = new System.Drawing.Point(206, 20);
            this.ModifyOrderBtn.Margin = new System.Windows.Forms.Padding(20, 20, 6, 6);
            this.ModifyOrderBtn.Name = "ModifyOrderBtn";
            this.ModifyOrderBtn.Size = new System.Drawing.Size(160, 50);
            this.ModifyOrderBtn.TabIndex = 1;
            this.ModifyOrderBtn.Text = "修改订单";
            this.ModifyOrderBtn.UseVisualStyleBackColor = true;
            this.ModifyOrderBtn.Click += new System.EventHandler(this.ModifyOrderBtn_Click);
            // 
            // DeleteOrderBtn
            // 
            this.DeleteOrderBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteOrderBtn.Location = new System.Drawing.Point(392, 20);
            this.DeleteOrderBtn.Margin = new System.Windows.Forms.Padding(20, 20, 6, 6);
            this.DeleteOrderBtn.Name = "DeleteOrderBtn";
            this.DeleteOrderBtn.Size = new System.Drawing.Size(160, 50);
            this.DeleteOrderBtn.TabIndex = 2;
            this.DeleteOrderBtn.Text = "删除订单";
            this.DeleteOrderBtn.UseVisualStyleBackColor = true;
            this.DeleteOrderBtn.Click += new System.EventHandler(this.DeleteOrderBtn_Click);
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Location = new System.Drawing.Point(578, 20);
            this.button5.Margin = new System.Windows.Forms.Padding(20, 20, 6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 50);
            this.button5.TabIndex = 3;
            this.button5.Text = "导出订单";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Ordergrp
            // 
            this.Ordergrp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Ordergrp.Controls.Add(this.bindingNavigator1);
            this.Ordergrp.Controls.Add(this.OrderGridView);
            this.Ordergrp.Dock = System.Windows.Forms.DockStyle.Left;
            this.Ordergrp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ordergrp.Location = new System.Drawing.Point(0, 216);
            this.Ordergrp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ordergrp.Name = "Ordergrp";
            this.Ordergrp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ordergrp.Size = new System.Drawing.Size(840, 748);
            this.Ordergrp.TabIndex = 1;
            this.Ordergrp.TabStop = false;
            this.Ordergrp.Text = "订单";
            this.Ordergrp.Enter += new System.EventHandler(this.Ordergrp_Enter);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(4, 702);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(832, 42);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorAddNewItem.Text = "新添";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(61, 36);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "总项数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "删除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveFirstItem.Text = "移到第一条记录";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(96, 38);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "移到下一条记录";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // OrderGridView
            // 
            this.OrderGridView.AutoGenerateColumns = false;
            this.OrderGridView.BackgroundColor = System.Drawing.Color.LightYellow;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.clientDataGridViewTextBoxColumn,
            this.totalMoneyDataGridViewTextBoxColumn});
            this.OrderGridView.DataSource = this.orderBindingSource1;
            this.OrderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderGridView.Location = new System.Drawing.Point(4, 41);
            this.OrderGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.RowHeadersWidth = 82;
            this.OrderGridView.RowTemplate.Height = 23;
            this.OrderGridView.Size = new System.Drawing.Size(832, 703);
            this.OrderGridView.TabIndex = 0;
            this.OrderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGridView_CellContentClick);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.Width = 200;
            // 
            // clientDataGridViewTextBoxColumn
            // 
            this.clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            this.clientDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalMoneyDataGridViewTextBoxColumn
            // 
            this.totalMoneyDataGridViewTextBoxColumn.DataPropertyName = "TotalMoney";
            this.totalMoneyDataGridViewTextBoxColumn.HeaderText = "TotalMoney";
            this.totalMoneyDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.totalMoneyDataGridViewTextBoxColumn.Name = "totalMoneyDataGridViewTextBoxColumn";
            this.totalMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalMoneyDataGridViewTextBoxColumn.Width = 200;
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataSource = typeof(homework5.Order);
            // 
            // OrderDetgrp
            // 
            this.OrderDetgrp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.OrderDetgrp.Controls.Add(this.dataGridView1);
            this.OrderDetgrp.Controls.Add(this.chart1);
            this.OrderDetgrp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDetgrp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OrderDetgrp.Location = new System.Drawing.Point(840, 216);
            this.OrderDetgrp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderDetgrp.Name = "OrderDetgrp";
            this.OrderDetgrp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderDetgrp.Size = new System.Drawing.Size(739, 748);
            this.OrderDetgrp.TabIndex = 2;
            this.OrderDetgrp.TabStop = false;
            this.OrderDetgrp.Text = "订单明细";
            this.OrderDetgrp.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productQuantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderDetailsBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(731, 331);
            this.dataGridView1.TabIndex = 2;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.Width = 130;
            // 
            // productQuantityDataGridViewTextBoxColumn
            // 
            this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.HeaderText = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
            this.productQuantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderDetailsBindingSource2
            // 
            this.orderDetailsBindingSource2.DataMember = "OrderDetails";
            this.orderDetailsBindingSource2.DataSource = this.orderBindingSource1;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Bisque;
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.orderDetailsBindingSource3;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 372);
            this.chart1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(731, 372);
            this.chart1.TabIndex = 1;
            // 
            // orderDetailsBindingSource3
            // 
            this.orderDetailsBindingSource3.DataMember = "OrderDetails";
            this.orderDetailsBindingSource3.DataSource = this.orderBindingSource1;
            // 
            // orderDetailsBindingSource1
            // 
            this.orderDetailsBindingSource1.DataMember = "OrderDetails";
            this.orderDetailsBindingSource1.DataSource = this.orderBindingSource1;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.orderBindingSource;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(homework5.Order);
            // 
            // orderBindingSource2
            // 
            this.orderBindingSource2.DataSource = typeof(homework5.Order);
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(homework5.OrderDetail);
            // 
            // OrderManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 964);
            this.Controls.Add(this.OrderDetgrp);
            this.Controls.Add(this.Ordergrp);
            this.Controls.Add(this.OrderServicetlp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderManagementSystem";
            this.Text = "订单管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.OrderServicetlp.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.Ordergrp.ResumeLayout(false);
            this.Ordergrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            this.OrderDetgrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel OrderServicetlp;
        private System.Windows.Forms.GroupBox Ordergrp;
        private System.Windows.Forms.GroupBox OrderDetgrp;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button Sortbtn;
        private System.Windows.Forms.TextBox Searchtb;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource1;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button NewOrderBtn;
        private System.Windows.Forms.Button ModifyOrderBtn;
        private System.Windows.Forms.Button DeleteOrderBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource orderBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMoneyDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource2;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource3;
    }
}