using RestaurantApp.DAO;
using RestaurantApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp
{
    public partial class fAccountProfile : Form
    {
 
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public fAccountProfile(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;
        }
        void ChangeAccount(Account acc)
        {
            textBoxDisplayName.Text = acc.DisplayName;
            textBoxUserName.Text = acc.UserName;
        }

        void UpdateAccount()
        {
            string DisplayName = textBoxDisplayName.Text;
            string Username = textBoxUserName.Text;
            string Password = textBoxPassword.Text;
            string NewPassword = textBoxnewPassword.Text;
            string RePassword = textBoxRePassword.Text;

            if(!NewPassword.Equals(RePassword))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!", "Lỗi");
            }
            else
            {
                if(AccountDAO.Instance.UpdateAccount(Username,DisplayName, Password, NewPassword))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi");
                }
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
