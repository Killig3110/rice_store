package Model;
import java.util.Date;

public class Bill {
    private String id;
    private Date date;
    private String customerID;
    private Customer customer;
    private String staffID;
    private Staff staff;

    public Bill(String id, Date date, String customerID, String staffID) {
        this.id = id;
        this.date = date;
        this.customerID = customerID;
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

    public String getCustomerID() {
        return customerID;
    }

    public void setCustomerID(String customerID) {
        this.customerID = customerID;
    }

    public Customer getCustomer() {
        return customer;
    }

    public void setCustomer(Customer customer) {
        this.customer = customer;
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
