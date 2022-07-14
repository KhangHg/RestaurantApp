﻿using RestaurantApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set { instance = value; }
        }

        private MenuDAO() { }
         
        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu> ();

            string query = "SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f WHERE bi.idBill = b.id and b.status = 0 AND bi.idFood = f.id AND b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item  in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
