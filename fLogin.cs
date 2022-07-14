using RestaurantApp.DAO;
using RestaurantApp.DTO;

namespace RestaurantApp
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            if (Login(username,password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(username);
                fTableManager f = new fTableManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        bool Login(string username , string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private void buttonlLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}