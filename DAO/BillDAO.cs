using RestaurantApp.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        public int GetUnCheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Bill where idTable = " + id + "and status = 0");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }

        public void CheckOut(int id, int discount, float totalPrice)
        {
            string query = "update Bill set DateCheckOut = GETUTCDATE(), totalPrice = " + totalPrice + ", status = 1 " + ", discount = " + discount + " where id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_InsertBill @idTable", new object[] { id });
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("Select max(id) from bill");
            }
            catch
            {
                return 1;
            }

        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            string query = "exec USP_GetListBillByDate @dateCheckIn , @dateCheckOut";
            return DataProvider.Instance.ExecuteQuery(query, new object[] {checkIn, checkOut});
        }
    }

}
