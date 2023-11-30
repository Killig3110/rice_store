using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiceStore
{
    public class BillDetail
    {
        private int quantity;

        private string billID;
        private Bill bill;
        private string riceID;
        private Rice rice;

        public BillDetail(int quantity, string billID, string riceID)
        {
            this.quantity = quantity;
            this.billID = billID;
            this.riceID = riceID;
        }

        public int getQuantity()
        {
            return quantity;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public string getBillID()
        {
            return billID;
        }
        public void setBillID(string billID)
        {
            this.billID = billID;
        }
        public string getRiceID()
        {
            return riceID;
        }
        public void setRiceID(string riceID)
        {
            this.riceID = riceID;
        }
        public Bill getBill()
        {
            return bill;
        }
        public void setBill(Bill bill)
        {
            this.bill = bill;
        }
        public Rice getRice()
        {
            return rice;
        }
        public void setRice(Rice rice)
        {
            this.rice = rice;
        }
    }
}
