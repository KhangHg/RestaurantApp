using RestaurantApp.DAO;
using RestaurantApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace RestaurantApp
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; CheckAdmin(loginAccount.Type); }
        }
        public fTableManager(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;
            
            LoadTable();
            LoadCategory();
            LoadComboBoxTable(comboBoxChangeTable);
        }

        #region Method
        void CheckAdmin(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
        }

        void LoadTable()
        {
            flowLayoutPanelTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach(Table item in tableList)
            {
                Button button = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                button.Text = item.TableName + Environment.NewLine + item.Status;
                button.Tag = item;

                button.Click += Button_Click;

                switch (item.Status)
                {
                    case "Trống":
                        button.BackColor = Color.Aqua;
                        break;
                    default:
                        button.BackColor = Color.LightPink;
                        break;
                }
                flowLayoutPanelTable.Controls.Add(button);
            }
        }

        float ShowBill(int id)
        {
            listViewFood.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            CultureInfo converter = new CultureInfo("vi-VN");
            float totalPrice = 0;
            foreach(Menu item in listBillInfo)
            {
                ListViewItem listviewItem = new ListViewItem(item.FoodName.ToString());
                listviewItem.SubItems.Add(item.Count.ToString());
                listviewItem.SubItems.Add(item.Price.ToString("c", converter));
                listviewItem.SubItems.Add(item.TotalPrice.ToString("c", converter));
                totalPrice += item.TotalPrice;
                listViewFood.Items.Add(listviewItem);
            }

           
            textBoxTotalPrice.Text = totalPrice.ToString("c", converter);
            return totalPrice;
        }
 
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategories();
            comboBoxCategory.DataSource = listCategory;
            comboBoxCategory.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryId(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetListFood(id);
            comboBoxFood.DataSource = listFood;
            comboBoxFood.DisplayMember = "Name";
        }

        void LoadComboBoxTable(ComboBox cb)
        {
            List<Table> listTable = TableDAO.Instance.LoadTableList();
            cb.DataSource = listTable;
            cb.DisplayMember = "tableName";
        }
        #endregion

        #region Events
        private void Button_Click(object sender, EventArgs e)
        {
            int TableID = ((sender as Button).Tag as Table).Id;
            listViewFood.Tag = (sender as Button).Tag;
            ShowBill(TableID);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(loginAccount);
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.loginAccount = LoginAccount;
            f.ShowDialog(this);
        }


        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryId(id);
        }

        //them do an
        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            Table table = listViewFood.Tag as Table;
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.Id);
            int idFood = (comboBoxFood.SelectedItem as Food).ID;
            int count = (int)numericUpDownAddNumberFood.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.Id);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), idFood, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);
            }

            ShowBill(table.Id);
            LoadTable();
        }
        private void buttonPay_Click(object sender, EventArgs e)
        {
            Table table = listViewFood.Tag as Table;
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.Id);
            int discount = (int)numericUpDownDiscount.Value;
            float totalPrice = finalTotalPrice;
        

            if(idBill != -1)
            {
                if(MessageBox.Show("Bạn có đồng ý thanh toán " + table.TableName + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, totalPrice);
                    textBoxPayment.Text = String.Empty;
                    
                }
            }
            LoadTable();
        }


        //thanh toan
        private float finalTotalPrice;
        private void buttonFinalTotalPrice_Click(object sender, EventArgs e)
        {
            Table table = listViewFood.Tag as Table;
            int idBill = BillDAO.Instance.GetUnCheckBillIDByTableID(table.Id);
            int discount = (int)numericUpDownDiscount.Value;
            float totalPrice = ShowBill(table.Id);
            finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            CultureInfo converter = new CultureInfo("vi-VN");
            textBoxPayment.Text = finalTotalPrice.ToString("c", converter);
            LoadTable();
        }

        //chuyen ban
        private void buttonChangeTable_Click(object sender, EventArgs e)
        {
            int id1 = (listViewFood.Tag as Table).Id;
            int id2 =  (comboBoxChangeTable.SelectedItem as Table).Id;
            string name1 = (listViewFood.Tag as Table).TableName;
            string name2 = (comboBoxChangeTable.SelectedItem as Table).TableName;

            if (MessageBox.Show(String.Format("Bạn có thực sự muốn chuyển từ {0} sang {1} ?", name1, name2), "Thông báo", MessageBoxButtons.OKCancel)== DialogResult.OK)
            {

                TableDAO.Instance.SwitchTable(id1, id2);
                LoadTable();
            }

        }
        #endregion
    }
}
