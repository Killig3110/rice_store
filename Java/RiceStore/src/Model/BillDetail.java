package Model;
public class BillDetail {
    private int quantity;

    private String billID;
    private Bill bill;
    private String riceID;
    private Rice rice;

    public BillDetail(int quantity, String billID, String riceID) {
        this.quantity = quantity;
        this.billID = billID;
        this.riceID = riceID;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    public String getBillID() {
        return billID;
    }

    public void setBillID(String billID) {
        this.billID = billID;
    }

    public Bill getBill() {
        return bill;
    }

    public void setBill(Bill bill) {
        this.bill = bill;
    }

    public String getRiceID() {
        return riceID;
    }

    public void setRiceID(String riceID) {
        this.riceID = riceID;
    }

    public Rice getRice() {
        return rice;
    }

    public void setRice(Rice rice) {
        this.rice = rice;
    }
}
