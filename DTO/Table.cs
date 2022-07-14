using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.DTO
{
    public class Table
    {
        public Table(int id, string name, string status)
        {
            this.Id = id;
            this.TableName = name;
            this.Status = status;
        }

        public Table(DataRow row)
        {
            this.Id = (int)row["id"];
            this.TableName = row["name"].ToString();
            this.Status = row["status"].ToString();
        }


        private int id;

        public int Id
        {
            get { return id; }
            private set { id = value; }
        }

        private string tableName;

        public string TableName
        {
            get { return tableName; }
            private set { tableName = value; }
        }

        private string status;

        public string Status
        {
            get { return status; }
            private set { status = value; }
        }
    }
}
