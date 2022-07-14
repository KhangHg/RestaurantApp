using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.DTO
{
    public class Account
    {
        public Account(string username,  string displayname, int type ,string password = null)
        {
            this.UserName = username;
            this.PassWord = password;
            this.DisplayName = displayname;
            this.Type = type;
        }

        public Account(DataRow  row)
        {
            this.UserName = row["username"].ToString();
            this.PassWord = row["password"].ToString();
            this.DisplayName = row["displayname"].ToString();
            this.Type = (int)row["type"];
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        private string passWord;
        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        private int type;

        public int Type
        {
            get { return type; }
            set
            {
                type = value;
            }
        }
    }
}
