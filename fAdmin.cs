using RestaurantApp.DAO;
using RestaurantApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp
{
    public partial class fAdmin : Form
    {
        BindingSource listFood = new BindingSource();
        BindingSource listAccount = new BindingSource();
        BindingSource listCategory = new BindingSource();

        public Account loginAccount;

        private Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }
        public fAdmin()
        {
            InitializeComponent();
            Load();
        }

        #region Methods
        void Load()
        {
            dataGridViewFood.DataSource = listFood;
            dataGridViewAccount.DataSource = listAccount;
            dataGridViewCategory.DataSource = listCategory;
            LoadDataTimePickerBill();
            LoadListBillByDate(dateTimePickerCheckIn.Value, dateTimePickerCheckOut.Value);
            LoadListFood();
            AddFoodBinding();
            LoadCategoryInComboBox(comboBoxCategory);
            LoadAccount();
            AddAccountBinding();
            LoadCategory();
            AddCategoryBinding();
        }

        #region Food
        void LoadListFood()
        {
            listFood.DataSource = FoodDAO.Instance.LoadListFood();
        }

        List<Food> SearchFood(string name)
        {
            List<Food> list = FoodDAO.Instance.SearchFoodByName(name);
            return list;

        }

        void AddFoodBinding()
        {
            textBoxNameFood.DataBindings.Add(new Binding("Text", dataGridViewFood.DataSource, "name", true, DataSourceUpdateMode.Never));
            textBoxID.DataBindings.Add(new Binding("Text", dataGridViewFood.DataSource, "id", true, DataSourceUpdateMode.Never));
            numericUpDownPrice.DataBindings.Add(new Binding("Value", dataGridViewFood.DataSource, "price", true, DataSourceUpdateMode.Never));

        }
        #endregion

        #region Bill
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dataGridViewDoanhThu.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }

        void LoadDataTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dateTimePickerCheckIn.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePickerCheckOut.Value = dateTimePickerCheckIn.Value.AddMonths(1).AddDays(-1);
        }

        #endregion

        #region Account
        void AddAccountBinding()
        {
            textBoxDisplayName.DataBindings.Add(new Binding("Text", dataGridViewAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            textBoxNameAccount.DataBindings.Add(new Binding("Text", dataGridViewAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            checkBoxAdmin.DataBindings.Add("Checked", dataGridViewAccount.DataSource, "Type", true, DataSourceUpdateMode.Never);
        }

        void LoadAccount()
        {
            listAccount.DataSource = AccountDAO.Instance.LoadListAccount();
        }

        void AddAccount(string username, string displayname, int type)
        {
            if(AccountDAO.Instance.InsertAccount(displayname, username, type))
            {
                MessageBox.Show("Thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thất Bại :(( !","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadAccount();
        } 
        void UpdateAccount(string username, string displayname, int type)
        {
            if(AccountDAO.Instance.UpdateAccount(username, displayname, type))
            {
                MessageBox.Show("Thành công!");
            }
            else
            {
                MessageBox.Show("Thất Bại :(( !");
            }
            LoadAccount();
        }

        void DeleteAccount(string username)
        {
            if (loginAccount.UserName.Equals(username)){
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập !");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(username))
            {
                MessageBox.Show("Thành công!");
            }
            else
            {
                MessageBox.Show("Thất Bại :(( !");
            }
            LoadAccount();
        } 
        void ResetAccount(string username)
        {
            if (AccountDAO.Instance.ResetAccount(username))
            {
                MessageBox.Show("Thành công - Mật khẩu mặc định là 1!");
            }
            else
            {
                MessageBox.Show("Thất Bại :(( !");
            }
            LoadAccount();
        }


        #endregion

        #region Category

        void LoadCategoryInComboBox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategories();
            cb.DisplayMember = "Name";
        }

        void LoadCategory()
        {
            listCategory.DataSource = CategoryDAO.Instance.GetListCategories();
        }

        void AddCategoryBinding()
        {
            textBoxIDCategory.DataBindings.Add(new Binding("text", listCategory, "ID", true, DataSourceUpdateMode.Never));
            textBoxNameCategory.DataBindings.Add(new Binding("text", listCategory, "Name", true, DataSourceUpdateMode.Never));
        }
        void UpdateCategory(string nameCategory, int id)
        {
            if (CategoryDAO.Instance.UpdateCategory(nameCategory, id))
            {
                MessageBox.Show("Thành công!");
            }
            else
            {
                MessageBox.Show("Thất Bại :(( !");
            }
            LoadCategory();

        }

        void AddCategory(string nameCategory)
        {
            if (CategoryDAO.Instance.InsertCategory(nameCategory))
            {
                MessageBox.Show("Thành công!");
            }
            else
            {
                MessageBox.Show("Thất Bại :(( !");
            }
            LoadCategory();

        }
        void DeleteCategory(int id)
        {
            if (CategoryDAO.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Thành công!");
            }
            else
            {
                MessageBox.Show("Thất Bại :(( !");
            }
            LoadCategory();

        }
        #endregion

        #endregion

        #region Events

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dateTimePickerCheckIn.Value, dateTimePickerCheckOut.Value);
        }
        private void buttonViewFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(dataGridViewFood.SelectedCells.Count > 0 )
                {
                    int id = (int)dataGridViewFood.SelectedCells[0].OwningRow.Cells["IDCategory"].Value;

                    Category category = CategoryDAO.Instance.GetListCategoryById(id);

                    int index = -1;
                    int i = 0;
                    foreach(Category item in comboBoxCategory.Items)
                    {
                        if(item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    comboBoxCategory.SelectedIndex = index;
                }
            }catch { }
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            string name = textBoxNameFood.Text;
            int idCategory = (comboBoxCategory.SelectedItem as Category).ID;
            float price = (float)numericUpDownPrice.Value;

            while(name == null )
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin món ăn", "Lỗi");
                name = textBoxNameFood.Text;
                idCategory = (comboBoxCategory.SelectedItem as Category).ID;
                price = (float)numericUpDownPrice.Value;
            }

            if(FoodDAO.Instance.InsertFood(name, idCategory, price))
            {
                MessageBox.Show("Thêm thành công.");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Thêm thất bại.", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void buttonChangeFood_Click(object sender, EventArgs e)
        {
            string name = textBoxNameFood.Text;
            int idCategory = (comboBoxCategory.SelectedItem as Category).ID;
            float price = (float)numericUpDownPrice.Value;
            int idFood = Convert.ToInt32(textBoxID.Text);

            if (FoodDAO.Instance.UpdateFood(name, idCategory, price, idFood))
            {
                MessageBox.Show("Sửa thành công.");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Sửa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteFood_Click(object sender, EventArgs e)
        {
            int idFood = Convert.ToInt32(textBoxID.Text);

            if (FoodDAO.Instance.DeleteFood( idFood))
            {
                MessageBox.Show("Xóa thành công.");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Xóa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string name = textBoxSearch.Text;
            listFood.DataSource= SearchFood(name);
        }

        private void buttonViewAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            string userName = textBoxNameAccount.Text;
            string displayName = textBoxDisplayName.Text;
            int type = 0;
            if(checkBoxAdmin.Checked) type = 1;
            AddAccount(userName, displayName, type);
        }

        private void buttonChangeAccount_Click(object sender, EventArgs e)
        {
            string userName = textBoxNameAccount.Text;
            string displayName = textBoxDisplayName.Text;
            int type = 0;
            if (checkBoxAdmin.Checked) type = 1;
            UpdateAccount(userName, displayName, type);
           
        }

        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = textBoxNameAccount.Text;
            DeleteAccount(userName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string userName = textBoxNameAccount.Text;
            ResetAccount(userName);
        }

        private void buttonViewCategory_Click(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            string name = textBoxNameCategory.Text;
            AddCategory(name);
        }

        private void buttonChangeCategory_Click(object sender, EventArgs e)
        {
            string name = textBoxNameCategory.Text;
            int id = Int32.Parse(textBoxIDCategory.Text);
            UpdateCategory(name, id);
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(textBoxIDCategory.Text);
            DeleteCategory(id);
        }
    }
        #endregion

}
