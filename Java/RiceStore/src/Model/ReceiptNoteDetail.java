package Model;
public class ReceiptNoteDetail {
    private double unitPrice;
    private double quantity;
    private String receptNoteID;
    private ReceiptNote receptNote;
    private String riceID;
    private Rice rice;

    public ReceiptNoteDetail(double quantity, double unitPrice,String receptNoteID, String riceID) {
        this.unitPrice = unitPrice;
        this.quantity = quantity;
        this.receptNoteID = receptNoteID;
        this.riceID = riceID;
    }

    public double getUnitPrice() {
        return unitPrice;
    }

    public void setUnitPrice(double unitPrice) {
        this.unitPrice = unitPrice;
    }

    public double getQuantity() {
        return quantity;
    }

    public void setQuantity(double quantity) {
        this.quantity = quantity;
    }

    public String getReceptNoteID() {
        return receptNoteID;
    }

    public void setReceptNoteID(String receptNoteID) {
        this.receptNoteID = receptNoteID;
    }

    public ReceiptNote getReceptNote() {
        return receptNote;
    }

    public void setReceptNote(ReceiptNote receptNote) {
        this.receptNote = receptNote;
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
