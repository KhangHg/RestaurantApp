namespace RestaurantApp
{
    partial class fTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTable = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTable = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPay = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFinalTotalPrice = new System.Windows.Forms.Button();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.Sum = new System.Windows.Forms.Label();
            this.comboBoxChangeTable = new System.Windows.Forms.ComboBox();
            this.numericUpDownDiscount = new System.Windows.Forms.NumericUpDown();
            this.buttonChangeTable = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listViewFood = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDownAddNumberFood = new System.Windows.Forms.NumericUpDown();
            this.buttonAddFood = new System.Windows.Forms.Button();
            this.comboBoxFood = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameCustomer = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panelTable.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddNumberFood)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông Tin Tài Khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông Tin Cá Nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panelTable
            // 
            this.panelTable.AutoScroll = true;
            this.panelTable.Controls.Add(this.flowLayoutPanelTable);
            this.panelTable.Location = new System.Drawing.Point(12, 31);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(573, 587);
            this.panelTable.TabIndex = 1;
            // 
            // flowLayoutPanelTable
            // 
            this.flowLayoutPanelTable.AutoScroll = true;
            this.flowLayoutPanelTable.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelTable.Name = "flowLayoutPanelTable";
            this.flowLayoutPanelTable.Size = new System.Drawing.Size(567, 575);
            this.flowLayoutPanelTable.TabIndex = 0;
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(117, 131);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(270, 36);
            this.buttonPay.TabIndex = 0;
            this.buttonPay.Text = "Thanh Toán";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonFinalTotalPrice);
            this.panel2.Controls.Add(this.buttonPay);
            this.panel2.Controls.Add(this.textBoxPayment);
            this.panel2.Controls.Add(this.textBoxTotalPrice);
            this.panel2.Controls.Add(this.Sum);
            this.panel2.Controls.Add(this.comboBoxChangeTable);
            this.panel2.Controls.Add(this.numericUpDownDiscount);
            this.panel2.Controls.Add(this.buttonChangeTable);
            this.panel2.Location = new System.Drawing.Point(591, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 170);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(136, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Giảm Giá";
            // 
            // buttonFinalTotalPrice
            // 
            this.buttonFinalTotalPrice.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFinalTotalPrice.Location = new System.Drawing.Point(117, 98);
            this.buttonFinalTotalPrice.Name = "buttonFinalTotalPrice";
            this.buttonFinalTotalPrice.Size = new System.Drawing.Size(121, 29);
            this.buttonFinalTotalPrice.TabIndex = 10;
            this.buttonFinalTotalPrice.Text = "Thành Tiền";
            this.buttonFinalTotalPrice.UseVisualStyleBackColor = true;
            this.buttonFinalTotalPrice.Click += new System.EventHandler(this.buttonFinalTotalPrice_Click);
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPayment.ForeColor = System.Drawing.Color.Tomato;
            this.textBoxPayment.Location = new System.Drawing.Point(254, 98);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.ReadOnly = true;
            this.textBoxPayment.Size = new System.Drawing.Size(133, 27);
            this.textBoxPayment.TabIndex = 9;
            this.textBoxPayment.Text = "0";
            this.textBoxPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTotalPrice.ForeColor = System.Drawing.Color.Tomato;
            this.textBoxTotalPrice.Location = new System.Drawing.Point(254, 14);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(133, 27);
            this.textBoxTotalPrice.TabIndex = 7;
            this.textBoxTotalPrice.Text = "0";
            this.textBoxTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sum.Location = new System.Drawing.Point(156, 20);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(54, 21);
            this.Sum.TabIndex = 6;
            this.Sum.Text = "Tổng";
            // 
            // comboBoxChangeTable
            // 
            this.comboBoxChangeTable.FormattingEnabled = true;
            this.comboBoxChangeTable.Location = new System.Drawing.Point(15, 53);
            this.comboBoxChangeTable.Name = "comboBoxChangeTable";
            this.comboBoxChangeTable.Size = new System.Drawing.Size(94, 28);
            this.comboBoxChangeTable.TabIndex = 5;
            // 
            // numericUpDownDiscount
            // 
            this.numericUpDownDiscount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDiscount.Location = new System.Drawing.Point(325, 57);
            this.numericUpDownDiscount.Name = "numericUpDownDiscount";
            this.numericUpDownDiscount.Size = new System.Drawing.Size(62, 27);
            this.numericUpDownDiscount.TabIndex = 4;
            this.numericUpDownDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonChangeTable
            // 
            this.buttonChangeTable.Location = new System.Drawing.Point(15, 5);
            this.buttonChangeTable.Name = "buttonChangeTable";
            this.buttonChangeTable.Size = new System.Drawing.Size(94, 43);
            this.buttonChangeTable.TabIndex = 1;
            this.buttonChangeTable.Text = "Chuyển Bàn";
            this.buttonChangeTable.UseVisualStyleBackColor = true;
            this.buttonChangeTable.Click += new System.EventHandler(this.buttonChangeTable_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listViewFood);
            this.panel3.Location = new System.Drawing.Point(591, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(403, 254);
            this.panel3.TabIndex = 3;
            // 
            // listViewFood
            // 
            this.listViewFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewFood.GridLines = true;
            this.listViewFood.Location = new System.Drawing.Point(3, 5);
            this.listViewFood.Name = "listViewFood";
            this.listViewFood.Size = new System.Drawing.Size(397, 242);
            this.listViewFood.TabIndex = 0;
            this.listViewFood.TileSize = new System.Drawing.Size(1, 1);
            this.listViewFood.UseCompatibleStateImageBehavior = false;
            this.listViewFood.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn Giá";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành Tiền";
            this.columnHeader4.Width = 100;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numericUpDownAddNumberFood);
            this.panel4.Controls.Add(this.buttonAddFood);
            this.panel4.Controls.Add(this.comboBoxFood);
            this.panel4.Controls.Add(this.comboBoxCategory);
            this.panel4.Location = new System.Drawing.Point(591, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 90);
            this.panel4.TabIndex = 4;
            // 
            // numericUpDownAddNumberFood
            // 
            this.numericUpDownAddNumberFood.Location = new System.Drawing.Point(288, 49);
            this.numericUpDownAddNumberFood.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownAddNumberFood.Name = "numericUpDownAddNumberFood";
            this.numericUpDownAddNumberFood.Size = new System.Drawing.Size(86, 27);
            this.numericUpDownAddNumberFood.TabIndex = 3;
            this.numericUpDownAddNumberFood.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownAddNumberFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.Location = new System.Drawing.Point(260, 3);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.Size = new System.Drawing.Size(127, 28);
            this.buttonAddFood.TabIndex = 2;
            this.buttonAddFood.Text = "Thêm Món";
            this.buttonAddFood.UseVisualStyleBackColor = true;
            this.buttonAddFood.Click += new System.EventHandler(this.buttonAddFood_Click);
            // 
            // comboBoxFood
            // 
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.Location = new System.Drawing.Point(3, 48);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(235, 28);
            this.comboBoxFood.TabIndex = 1;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(3, 3);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(235, 28);
            this.comboBoxCategory.TabIndex = 0;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(737, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // textBoxNameCustomer
            // 
            this.textBoxNameCustomer.Location = new System.Drawing.Point(663, 418);
            this.textBoxNameCustomer.Name = "textBoxNameCustomer";
            this.textBoxNameCustomer.Size = new System.Drawing.Size(270, 27);
            this.textBoxNameCustomer.TabIndex = 6;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 635);
            this.Controls.Add(this.textBoxNameCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Nhà Hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTable.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddNumberFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panelTable;
        private Panel panel2;
        private Button buttonChangeTable;
        private Button buttonPay;
        private Panel panel3;
        private ListView listViewFood;
        private Panel panel4;
        private Button buttonAddFood;
        private ComboBox comboBoxFood;
        private ComboBox comboBoxCategory;
        private NumericUpDown numericUpDownDiscount;
        private NumericUpDown numericUpDownAddNumberFood;
        private ComboBox comboBoxChangeTable;
        private FlowLayoutPanel flowLayoutPanelTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox textBoxTotalPrice;
        private Label Sum;
        private TextBox textBoxPayment;
        private Button buttonFinalTotalPrice;
        private Label label1;
        private Label label2;
        private TextBox textBoxNameCustomer;
    }
}