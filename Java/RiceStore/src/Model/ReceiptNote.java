package Model;
import java.util.Date;

public class ReceiptNote {
    private String id;
    private Date date;
    private String moreInfo;

    private String suplierID;
    private Suplier suplier;
    private String staffID;
    private Staff staff;

    public ReceiptNote(String id, Date date, String moreInfo, String suplierID, String staffID) {
        this.id = id;
        this.date = date;
        this.moreInfo = moreInfo;
        this.suplierID = suplierID;
        this.staffID = staffID;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public Date getDate() {
        return date;
    }

    public void setDate(Date date) {
        this.date = date;
    }

    public String getMoreInfo() {
        return moreInfo;
    }

    public void setMoreInfo(String moreInfo) {
        this.moreInfo = moreInfo;
    }

    public String getSuplierID() {
        return suplierID;
    }

    public void setSuplierID(String suplierID) {
        this.suplierID = suplierID;
    }

    public Suplier getSuplier() {
        return suplier;
    }

    public void setSuplier(Suplier suplier) {
        this.suplier = suplier;
    }

    public String getStaffID() {
        return staffID;
    }

    public void setStaffID(String staffID) {
        this.staffID = staffID;
    }

    public Staff getStaff() {
        return staff;
    }

    public void setStaff(Staff staff) {
        this.staff = staff;
    }
}
