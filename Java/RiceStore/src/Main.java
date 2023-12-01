import java.util.ArrayList;
import java.util.Collections;
import java.util.Date;
import java.util.List;
import java.util.stream.Collectors;

import Model.*;
public class Main {

    private static ArrayList<Suplier> supliers;
    private static ArrayList<Staff> staffs;
    private static ArrayList<Rice> rices;
    private static ArrayList<RiceCategory> riceCategories;
    private static ArrayList<Customer> customers;
    private static ArrayList<CustomerCategory> customerCategories;
    private static ArrayList<Bill> bills;
    private static ArrayList<BillDetail> billDetails;
    private static ArrayList<ReceiptNote> receiptNotes;
    private static ArrayList<ReceiptNoteDetail> receiptNoteDetails;

    public static void main(String[] args) {
        supliers = new ArrayList<Suplier>();
        staffs = new ArrayList<Staff>();
        rices = new ArrayList<Rice>();
        riceCategories = new ArrayList<RiceCategory>();
        customers = new ArrayList<Customer>();
        customerCategories = new ArrayList<CustomerCategory>();
        bills = new ArrayList<Bill>();
        billDetails = new ArrayList<BillDetail>();
        receiptNotes = new ArrayList<ReceiptNote>();
        receiptNoteDetails = new ArrayList<ReceiptNoteDetail>();

        initData();
        cau1();
        System.out.println("_________________________");
        cau2();
        System.out.println("_________________________");
        cau3();
        System.out.println("_________________________");
    }

    static void initData() {
        supliers.add(new Suplier("S001", "Vinafood", "Hoàn Kiếm, Hà Nội", "0969811515"));
        supliers.add(new Suplier("S002", "Intimex Group", "Quận 1,Tp Hồ Chí Minh", "02838208052"));
        supliers.add(new Suplier("S003", "Tân Long Group", "Thanh Xuân, Hà Nội", "02466688666"));
        supliers.add(new Suplier("S004", "BRG Group", "Hoàn Kiếm, Hà Nội", "02439393691"));
        supliers.add(new Suplier("S005", "Donafood", "Biên Hòa, Đồng Nai", "02513892577"));
        supliers.add(new Suplier("S006", "Lộc Trời Group", "Phnom Penh, Campuchia", "(+855) 236 315 666"));

        riceCategories.add(new RiceCategory("RC01", "Gạo Ngon"));
        riceCategories.add(new RiceCategory("RC02", "Gạo Thường"));

        rices.add(new Rice("R001", "Gạo Nếp Cẩm", "Còn hàng", 45000, "S001", "RC01"));
        rices.add(new Rice("R002", "Gạo Nàng Thơm", "Còn hàng", 35000, "S002", "RC01"));
        rices.add(new Rice("R003", "Gạo Lức", "Còn hàng", 25000, "S003", "RC01"));
        rices.add(new Rice("R004", "Gạo Dẻo", "Còn hàng", 30000, "S004", "RC01"));
        rices.add(new Rice("R005", "Gạo Nở", "Còn hàng", 40000, "S005", "RC01"));
        rices.add(new Rice("R006", "Gạo Tám Xoan", "Còn hàng", 50000, "S006", "RC01"));
        rices.add(new Rice("R007", "Gạo Tám Thơm", "Còn hàng", 55000, "S001", "RC01"));
        rices.add(new Rice("R008", "Gạo Tám Hoa", "Còn hàng", 60000, "S002", "RC01"));
        rices.add(new Rice("R009", "Gạo Tám Phước Lộ", "Còn hàng", 65000, "S003", "RC01"));
        rices.add(new Rice("R010", "Gạo ST25", "Còn hàng", 70000, "S004", "RC01"));
        rices.add(new Rice("R011", "Gạo Nếp Cẩm", "Còn hàng", 45000, "S005", "RC02"));
        rices.add(new Rice("R012", "Gạo Nàng Thơm", "Còn hàng", 35000, "S006", "RC02"));
        rices.add(new Rice("R013", "Gạo Lức", "Còn hàng", 25000, "S001", "RC02"));
        rices.add(new Rice("R014", "Gạo Dẻo", "Còn hàng", 30000, "S002", "RC02"));
        rices.add(new Rice("R015", "Gạo Nở", "Còn hàng", 40000, "S003", "RC02"));
        rices.add(new Rice("R016", "Gạo Tám Xoan", "Còn hàng", 50000, "S004", "RC02"));
        rices.add(new Rice("R017", "Gạo Tám Thơm", "Còn hàng", 55000, "S005", "RC02"));
        rices.add(new Rice("R018", "Gạo Tám Hoa", "Còn hàng", 60000, "S006", "RC02"));
        rices.add(new Rice("R019", "Gạo Tám Phước Lộ", "Còn hàng", 65000, "S001", "RC02"));
        rices.add(new Rice("R020", "Gạo ST25", "Còn hàng", 70000, "S002", "RC02"));

        for (Rice item : rices)
        {
            if (item.getCategoryId() == "RC01")
            {
                item.setUnitPrice((int)(item.getUnitPrice() * 1.2));
            }
        }

        customerCategories.add(new CustomerCategory("CC01", "Thân Thiết"));
        customerCategories.add(new CustomerCategory("CC02", "Bình Thường"));

        customers.add(new Customer("C001", "Trần Thị Ngọc Tốt", false, "CC01"));
        customers.add(new Customer("C002", "Nguyễn Thị Thu An", false, "CC02"));
        customers.add(new Customer("C003", "Lý Thị Như ý", false, "CC02"));
        customers.add(new Customer("C004", "Nguyễn Thị Thanh Thảo", false, "CC01"));
        customers.add(new Customer("C005", "Lê Văn Phát", true, "CC01"));
        customers.add(new Customer("C006", "Phạm Trần Như Quỳnh", false, "CC02"));
        customers.add(new Customer("C007", "Nguyễn Văn Tiến Đạt", true, "CC01"));
        customers.add(new Customer("C008", "Nguyễn Thị Diễm Thúy", false, "CC02"));
        customers.add(new Customer("C009", "Nguyễn Thị Trà My", false, "CC01"));
        customers.add(new Customer("C010", "Phạm Nguyễn Tuyết Như", false, "CC02"));

        staffs.add(new Staff("ST001", "Nguyễn Văn A", "Ca Sáng", "Hà Nội", true, new Date(1999, 12, 22), "0325845489"));
        staffs.add(new Staff("ST002", "Nguyễn Thị B", "Ca Chiều", "Hà Nội", false, new Date(1999, 10, 14), "0397578059"));
        staffs.add(new Staff("ST003", "Trần Văn C", "Cả Ngày", "Hà Nội", true, new Date(1999, 02, 28), "0857139116"));

        bills.add(new Bill("B001", new Date(2021, 05, 1), "C001", "ST001"));
        bills.add(new Bill("B002", new Date(2021, 05, 2), "C002", "ST002"));
        bills.add(new Bill("B003", new Date(2021, 05, 3), "C003", "ST003"));
        bills.add(new Bill("B004", new Date(2021, 05, 4), "C004", "ST001"));
        bills.add(new Bill("B005", new Date(2021, 05, 5), "C005", "ST002"));
        bills.add(new Bill("B006", new Date(2021, 05, 6), "C006", "ST003"));
        bills.add(new Bill("B007", new Date(2021, 05, 7), "C007", "ST001"));
        bills.add(new Bill("B008", new Date(2021, 05, 8), "C008", "ST002"));
        bills.add(new Bill("B009", new Date(2021, 05, 9), "C009", "ST003"));
        bills.add(new Bill("B010", new Date(2021, 05, 10), "C010", "ST001"));
        bills.add(new Bill("B011", new Date(2021, 05, 11), "C001", "ST002"));
        bills.add(new Bill("B012", new Date(2021, 05, 12), "C002", "ST003"));
        bills.add(new Bill("B013", new Date(2021, 05, 13), "C003", "ST001"));
        bills.add(new Bill("B014", new Date(2021, 05, 14), "C004", "ST002"));
        bills.add(new Bill("B015", new Date(2021, 05, 15), "C005", "ST003"));
        bills.add(new Bill("B016", new Date(2021, 05, 16), "C006", "ST001"));
        bills.add(new Bill("B017", new Date(2021, 05, 17), "C007", "ST002"));
        bills.add(new Bill("B018", new Date(2021, 05, 18), "C008", "ST003"));
        bills.add(new Bill("B019", new Date(2021, 05, 19), "C009", "ST001"));
        bills.add(new Bill("B020", new Date(2021, 05, 20), "C010", "ST002"));
        bills.add(new Bill("B021", new Date(2021, 05, 21), "C001", "ST003"));
        bills.add(new Bill("B022", new Date(2021, 05, 22), "C002", "ST001"));
        bills.add(new Bill("B023", new Date(2021, 05, 23), "C003", "ST002"));
        bills.add(new Bill("B024", new Date(2021, 05, 24), "C004", "ST003"));
        bills.add(new Bill("B025", new Date(2021, 05, 25), "C005", "ST001"));
        bills.add(new Bill("B026", new Date(2021, 05, 26), "C006", "ST002"));
        bills.add(new Bill("B027", new Date(2021, 05, 27), "C007", "ST003"));
        bills.add(new Bill("B028", new Date(2021, 05, 28), "C008", "ST001"));
        bills.add(new Bill("B029", new Date(2021, 05, 29), "C009", "ST002"));
        bills.add(new Bill("B030", new Date(2021, 05, 30), "C010", "ST003"));

        billDetails.add(new BillDetail(10, "B001", "R001"));
        billDetails.add(new BillDetail(20, "B002", "R002"));
        billDetails.add(new BillDetail(30, "B003", "R003"));
        billDetails.add(new BillDetail(20, "B004", "R004"));
        billDetails.add(new BillDetail(35, "B005", "R005"));
        billDetails.add(new BillDetail(10, "B006", "R006"));
        billDetails.add(new BillDetail(45, "B007", "R007"));
        billDetails.add(new BillDetail(71, "B008", "R008"));
        billDetails.add(new BillDetail(65, "B009", "R009"));
        billDetails.add(new BillDetail(55, "B010", "R010"));
        billDetails.add(new BillDetail(15, "B011", "R011"));
        billDetails.add(new BillDetail(35, "B012", "R012"));
        billDetails.add(new BillDetail(50, "B013", "R013"));
        billDetails.add(new BillDetail(75, "B014", "R014"));
        billDetails.add(new BillDetail(10, "B015", "R015"));
        billDetails.add(new BillDetail(10, "B016", "R016"));
        billDetails.add(new BillDetail(20, "B017", "R017"));
        billDetails.add(new BillDetail(30, "B018", "R018"));
        billDetails.add(new BillDetail(20, "B019", "R019"));
        billDetails.add(new BillDetail(35, "B020", "R020"));
        billDetails.add(new BillDetail(10, "B021", "R001"));
        billDetails.add(new BillDetail(20, "B022", "R002"));
        billDetails.add(new BillDetail(30, "B023", "R003"));
        billDetails.add(new BillDetail(20, "B024", "R004"));
        billDetails.add(new BillDetail(35, "B025", "R005"));
        billDetails.add(new BillDetail(10, "B026", "R006"));
        billDetails.add(new BillDetail(45, "B027", "R007"));
        billDetails.add(new BillDetail(71, "B028", "R008"));
        billDetails.add(new BillDetail(65, "B029", "R009"));
        billDetails.add(new BillDetail(55, "B030", "R010"));

        receiptNotes.add(new ReceiptNote("RN001", new Date(2021, 05, 1), "Đảm bảo chất lượng", "S001", "ST001"));
        receiptNotes.add(new ReceiptNote("RN002", new Date(2021, 05, 2), "Đảm bảo chất lượng", "S002", "ST002"));
        receiptNotes.add(new ReceiptNote("RN003", new Date(2021, 05, 3), "Không Đảm bảo chất lượng", "S003", "ST003"));
        receiptNotes.add(new ReceiptNote("RN004", new Date(2021, 05, 4), "Đảm bảo chất lượng", "S004", "ST001"));
        receiptNotes.add(new ReceiptNote("RN005", new Date(2021, 05, 5), "Đảm bảo chất lượng", "S005", "ST002"));
        receiptNotes.add(new ReceiptNote("RN006", new Date(2021, 05, 6), "Không Đảm bảo chất lượng", "S006", "ST003"));
        receiptNotes.add(new ReceiptNote("RN007", new Date(2021, 05, 7), "Đảm bảo chất lượng", "S001", "ST001"));
        receiptNotes.add(new ReceiptNote("RN008", new Date(2021, 05, 8), "Đảm bảo chất lượng", "S002", "ST002"));
        receiptNotes.add(new ReceiptNote("RN009", new Date(2021, 05, 9), "Không Đảm bảo chất lượng", "S003", "ST003"));
        receiptNotes.add(new ReceiptNote("RN010", new Date(2021, 05, 10), "Đảm bảo chất lượng", "S004", "ST001"));
        receiptNotes.add(new ReceiptNote("RN011", new Date(2021, 05, 11), "Đảm bảo chất lượng", "S005", "ST002"));
        receiptNotes.add(new ReceiptNote("RN012", new Date(2021, 05, 12), "Không Đảm bảo chất lượng", "S006", "ST003"));
        receiptNotes.add(new ReceiptNote("RN013", new Date(2021, 05, 13), "Đảm bảo chất lượng", "S001", "ST001"));
        receiptNotes.add(new ReceiptNote("RN014", new Date(2021, 05, 14), "Đảm bảo chất lượng", "S002", "ST002"));
        receiptNotes.add(new ReceiptNote("RN015", new Date(2021, 05, 15), "Không Đảm bảo chất lượng", "S003", "ST003"));
        receiptNotes.add(new ReceiptNote("RN016", new Date(2021, 05, 16), "Đảm bảo chất lượng", "S004", "ST001"));
        receiptNotes.add(new ReceiptNote("RN017", new Date(2021, 05, 17), "Đảm bảo chất lượng", "S005", "ST002"));
        receiptNotes.add(new ReceiptNote("RN018", new Date(2021, 05, 18), "Không Đảm bảo chất lượng", "S006", "ST003"));
        receiptNotes.add(new ReceiptNote("RN019", new Date(2021, 05, 19), "Đảm bảo chất lượng", "S001", "ST001"));
        receiptNotes.add(new ReceiptNote("RN020", new Date(2021, 05, 20), "Đảm bảo chất lượng", "S002", "ST002"));
        receiptNotes.add(new ReceiptNote("RN021", new Date(2021, 05, 21), "Không Đảm bảo chất lượng", "S003", "ST003"));
        receiptNotes.add(new ReceiptNote("RN022", new Date(2021, 05, 22), "Đảm bảo chất lượng", "S004", "ST001"));
        receiptNotes.add(new ReceiptNote("RN023", new Date(2021, 05, 23), "Đảm bảo chất lượng", "S005", "ST002"));
        receiptNotes.add(new ReceiptNote("RN024", new Date(2021, 05, 24), "Không Đảm bảo chất lượng", "S006", "ST003"));
        receiptNotes.add(new ReceiptNote("RN025", new Date(2021, 05, 25), "Đảm bảo chất lượng", "S001", "ST001"));
        receiptNotes.add(new ReceiptNote("RN026", new Date(2021, 05, 26), "Đảm bảo chất lượng", "S002", "ST002"));
        receiptNotes.add(new ReceiptNote("RN027", new Date(2021, 05, 27), "Không Đảm bảo chất lượng", "S003", "ST003"));
        receiptNotes.add(new ReceiptNote("RN028", new Date(2021, 05, 28), "Đảm bảo chất lượng", "S004", "ST001"));
        receiptNotes.add(new ReceiptNote("RN029", new Date(2021, 05, 29), "Đảm bảo chất lượng", "S005", "ST002"));
        receiptNotes.add(new ReceiptNote("RN030", new Date(2021, 05, 30), "Không Đảm bảo chất lượng", "S006", "ST003"));

        receiptNoteDetails.add(new ReceiptNoteDetail(100, 45000, "RN001", "R001"));
        receiptNoteDetails.add(new ReceiptNoteDetail(200, 35000, "RN002", "R002"));
        receiptNoteDetails.add(new ReceiptNoteDetail(300, 25000, "RN003", "R003"));
        receiptNoteDetails.add(new ReceiptNoteDetail(200, 30000, "RN004", "R004"));
        receiptNoteDetails.add(new ReceiptNoteDetail(350, 40000, "RN005", "R005"));
        receiptNoteDetails.add(new ReceiptNoteDetail(100, 50000, "RN006", "R006"));
        receiptNoteDetails.add(new ReceiptNoteDetail(450, 55000, "RN007", "R007"));
        receiptNoteDetails.add(new ReceiptNoteDetail(710, 60000, "RN008", "R008"));
        receiptNoteDetails.add(new ReceiptNoteDetail(650, 65000, "RN009", "R009"));
        receiptNoteDetails.add(new ReceiptNoteDetail(550, 70000, "RN010", "R010"));
        receiptNoteDetails.add(new ReceiptNoteDetail(150, 45000, "RN011", "R011"));
        receiptNoteDetails.add(new ReceiptNoteDetail(350, 35000, "RN012", "R012"));
        receiptNoteDetails.add(new ReceiptNoteDetail(500, 25000, "RN013", "R013"));
        receiptNoteDetails.add(new ReceiptNoteDetail(750, 30000, "RN014", "R014"));
        receiptNoteDetails.add(new ReceiptNoteDetail(100, 40000, "RN015", "R015"));
        receiptNoteDetails.add(new ReceiptNoteDetail(100, 45000, "RN016", "R016"));
        receiptNoteDetails.add(new ReceiptNoteDetail(200, 35000, "RN017", "R017"));
        receiptNoteDetails.add(new ReceiptNoteDetail(300, 25000, "RN018", "R018"));
        receiptNoteDetails.add(new ReceiptNoteDetail(200, 30000, "RN019", "R019"));
        receiptNoteDetails.add(new ReceiptNoteDetail(350, 40000, "RN020", "R020"));
        receiptNoteDetails.add(new ReceiptNoteDetail(100, 50000, "RN021", "R001"));
        receiptNoteDetails.add(new ReceiptNoteDetail(200, 55000, "RN022", "R002"));
        receiptNoteDetails.add(new ReceiptNoteDetail(300, 60000, "RN023", "R003"));
        receiptNoteDetails.add(new ReceiptNoteDetail(200, 65000, "RN024", "R004"));
        receiptNoteDetails.add(new ReceiptNoteDetail(350, 70000, "RN025", "R005"));
        receiptNoteDetails.add(new ReceiptNoteDetail(100, 45000, "RN026", "R006"));
        receiptNoteDetails.add(new ReceiptNoteDetail(450, 35000, "RN027", "R007"));
        receiptNoteDetails.add(new ReceiptNoteDetail(710, 25000, "RN028", "R008"));
        receiptNoteDetails.add(new ReceiptNoteDetail(650, 30000, "RN029", "R009"));
        receiptNoteDetails.add(new ReceiptNoteDetail(550, 40000, "RN030", "R010"));

        for (ReceiptNoteDetail item : receiptNoteDetails)
        {
            item.setUnitPrice((int)(item.getUnitPrice() * 0.8));
        }
    }

    static void  cau1() {
        System.out.println("Câu 1: Tính và in ra tổng doanh thu từng ngày.");
        int count = 0;
        int result = 0;
        int total = 0;
        for (Bill item : bills)
        {
            count++;

            result +=  billDetails.stream()
                    .filter(billDetail -> billDetail.getBillID() == item.getId())
                    .mapToInt(billDetail -> billDetail.getQuantity() * rices.stream().
                            filter(rice -> rice.getId() == billDetail.getRiceID())
                            .findFirst()
                            .get()
                            .getUnitPrice())
                    .sum();

            if(count % 7 == 0)
            {
                System.out.println("Tổng doanh thu tuần thứ " + count / 7 + " là: " + result);
                total += result;
                result = 0;
            }
            if(count % 30 == 0)
            {
                System.out.println("Tổng doanh thu tháng thứ " + item.getDate().getMonth() + " là: " + total);
                total = 0;
                result = 0;
                count = 0;
            }
        }
    }

    static void cau2() {
        System.out.println("Tính và in ra tổng số tiền mua hàng của từng khách hàng. ");
        for (Customer item : customers) {
            int result = 0;
            for (Bill bill : bills) {
                if (bill.getCustomerID() == item.getId()) {
                    result = billDetails.stream()
                            .filter(billDetail -> billDetail.getBillID() == bill.getId())
                            .mapToInt(billDetail -> billDetail.getQuantity() * rices.stream().
                                    filter(rice -> rice.getId() == billDetail.getRiceID())
                                    .findFirst()
                                    .get()
                                    .getUnitPrice())
                            .sum();
                }
            }
            System.out.println("Tổng số tiền mua hàng của khách hàng " + item.getName() + " là: " + result);
        }
    }

    static void cau3() {
        System.out.println("Tính và in ra tổng số lượng gạo đảm bảo chất lượng và không đảm bảo chất lương. Tìm và in ra các nhà cung cấp cung cấp gạo không đảm bảo chất lương.");
        //tổng số lượng gạo đảm bảo chất lượng của từng loại gạo. Nếu trùng tên thì cộng dồn số lượng

        for (Rice item : rices) {
            int result = receiptNoteDetails.stream()
                    .filter(receiptNoteDetail -> receiptNoteDetail.getRiceID() == item.getId())
                    .receiptNotes.stream()
                    .mapToInt(receiptNoteDetail -> (int) receiptNoteDetail.getQuantity())
                    .sum();
            System.out.println("Tổng số lượng gạo đảm bảo chất lượng của loại gạo " + item.getName() + "- " + item.getCategoryId() + " là: " + result);
        }


    }
}