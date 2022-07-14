using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.DTO
{
    public class Food
    {
        public Food(int id, string name, int idCategory, float price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
            this.IDCategory = idCategory;
        }

        public Food(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.IDCategory = (int)row["idCategory"];
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iDCategory;

        public int IDCategory
        {
            get { return iDCategory; }
            set
            {
                iDCategory = value;
            }
        }

        private float price;

        public float Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }
    }
}
