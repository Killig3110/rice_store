using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiceStore
{
    public class CustomerCategory
    {
        private string id;
        private string name;

        public CustomerCategory(string id, string name)
        {
            this.id = id;
            this.name = name;
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
    }
}
