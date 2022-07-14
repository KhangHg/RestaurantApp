using RestaurantApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }

        private FoodDAO() { }

        public List<Food> GetListFood(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food where idCategory = "+ id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);

                list.Add(food);
            }

            return list;
        }

        public List<Food> LoadListFood()
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);

                list.Add(food);
            }

            return list;
        }

        public bool InsertFood(string name, int id , float price)
        {
            string query = string.Format("insert Food  (name, idCategory, price ) values (N'{0}', {1}, {2})", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateFood(string name, int idCategory, float price, int idFood)
        {
            string query = string.Format("update Food  set name = N'{0}', idCategory = {1}, price = {2} where id = {3}", name, idCategory, price, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteFood( int idFood)
        {
            BillInfoDAO.Instance.DeleteBillInfo(idFood);
            string query = string.Format("delete food where id = {0}", idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<Food> SearchFoodByName(string name)
        {
            string query = string.Format("Select * from Food where name like N'%{0}%'", name);

            List<Food> list = new List<Food>();

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);

                list.Add(food);
            }

            return list;

        }
    }
}
