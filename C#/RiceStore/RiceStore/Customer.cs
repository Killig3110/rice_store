using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiceStore
{
    public class Customer
    {
        private string id;
        private string name;
        private bool gender;

        private string categoryID;
        private CustomerCategory customerCategory;

        public Customer(string id, string name, bool gender, string categoryID)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.categoryID = categoryID;
        }

        public string getId()
        {
            return id;
        }
        public void setId(string id)
        {
            this.id = id;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public bool getGender()
        {
            return gender;
        }
        public void setGender(bool gender)
        {
            this.gender = gender;
        }

        public string getCategoryID()
        {
            return categoryID;
        }

        public void setCategoryID(string categoryID)
        {
            this.categoryID = categoryID;
        }

        public CustomerCategory getCustomerCategory()
        {
            return customerCategory;
        }
        public void setCustomerCategory(CustomerCategory customerCategory)
        {
            this.customerCategory = customerCategory;
        }   
    }
}
