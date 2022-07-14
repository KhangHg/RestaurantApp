using RestaurantApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.DAO
{
    public class AccountDAO
    {
        private static AccountDAO intance;

        public static AccountDAO Instance
        {
            get { if (intance == null) intance = new AccountDAO(); return intance; }
            private set { intance = value; }
        }

        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = "USP_Login @userName , @passWord";
            
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{ username, password});
            return result.Rows.Count > 0;
        }

        public bool UpdateAccount(string username , string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateAccount @userName , @displayName , @password , @newPassword ", new object[] { username, displayName, pass, newPass });

            //neu so dong lon hon 0 thi update
            return result > 0;
         }
        public Account GetAccountByUserName(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Account where UserName = '" + username +"'");

            foreach(DataRow row in data.Rows)
            {
                return new Account(row);
            }

            return null;
        }

        public List<Account> LoadListAccount()
        {
            List<Account> list = new List<Account>();

            string query = "select * from Account ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Account account= new Account(item);

                list.Add(account);
            }

            return list;
        }
      
        public bool InsertAccount(string displayname, string userName, int type)
        {
            string query = string.Format("insert Account  (UserName, DisplayName, Password, Type ) values (N'{0}', N'{1}', {2}, {3})", userName, displayname, '1', type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string displayname, string userName, int type)
        {
            string query = string.Format("update Account  set  displayname = N'{0}', type = {1} where username = N'{2}'", displayname, type, userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteAccount(string userName)
        {
            string query = string.Format("delete account where username = N'{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool ResetAccount(string userName)
        {
            string query = string.Format("Update account set password = N'{0}' where username = N'{1}'",'1', userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
      
    }
}
