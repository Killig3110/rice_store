using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiceStore
{
    public class ReceptNoteDetail
    {
        private double unitPrice;
        private double quantity;
        private string receptNoteID;
        private ReceptNote receptNote;
        private string riceID;
        private Rice rice;

        public ReceptNoteDetail(int unitPrice, int quantity, string receptNoteID, string riceID)
        {
            this.unitPrice = unitPrice;
            this.quantity = quantity;
            this.receptNoteID = receptNoteID;
            this.riceID = riceID;
        }

        public double getUnitPrice()
        {
            return unitPrice;
        }
        public void setUnitPrice(int unitPrice)
        {
            this.unitPrice = unitPrice;
        }
        public double getQuantity()
        {
            return quantity;
        }
        public void setQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public string getReceptNoteID()
        {
            return receptNoteID;
        }
        public void setReceptNoteID(string receptNoteID)
        {
            this.receptNoteID = receptNoteID;
        }
        public string getRiceID()
        {
            return riceID;
        }
        public void setRiceID(string riceID)
        {
            this.riceID = riceID;
        }
        public ReceptNote getReceptNote()
        {
            return receptNote;
        }
        public void setReceptNoteID(ReceptNote receptNote)
        {
            this.receptNote = receptNote;
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
