using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiceStore
{
    public class ReceptNote
    {
        //generate constructor with ReceptNote (id, date, moreInfo, suplierID, staffID)
        private string id;
        private DateTime date;
        private string moreInfo;

        private string suplierID;
        private Suplier suplier;
        private string staffID;
        private Staff staff;

        public ReceptNote(string id, DateTime date, string moreInfo, string suplierID, string staffID)
        {
            this.id = id;
            this.date = date;
            this.moreInfo = moreInfo;
            this.suplierID = suplierID;
            this.staffID = staffID;
        }

        public string getId()
        {
            return id;
        }
        public void setId(string id)
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
        public string getMoreInfo()
        {
            return moreInfo;
        }
        public void setMoreInfo(string moreInfo)
        {
            this.moreInfo = moreInfo;
        }
        public string getSuplierID()
        {
            return suplierID;
        }
        public void setSuplierID(string suplierID)
        {
            this.suplierID = suplierID;
        }
        public Suplier getSuplier()
        {
            return suplier;
        }
        public void setSuplier(Suplier suplier)
        {
            this.suplier = suplier;
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
