namespace ManagementUI
{
    partial class OrderEditor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClientBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrderDetailView = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.SaveOrderBtn = new System.Windows.Forms.Button();
            this.DeleteDetailBtn = new System.Windows.Forms.Button();
            this.ChangeDetailBtn = new System.Windows.Forms.Button();
            this.AddDetailBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClientBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.OrderIdBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // ClientBox
            // 
            this.ClientBox.Location = new System.Drawing.Point(96, 58);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(239, 21);
            this.ClientBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "客户";
            // 
            // OrderIdBox
            // 
            this.OrderIdBox.Location = new System.Drawing.Point(96, 23);
            this.OrderIdBox.Name = "OrderIdBox";
            this.OrderIdBox.Size = new System.Drawing.Size(239, 21);
            this.OrderIdBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.OrderDetailView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 350);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单明细";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 0);
            this.panel1.TabIndex = 1;
            // 
            // OrderDetailView
            // 
            this.OrderDetailView.AutoGenerateColumns = false;
            this.OrderDetailView.BackgroundColor = System.Drawing.Color.Bisque;
            this.OrderDetailView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetailView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.productQuantityDataGridViewTextBoxColumn});
            this.OrderDetailView.DataSource = this.orderDetailBindingSource;
            this.OrderDetailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderDetailView.Location = new System.Drawing.Point(3, 17);
            this.OrderDetailView.Name = "OrderDetailView";
            this.OrderDetailView.RowTemplate.Height = 23;
            this.OrderDetailView.Size = new System.Drawing.Size(794, 330);
            this.OrderDetailView.TabIndex = 0;
            this.OrderDetailView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // productQuantityDataGridViewTextBoxColumn
            // 
            this.productQuantityDataGridViewTextBoxColumn.DataPropertyName = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.HeaderText = "ProductQuantity";
            this.productQuantityDataGridViewTextBoxColumn.Name = "productQuantityDataGridViewTextBoxColumn";
            this.productQuantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(homework5.OrderDetail);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AddDetailBtn);
            this.panel3.Controls.Add(this.SaveOrderBtn);
            this.panel3.Controls.Add(this.DeleteDetailBtn);
            this.panel3.Controls.Add(this.ChangeDetailBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 407);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 43);
            this.panel3.TabIndex = 2;
            // 
            // SaveOrderBtn
            // 
            this.SaveOrderBtn.Location = new System.Drawing.Point(713, 11);
            this.SaveOrderBtn.Name = "SaveOrderBtn";
            this.SaveOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveOrderBtn.TabIndex = 3;
            this.SaveOrderBtn.Text = "保存订单";
            this.SaveOrderBtn.UseVisualStyleBackColor = true;
            this.SaveOrderBtn.Click += new System.EventHandler(this.SaveOrderBtn_Click);
            // 
            // DeleteDetailBtn
            // 
            this.DeleteDetailBtn.Location = new System.Drawing.Point(175, 8);
            this.DeleteDetailBtn.Name = "DeleteDetailBtn";
            this.DeleteDetailBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteDetailBtn.TabIndex = 2;
            this.DeleteDetailBtn.Text = "删除明细";
            this.DeleteDetailBtn.UseVisualStyleBackColor = true;
            // 
            // ChangeDetailBtn
            // 
            this.ChangeDetailBtn.Location = new System.Drawing.Point(94, 8);
            this.ChangeDetailBtn.Name = "ChangeDetailBtn";
            this.ChangeDetailBtn.Size = new System.Drawing.Size(75, 23);
            this.ChangeDetailBtn.TabIndex = 1;
            this.ChangeDetailBtn.Text = "修改明细";
            this.ChangeDetailBtn.UseVisualStyleBackColor = true;
            // 
            // AddDetailBtn
            // 
            this.AddDetailBtn.Location = new System.Drawing.Point(12, 8);
            this.AddDetailBtn.Name = "AddDetailBtn";
            this.AddDetailBtn.Size = new System.Drawing.Size(75, 23);
            this.AddDetailBtn.TabIndex = 4;
            this.AddDetailBtn.Text = "添加明细";
            this.AddDetailBtn.UseVisualStyleBackColor = true;
            this.AddDetailBtn.Click += new System.EventHandler(this.AddDetailBtn_Click);
            // 
            // OrderEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderEditor";
            this.Text = "OrderEditor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView OrderDetailView;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OrderIdBox;
        private System.Windows.Forms.Button SaveOrderBtn;
        private System.Windows.Forms.Button DeleteDetailBtn;
        private System.Windows.Forms.Button ChangeDetailBtn;
        private System.Windows.Forms.Button AddDetailBtn;
    }
}