using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiceStore
{
    public class Rice
    {
        private string id;
        private string name;
        private string status;
        private int unitPrice;

        public Rice(string id, string name, string status, int unitPrice)
        {
            this.id = id;
            this.name = name;
            this.status = status;
            this.unitPrice = unitPrice;
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
        public string getStatus()
        {
            return status;
        }
        public void setStatus(string status)
        {
            this.status = status;
        }
        public int getUnitPrice()
        {
            return unitPrice;
        }
        public void setUnitPrice(int unitPrice)
        {
            this.unitPrice = unitPrice;
        }
    }
}
