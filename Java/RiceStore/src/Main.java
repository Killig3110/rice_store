import java.util.*;
import java.util.function.Supplier;
import java.util.stream.Collectors;

import Model.*;

import static java.util.AbstractMap.*;

public class Main {

    private static ArrayList<Suplier> supliers;
    private static ArrayList<Staff> staffs;
    private static ArrayList<Rice> rices;
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
        cau4();
        System.out.println("_________________________");
        cau5();
        System.out.println("_________________________");
        cau6();
        System.out.println("_________________________");
        cau7();
        System.out.println("_________________________");
        cau8();
        System.out.println("_________________________");
        cau9();
        System.out.println("_________________________");
        cau10();
        System.out.println("_________________________");
        cauHoiThem();
        System.out.println("_________________________");
    }

    static void initData() {
        supliers.add(new Suplier("S001", "Vinafood", "Hoàn Kiếm, Hà Nội", "0969811515"));
        supliers.add(new Suplier("S002", "Intimex Group", "Quận 1,Tp Hồ Chí Minh", "02838208052"));
        supliers.add(new Suplier("S003", "Tân Long Group", "Thanh Xuân, Hà Nội", "02466688666"));
        supliers.add(new Suplier("S004", "BRG Group", "Hoàn Kiếm, Hà Nội", "02439393691"));
        supliers.add(new Suplier("S005", "Donafood", "Biên Hòa, Đồng Nai", "02513892577"));
        supliers.add(new Suplier("S006", "Lộc Trời Group", "Phnom Penh, Campuchia", "(+855) 236 315 666"));

        rices.add(new Rice("R001", "Gạo Nếp Cẩm", "Còn hàng", 45000));
        rices.add(new Rice("R002", "Gạo Nàng Thơm", "Còn hàng", 35000));
        rices.add(new Rice("R003", "Gạo Lức", "Còn hàng", 25000));
        rices.add(new Rice("R004", "Gạo Dẻo", "Còn hàng", 30000));
        rices.add(new Rice("R005", "Gạo Nở", "Còn hàng", 40000));
        rices.add(new Rice("R006", "Gạo Tám Xoan", "Còn hàng", 50000));
        rices.add(new Rice("R007", "Gạo Tám Thơm", "Còn hàng", 55000));
        rices.add(new Rice("R008", "Gạo Tám Hoa", "Còn hàng", 60000));
        rices.add(new Rice("R009", "Gạo Tám Phước Lộ", "Còn hàng", 65000));
        rices.add(new Rice("R010", "Gạo ST25", "Còn hàng", 70000));

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

        staffs.add(new Staff("ST001", "Nguyễn Văn A", "Ca Sáng", "Hà Nội", true, new Date(1999,11,22), "0325845489"));
        staffs.add(new Staff("ST002", "Nguyễn Thị B", "Ca Chiều", "Hà Nội", false, new Date(1999,9,14), "0397578059"));
        staffs.add(new Staff("ST003", "Trần Văn C", "Cả Ngày", "Hà Nội", true, new Date(1999,1,28), "0857139116"));

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
        billDetails.add(new BillDetail(40, "B004", "R004"));
        billDetails.add(new BillDetail(50, "B005", "R005"));
        billDetails.add(new BillDetail(60, "B006", "R006"));
        billDetails.add(new BillDetail(70, "B007", "R007"));
        billDetails.add(new BillDetail(80, "B008", "R008"));
        billDetails.add(new BillDetail(90, "B009", "R009"));
        billDetails.add(new BillDetail(10, "B010", "R010"));
        billDetails.add(new BillDetail(15, "B001", "R010"));
        billDetails.add(new BillDetail(20, "B002", "R009"));
        billDetails.add(new BillDetail(25, "B003", "R008"));
        billDetails.add(new BillDetail(30, "B004", "R007"));
        billDetails.add(new BillDetail(35, "B005", "R006"));
        billDetails.add(new BillDetail(40, "B006", "R005"));
        billDetails.add(new BillDetail(45, "B007", "R004"));
        billDetails.add(new BillDetail(50, "B008", "R003"));
        billDetails.add(new BillDetail(55, "B009", "R002"));
        billDetails.add(new BillDetail(60, "B010", "R001"));
        billDetails.add(new BillDetail(65, "B011", "R005"));
        billDetails.add(new BillDetail(70, "B012", "R006"));
        billDetails.add(new BillDetail(75, "B013", "R007"));
        billDetails.add(new BillDetail(80, "B014", "R008"));
        billDetails.add(new BillDetail(85, "B015", "R009"));
        billDetails.add(new BillDetail(90, "B016", "R010"));
        billDetails.add(new BillDetail(95, "B017", "R001"));
        billDetails.add(new BillDetail(21, "B018", "R002"));
        billDetails.add(new BillDetail(22, "B019", "R003"));
        billDetails.add(new BillDetail(23, "B020", "R004"));
        billDetails.add(new BillDetail(24, "B020", "R003"));
        billDetails.add(new BillDetail(25, "B021", "R006"));
        billDetails.add(new BillDetail(26, "B022", "R009"));
        billDetails.add(new BillDetail(27, "B023", "R002"));
        billDetails.add(new BillDetail(28, "B024", "R005"));
        billDetails.add(new BillDetail(29, "B025", "R008"));
        billDetails.add(new BillDetail(30, "B026", "R001"));
        billDetails.add(new BillDetail(31, "B027", "R004"));
        billDetails.add(new BillDetail(32, "B028", "R007"));
        billDetails.add(new BillDetail(33, "B029", "R010"));
        billDetails.add(new BillDetail(34, "B030", "R003"));
        billDetails.add(new BillDetail(35, "B025", "R006"));
        billDetails.add(new BillDetail(36, "B024", "R009"));
        billDetails.add(new BillDetail(37, "B023", "R011"));
        billDetails.add(new BillDetail(38, "B022", "R005"));
        billDetails.add(new BillDetail(39, "B021", "R007"));
        billDetails.add(new BillDetail(40, "B020", "R010"));
        billDetails.add(new BillDetail(41, "B019", "R001"));
        billDetails.add(new BillDetail(42, "B018", "R002"));
        billDetails.add(new BillDetail(43, "B017", "R003"));
        billDetails.add(new BillDetail(44, "B016", "R004"));
        billDetails.add(new BillDetail(45, "B015", "R005"));
        billDetails.add(new BillDetail(46, "B014", "R006"));
        billDetails.add(new BillDetail(47, "B013", "R003"));
        billDetails.add(new BillDetail(48, "B012", "R002"));
        billDetails.add(new BillDetail(49, "B011", "R001"));
        billDetails.add(new BillDetail(50, "B010", "R010"));
        billDetails.add(new BillDetail(51, "B009", "R004"));
        billDetails.add(new BillDetail(52, "B008", "R005"));
        billDetails.add(new BillDetail(53, "B007", "R006"));
        billDetails.add(new BillDetail(54, "B006", "R007"));
        billDetails.add(new BillDetail(55, "B005", "R008"));
        billDetails.add(new BillDetail(56, "B004", "R009"));
        billDetails.add(new BillDetail(57, "B003", "R010"));

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

        receiptNoteDetails.add(new ReceiptNoteDetail(100, 50000, "RN001", "R001"));
        receiptNoteDetails.add(new ReceiptNoteDetail(200, 55000, "RN001", "R007"));
        receiptNoteDetails.add(new ReceiptNoteDetail(300, 35000, "RN002", "R002"));
        receiptNoteDetails.add(new ReceiptNoteDetail(400, 60000, "RN002", "R008"));
        receiptNoteDetails.add(new ReceiptNoteDetail(500, 25000, "RN003", "R003"));
        receiptNoteDetails.add(new ReceiptNoteDetail(600, 65000, "RN003", "R009"));
        receiptNoteDetails.add(new ReceiptNoteDetail(700, 30000, "RN004", "R004"));
        receiptNoteDetails.add(new ReceiptNoteDetail(800, 70000, "RN004", "R010"));
        receiptNoteDetails.add(new ReceiptNoteDetail(900, 40000, "RN005", "R005"));
        receiptNoteDetails.add(new ReceiptNoteDetail(1000, 45000, "RN006", "R006"));
        receiptNoteDetails.add(new ReceiptNoteDetail(1100, 50000, "RN007", "R001"));
        receiptNoteDetails.add(new ReceiptNoteDetail(1200, 55000, "RN007", "R007"));
        receiptNoteDetails.add(new ReceiptNoteDetail(1300, 35000, "RN008", "R002"));
        receiptNoteDetails.add(new ReceiptNoteDetail(1400, 60000, "RN008", "R008"));
        receiptNoteDetails.add(new ReceiptNoteDetail(1500, 25000, "RN009", "R003"));
        receiptNoteDetails.add(new ReceiptNoteDetail(1600, 65000, "RN009", "R009"));
        receiptNoteDetails.add(new ReceiptNoteDetail(1700, 30000, "RN010", "R004"));
        receiptNoteDetails.add(new ReceiptNoteDetail(1800, 70000, "RN010", "R010"));
        receiptNoteDetails.add(new ReceiptNoteDetail(1900, 40000, "RN011", "R005"));
        receiptNoteDetails.add(new ReceiptNoteDetail(2000, 45000, "RN012", "R006"));
        receiptNoteDetails.add(new ReceiptNoteDetail(2100, 50000, "RN013", "R001"));
        receiptNoteDetails.add(new ReceiptNoteDetail(2200, 55000, "RN013", "R007"));
        receiptNoteDetails.add(new ReceiptNoteDetail(2300, 35000, "RN014", "R002"));
        receiptNoteDetails.add(new ReceiptNoteDetail(2400, 60000, "RN014", "R008"));
        receiptNoteDetails.add(new ReceiptNoteDetail(2500, 25000, "RN015", "R003"));
        receiptNoteDetails.add(new ReceiptNoteDetail(2600, 65000, "RN015", "R009"));
        receiptNoteDetails.add(new ReceiptNoteDetail(2700, 30000, "RN016", "R004"));
        receiptNoteDetails.add(new ReceiptNoteDetail(2800, 70000, "RN016", "R010"));
        receiptNoteDetails.add(new ReceiptNoteDetail(2900, 40000, "RN017", "R005"));
        receiptNoteDetails.add(new ReceiptNoteDetail(3000, 45000, "RN018", "R006"));


        for (ReceiptNoteDetail item : receiptNoteDetails)
        {
            item.setUnitPrice((int)(item.getUnitPrice() * 0.8));
        }
    }

    static void  cau1() {
        System.out.println("Câu 1: Tính và in ra tổng doanh thu từng ngày.");
        Map<Date, Integer> map = bills.stream()
                .collect(Collectors.groupingBy(Bill::getDate,
                        Collectors.summingInt(bill -> billDetails.stream()
                                .filter(billDetail -> billDetail.getBillID() == bill.getId())
                                .mapToInt(billDetail -> (int) billDetail.getQuantity() * rices.stream()
                                        .filter(rice -> rice.getId() == billDetail.getRiceID())
                                        .findFirst()
                                        .map(Rice::getUnitPrice)
                                        .orElse(0))
                                .sum())));
        for (Map.Entry<Date, Integer> entry : map.entrySet()) {
            System.out.println("Tổng doanh thu ngày " + entry.getKey().toString() + " là: " + entry.getValue());
        }
    }

    static void cau2() {
        System.out.println("In ra danh sách các gạo có số lượng tồn kho lớn hơn 100 kg.");
        List<Rice> list = rices.stream()
                .filter(rice -> receiptNoteDetails.stream()
                        .filter(receiptNoteDetail -> receiptNoteDetail.getRiceID() == rice.getId())
                        .mapToInt(receiptNoteDetail -> (int) receiptNoteDetail.getQuantity())
                        .sum() - billDetails.stream()
                        .filter(billDetail -> billDetail.getRiceID() == rice.getId())
                        .mapToInt(billDetail -> billDetail.getQuantity())
                        .sum() > 100)
                .collect(Collectors.toList());
        for (Rice item : list) {
            System.out.println("Gạo " + item.getName() + " có số lượng tồn kho là: " + (receiptNoteDetails.stream()
                    .filter(receiptNoteDetail -> receiptNoteDetail.getRiceID() == item.getId())
                    .mapToInt(receiptNoteDetail -> (int) receiptNoteDetail.getQuantity())
                    .sum() - billDetails.stream()
                    .filter(billDetail -> billDetail.getRiceID() == item.getId())
                    .mapToInt(billDetail -> billDetail.getQuantity())
                    .sum()) + " kg.");
        }
    }

    static void cau3() {
        System.out.println("Tính và in ra tổng số tiền mua hàng của từng khách hàng. ");
        Map<Customer, Integer> map = bills.stream()
                .flatMap(bill -> billDetails.stream()
                        .filter(billDetail -> billDetail.getBillID() == bill.getId())
                            .map(billDetail -> new AbstractMap.SimpleEntry<>(bill.getCustomerID(), billDetail.getQuantity() * rices.stream()
                                .filter(rice -> rice.getId() == billDetail.getRiceID())
                                .findFirst()
                                .map(Rice::getUnitPrice)
                                .orElse(0))))
                .collect(Collectors.groupingBy(entry -> customers.stream()
                                .filter(customer -> customer.getId() == entry.getKey())
                                .findFirst()
                                .orElseThrow(),
                        Collectors.summingInt(AbstractMap.SimpleEntry::getValue)));
        for (Map.Entry<Customer, Integer> entry : map.entrySet()) {
            System.out.println("Tổng số tiền mua hàng của khách hàng " + entry.getKey().getName() + " là: " + entry.getValue());
        }
    }

    static void cau4() {
        //Tìm và in ra danh sách 3 gạo bán chạy nhất. Sắp xếp theo thứ tự giảm dần.
        System.out.println("Tìm và in ra danh sách 3 gạo bán chạy nhất. Sắp xếp theo thứ tự giảm dần.");
        List<Rice> list = rices.stream()
                .sorted((o1, o2) -> {
                    int result = 0;
                    int total1 = 0;
                    int total2 = 0;
                    for (BillDetail billDetail : billDetails) {
                        if (billDetail.getRiceID() == o1.getId()) {
                            total1 += billDetail.getQuantity();
                        }
                        if (billDetail.getRiceID() == o2.getId()) {
                            total2 += billDetail.getQuantity();
                        }
                    }
                    if (total1 > total2) {
                        result = -1;
                    } else if (total1 < total2) {
                        result = 1;
                    } else {
                        result = 0;
                    }
                    return result;
                })
                .limit(3)
                .collect(Collectors.toList());
        for (Rice item : list) {
            System.out.println("Gạo " + item.getName() + " bán được " + billDetails.stream()
                    .filter(billDetail -> billDetail.getRiceID() == item.getId())
                    .mapToInt(billDetail -> billDetail.getQuantity())
                    .sum() + " kg.");
        }
    }

    static void  cau5() {
        System.out.println("In ra danh sách nhà cung cấp gạo kèm lượng gạo bán được.");
        for (Suplier item : supliers) {
            ArrayList<ReceiptNote> rn = receiptNotes.stream()
                    .filter(receiptNote -> receiptNote.getSuplierID() == item.getId())
                    .collect(Collectors.toCollection(ArrayList::new));
            ArrayList<ReceiptNoteDetail> rnd = receiptNoteDetails.stream()
                    .filter(receiptNoteDetail -> rn.stream()
                            .anyMatch(receiptNote -> receiptNote.getId() == receiptNoteDetail.getReceptNoteID()))
                    .collect(Collectors.toCollection(ArrayList::new));
            ArrayList<BillDetail> bDetail = billDetails.stream()
                    .filter(billDetail -> rnd.stream()
                            .anyMatch(receiptNoteDetail -> receiptNoteDetail.getRiceID() == billDetail.getRiceID()))
                    .collect(Collectors.toCollection(ArrayList::new));
            System.out.println("Nhà cung cấp " + item.getName() + " bán được " + bDetail.stream()
                    .mapToInt(billDetail -> billDetail.getQuantity())
                    .sum() + " kg gạo.");
        }
    }

    static void cau6() {
        //Sắp xếp gạo theo giá bán từ thấp đến cao.
        System.out.println("Sắp xếp gạo theo giá bán từ thấp đến cao.");
        List<Rice> list = rices.stream()
                .sorted((o1, o2) -> {
                    int result = 0;
                    if (o1.getUnitPrice() > o2.getUnitPrice()) {
                        result = 1;
                    } else if (o1.getUnitPrice() < o2.getUnitPrice()) {
                        result = -1;
                    } else {
                        result = 0;
                    }
                    return result;
                })
                .collect(Collectors.toList());
        for (Rice item : list) {
            System.out.println("Gạo " + item.getName() + " có giá bán là: " + item.getUnitPrice());
        }
    }

    static void cau7() {
        //Sắp xếp phiếu nhập theo giá tiền từ cao đến thấp.
        System.out.println("Sắp xếp phiếu nhập theo giá tiền từ cao đến thấp.");
        List<ReceiptNote> list = receiptNotes.stream()
                .sorted((o1, o2) -> {
                    int result = 0;
                    int total1 = 0;
                    int total2 = 0;
                    for (ReceiptNoteDetail receiptNoteDetail : receiptNoteDetails) {
                        if (receiptNoteDetail.getReceptNoteID() == o1.getId()) {
                            total1 += receiptNoteDetail.getQuantity() * receiptNoteDetail.getUnitPrice();
                        }
                        if (receiptNoteDetail.getReceptNoteID() == o2.getId()) {
                            total2 += receiptNoteDetail.getQuantity() * receiptNoteDetail.getUnitPrice();
                        }
                    }
                    if (total1 > total2) {
                        result = -1;
                    } else if (total1 < total2) {
                        result = 1;
                    } else {
                        result = 0;
                    }
                    return result;
                })
                .collect(Collectors.toList());
        for (ReceiptNote item : list) {
            System.out.println("Phiếu nhập " + item.getId() + " có giá trị là: " + receiptNoteDetails.stream()
                    .filter(receiptNoteDetail -> receiptNoteDetail.getReceptNoteID() == item.getId())
                    .mapToInt(receiptNoteDetail -> (int) receiptNoteDetail.getQuantity() * (int) receiptNoteDetail.getUnitPrice())
                    .sum());
        }
    }

    static void cau8() {
        //Tìm và in ra nhân viên có số lượng đơn bán hàng nhiều nhất.
        System.out.println("Tìm và in ra nhân viên có số lượng đơn bán hàng nhiều nhất.");
        Staff staff = staffs.stream()
                .max((o1, o2) -> {
                    int result = 0;
                    int total1 = 0;
                    int total2 = 0;
                    for (Bill bill : bills) {
                        if (bill.getStaffID() == o1.getId()) {
                            total1++;
                        }
                        if (bill.getStaffID() == o2.getId()) {
                            total2++;
                        }
                    }
                    if (total1 > total2) {
                        result = 1;
                    } else if (total1 < total2) {
                        result = -1;
                    } else {
                        result = 0;
                    }
                    return result;
                })
                .orElseThrow();
        System.out.println("Nhân viên có số lượng đơn bán hàng nhiều nhất là: " + staff.getName() + " với số lượng là: " + bills.stream()
                .filter(bill -> bill.getStaffID() == staff.getId())
                .count() + " đơn.");
    }

    static void cau9() {
        //Tìm ra hóa đơn bán được nhiều gạo nhất. (Nếu trùng thì in ra hóa đơn có số tiền lớn nhất).
        System.out.println("Tìm ra hóa đơn bán được nhiều gạo nhất. (Nếu trùng thì in ra hóa đơn có số tiền lớn nhất).");
        Bill bill = bills.stream()
                .max((o1, o2) -> {
                    int result = 0;
                    int total1 = 0;
                    int total2 = 0;
                    for (BillDetail billDetail : billDetails) {
                        if (billDetail.getBillID() == o1.getId()) {
                            total1 += billDetail.getQuantity() * rices.stream()
                                    .filter(rice -> rice.getId() == billDetail.getRiceID())
                                    .findFirst()
                                    .map(Rice::getUnitPrice)
                                    .orElse(0);
                        }
                        if (billDetail.getBillID() == o2.getId()) {
                            total2 += billDetail.getQuantity() * rices.stream()
                                    .filter(rice -> rice.getId() == billDetail.getRiceID())
                                    .findFirst()
                                    .map(Rice::getUnitPrice)
                                    .orElse(0);
                        }
                    }
                    if (total1 > total2) {
                        result = 1;
                    } else if (total1 < total2) {
                        result = -1;
                    } else {
                        result = 0;
                    }
                    return result;
                })
                .orElseThrow();
        System.out.println("Hóa đơn bán được nhiều gạo nhất là: " + bill.getId() + " có số tiền là: " + billDetails.stream()
                .filter(billDetail -> billDetail.getBillID() == bill.getId())
                .mapToInt(billDetail -> billDetail.getQuantity() * rices.stream()
                        .filter(rice -> rice.getId() == billDetail.getRiceID())
                        .findFirst()
                        .map(Rice::getUnitPrice)
                        .orElse(0))
                .sum()
                + " với số lượng là: " + billDetails.stream()
                .filter(billDetail -> billDetail.getBillID() == bill.getId())
                .mapToInt(BillDetail::getQuantity)
                .sum() + " kg.");
    }

    static void cau10() {
        //Tìm ra nhân viên bán được nhiều gạo của nhà cung cấp “Lộc Trời Group” nhất.
        System.out.println("Tìm ra nhân viên bán được nhiều gạo của nhà cung cấp “Lộc Trời Group” nhất.");
        Staff staff = staffs.stream()
                .max((o1, o2) -> {
                    int result = 0;
                    int total1 = 0;
                    int total2 = 0;
                    for (Bill bill : bills) {
                        if (bill.getStaffID() == o1.getId()) {
                            total1 += billDetails.stream()
                                    .filter(billDetail -> billDetail.getBillID() == bill.getId())
                                    .mapToInt(billDetail -> billDetail.getQuantity() * rices.stream()
                                            .filter(rice -> rice.getId() == billDetail.getRiceID())
                                            .findFirst()
                                            .map(Rice::getUnitPrice)
                                            .orElse(0))
                                    .sum();
                        }
                        if (bill.getStaffID() == o2.getId()) {
                            total2 += billDetails.stream()
                                    .filter(billDetail -> billDetail.getBillID() == bill.getId())
                                    .mapToInt(billDetail -> billDetail.getQuantity() * rices.stream()
                                            .filter(rice -> rice.getId() == billDetail.getRiceID())
                                            .findFirst()
                                            .map(Rice::getUnitPrice)
                                            .orElse(0))
                                    .sum();
                        }
                    }
                    if (total1 > total2) {
                        result = 1;
                    } else if (total1 < total2) {
                        result = -1;
                    } else {
                        result = 0;
                    }
                    return result;
                })
                .orElseThrow();
        System.out.println("Nhân viên bán được nhiều gạo của nhà cung cấp “Lộc Trời Group” nhất là: " + staff.getName() + " với số tiền là: " + bills.stream()
                .filter(bill -> bill.getStaffID() == staff.getId())
                .mapToInt(bill -> billDetails.stream()
                        .filter(billDetail -> billDetail.getBillID() == bill.getId())
                        .mapToInt(billDetail -> billDetail.getQuantity() * rices.stream()
                                .filter(rice -> rice.getId() == billDetail.getRiceID())
                                .findFirst()
                                .map(Rice::getUnitPrice)
                                .orElse(0))
                        .sum())
                .sum()
                + " với số lượng là: " + bills.stream()
                .filter(bill -> bill.getStaffID() == staff.getId())
                .mapToInt(bill -> billDetails.stream()
                        .filter(billDetail -> billDetail.getBillID() == bill.getId())
                        .mapToInt(BillDetail::getQuantity)
                        .sum())
                .sum() + " kg.");
    }

    static void cauHoiThem() {
        //Liệt kê danh sách gạo mà từng khách hàng mua nhiều nhất trong những hóa đơn mua gạo mà họ đã mua.
        System.out.println("Liệt kê danh sách gạo mà từng khách hàng mua nhiều nhất trong những hóa đơn mua gạo mà họ đã mua.");
        for (Customer item : customers) {
            ArrayList<Bill> bill = bills.stream()
                    .filter(bill1 -> bill1.getCustomerID() == item.getId())
                    .collect(Collectors.toCollection(ArrayList::new));
            ArrayList<BillDetail> billDetail = billDetails.stream()
                    .filter(billDetail1 -> bill.stream()
                            .anyMatch(bill1 -> bill1.getId() == billDetail1.getBillID()))
                    .collect(Collectors.toCollection(ArrayList::new));
            ArrayList<Rice> rice = rices.stream()
                    .filter(rice1 -> billDetail.stream()
                            .anyMatch(billDetail1 -> billDetail1.getRiceID() == rice1.getId()))
                    .collect(Collectors.toCollection(ArrayList::new));
            System.out.println("Khách hàng " + item.getName() + " mua nhiều nhất là: " + rice.stream()
                    .max((o1, o2) -> {
                        int result = 0;
                        int total1 = 0;
                        int total2 = 0;
                        for (BillDetail billDetail1 : billDetail) {
                            if (billDetail1.getRiceID() == o1.getId()) {
                                total1 += billDetail1.getQuantity();
                            }
                            if (billDetail1.getRiceID() == o2.getId()) {
                                total2 += billDetail1.getQuantity();
                            }
                        }
                        if (total1 > total2) {
                            result = 1;
                        } else if (total1 < total2) {
                            result = -1;
                        } else {
                            result = 0;
                        }
                        return result;
                    })
                    .orElseThrow()
                    .getName() + " với số lượng là: " + billDetail.stream()
                    .filter(billDetail1 -> billDetail1.getRiceID() == rice.stream()
                            .max((o1, o2) -> {
                                int result = 0;
                                int total1 = 0;
                                int total2 = 0;
                                for (BillDetail billDetail2 : billDetail) {
                                    if (billDetail2.getRiceID() == o1.getId()) {
                                        total1 += billDetail2.getQuantity();
                                    }
                                    if (billDetail2.getRiceID() == o2.getId()) {
                                        total2 += billDetail2.getQuantity();
                                    }
                                }
                                if (total1 > total2) {
                                    result = 1;
                                } else if (total1 < total2) {
                                    result = -1;
                                } else {
                                    result = 0;
                                }
                                return result;
                            })
                            .orElseThrow()
                            .getId())
                    .mapToInt(BillDetail::getQuantity)
                    .sum() + " kg.");

        }
    }
}