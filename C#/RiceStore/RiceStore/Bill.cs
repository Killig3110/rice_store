using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiceStore
{
    public class Bill
    {
        private string id;
        private DateTime date;
        private string status;

        private string customerID;
        private Customer customer;
        private string staffID;
        private Staff staff;

        public Bill(string id, DateTime date, string customerID, string staffID)
        {
            this.id = id;
            this.date = date;
            this.customerID = customerID;
            this.staffID = staffID;
        }

        public string getID()
        {
            return id;
        }
        public void setID(string id)
        {
            this.id = id;
        }
        public DateTime getDate()
        {
               return date;
        }
        public void setDate(DateTime date)
        {
            this.date = date;
        }
        public string getStatus()
        {
            return status;
        }
        public void setStatus(string status)
        {
            this.status = status;
        }
        public string getCustomerID()
        {
            return customerID;
        }
        public void setCustomerID(string customerID)
        {
            this.customerID = customerID;
        }
        public Customer getCustomer()
        {
            return customer;
        }
        public void setCustomer(Customer customer)
        {
            this.customer = customer;
        }
        public string getStaffID()
        {
            return staffID;
        }
        public void setStaffID(string staffID)
        {
            this.staffID = staffID;
        }
        public Staff getStaff()
        {
            return staff;
        }
        public void setStaff(Staff staff)
        {
            this.staff = staff;
        }
    }
}
