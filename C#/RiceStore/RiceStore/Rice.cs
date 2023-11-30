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
        
        private string supplierId;
        private Suplier suplier;
        private string categoryId;
        private RiceCategory category;

        public Rice(string id, string name, string status, int unitPrice, string supplierId, string categoryId)
        {
            this.id = id;
            this.name = name;
            this.status = status;
            this.unitPrice = unitPrice;
            this.supplierId = supplierId;
            this.categoryId = categoryId;
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
        public string getSupplierId()
        {
            return supplierId;
        }
        public void setSupplierId(string supplierId)
        {
            this.supplierId = supplierId;
        }
        public Suplier getSuplier()
        {
            return suplier;
        }
        public void setSuplier(Suplier suplier)
        {
            this.suplier = suplier;
        }
        public string getCategoryId()
        {
            return categoryId;
        }
        public void setCategoryId(string categoryId)
        {
            this.categoryId = categoryId;
        }
        public RiceCategory getCategory()
        {
            return category;
        }
        public void setCategory(RiceCategory category)
        {
            this.category = category;
        }
    }
}
