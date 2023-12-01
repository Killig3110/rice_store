package Model;
public class Rice {
    private String id;
    private String name;
    private String status;
    private int unitPrice;

    private String supplierId;
    private Suplier suplier;
    private String categoryId;
    private RiceCategory category;

    public Rice(String id, String name, String status, int unitPrice, String supplierId, String categoryId) {
        this.id = id;
        this.name = name;
        this.status = status;
        this.unitPrice = unitPrice;
        this.supplierId = supplierId;
        this.categoryId = categoryId;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

    public int getUnitPrice() {
        return unitPrice;
    }

    public void setUnitPrice(int unitPrice) {
        this.unitPrice = unitPrice;
    }

    public String getSupplierId() {
        return supplierId;
    }

    public void setSupplierId(String supplierId) {
        this.supplierId = supplierId;
    }

    public Suplier getSuplier() {
        return suplier;
    }

    public void setSuplier(Suplier suplier) {
        this.suplier = suplier;
    }

    public String getCategoryId() {
        return categoryId;
    }

    public void setCategoryId(String categoryId) {
        this.categoryId = categoryId;
    }

    public RiceCategory getCategory() {
        return category;
    }

    public void setCategory(RiceCategory category) {
        this.category = category;
    }
}
