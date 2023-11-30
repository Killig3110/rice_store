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

        private string getId()
        {
            return id;
        }
        private void setId(string id)
        {
            this.id = id;
        }

        private string getName()
        {
            return name;
        }
        private void setName(string name)
        {
            this.name = name;
        }

        private bool getGender()
        {
            return gender;
        }
        private void setGender(bool gender)
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

        private CustomerCategory getCustomerCategory()
        {
            return customerCategory;
        }
        private void setCustomerCategory(CustomerCategory customerCategory)
        {
            this.customerCategory = customerCategory;
        }   
    }
}
