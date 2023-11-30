using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiceStore
{
    public class Program
    {
        public static List<CustomerCategory> customerCategories;
        public static List<Customer> customers;
        public static List<Suplier> supliers;
        public static List<RiceCategory> riceCategories;
        public static List<Rice> rices;
        public static List<Bill> bills;
        public static List<BillDetail> billDetails;
        public static List<Staff> staffs;
        public static List<ReceptNoteDetail> receptNoteDetails;
        public static List<ReceptNote> receptNotes;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            customerCategories = new List<CustomerCategory>();
            customers = new List<Customer>();
            supliers = new List<Suplier>();
            riceCategories = new List<RiceCategory>();
            rices = new List<Rice>();
            bills = new List<Bill>();
            billDetails = new List<BillDetail>();
            staffs = new List<Staff>();
            receptNoteDetails = new List<ReceptNoteDetail>();
            receptNotes = new List<ReceptNote>();

            initData();
            cau1();
            Console.WriteLine("____________________________________");
            cau2();
            Console.WriteLine("____________________________________");
            cau3();
            Console.WriteLine("_____________________________________");
            cau4();
            Console.WriteLine("_____________________________________");
            cau5();
            Console.WriteLine("_____________________________________");
            Console.ReadLine();

        }

        public static void initData()
        {
            supliers.Add(new Suplier("S001", "Vinafood", "Hoàn Kiếm, Hà Nội", "0969811515"));
            supliers.Add(new Suplier("S002", "Intimex Group", "Quận 1,Tp Hồ Chí Minh", "02838208052"));
            supliers.Add(new Suplier("S003", "Tân Long Group", "Thanh Xuân, Hà Nội", "02466688666"));
            supliers.Add(new Suplier("S004", "BRG Group", "Hoàn Kiếm, Hà Nội", "02439393691"));
            supliers.Add(new Suplier("S005", "Donafood", "Biên Hòa, Đồng Nai", "02513892577"));
            supliers.Add(new Suplier("S006", "Lộc Trời Group", "Phnom Penh, Campuchia", "(+855) 236 315 666"));

            riceCategories.Add(new RiceCategory("RC01", "Gạo Ngon"));
            riceCategories.Add(new RiceCategory("RC02", "Gạo Thường"));

            rices.Add(new Rice("R001", "Gạo Nếp Cẩm", "Còn hàng", 45000, "S001", "RC01"));
            rices.Add(new Rice("R002", "Gạo Nàng Thơm", "Còn hàng", 35000, "S002", "RC01"));
            rices.Add(new Rice("R003", "Gạo Lức", "Còn hàng", 25000, "S003", "RC01"));
            rices.Add(new Rice("R004", "Gạo Dẻo", "Còn hàng", 30000, "S004", "RC01"));
            rices.Add(new Rice("R005", "Gạo Nở", "Còn hàng", 40000, "S005", "RC01"));
            rices.Add(new Rice("R006", "Gạo Tám Xoan", "Còn hàng", 50000, "S006", "RC01"));
            rices.Add(new Rice("R007", "Gạo Tám Thơm", "Còn hàng", 55000, "S001", "RC01"));
            rices.Add(new Rice("R008", "Gạo Tám Hoa", "Còn hàng", 60000, "S002", "RC01"));
            rices.Add(new Rice("R009", "Gạo Tám Phước Lộ", "Còn hàng", 65000, "S003", "RC01"));
            rices.Add(new Rice("R010", "Gạo ST25", "Còn hàng", 70000, "S004", "RC01"));
            rices.Add(new Rice("R011", "Gạo Nếp Cẩm", "Còn hàng", 45000, "S005", "RC02"));
            rices.Add(new Rice("R012", "Gạo Nàng Thơm", "Còn hàng", 35000, "S006", "RC02"));
            rices.Add(new Rice("R013", "Gạo Lức", "Còn hàng", 25000, "S001", "RC02"));
            rices.Add(new Rice("R014", "Gạo Dẻo", "Còn hàng", 30000, "S002", "RC02"));
            rices.Add(new Rice("R015", "Gạo Nở", "Còn hàng", 40000, "S003", "RC02"));
            rices.Add(new Rice("R016", "Gạo Tám Xoan", "Còn hàng", 50000, "S004", "RC02"));
            rices.Add(new Rice("R017", "Gạo Tám Thơm", "Còn hàng", 55000, "S005", "RC02"));
            rices.Add(new Rice("R018", "Gạo Tám Hoa", "Còn hàng", 60000, "S006", "RC02"));
            rices.Add(new Rice("R019", "Gạo Tám Phước Lộ", "Còn hàng", 65000, "S001", "RC02"));
            rices.Add(new Rice("R020", "Gạo ST25", "Còn hàng", 70000, "S002", "RC02"));

            customerCategories.Add(new CustomerCategory("CC01", "Thân Thiết"));
            customerCategories.Add(new CustomerCategory("CC02", "Bình Thường"));

            customers.Add(new Customer("C001", "Trần Thị Ngọc Tốt", false, "CC01"));
            customers.Add(new Customer("C002", "Nguyễn Thị Thu An", false, "CC02"));
            customers.Add(new Customer("C003", "Lý Thị Như ý", false, "CC02"));
            customers.Add(new Customer("C004", "Nguyễn Thị Thanh Thảo", false, "CC01"));
            customers.Add(new Customer("C005", "Lê Văn Phát", true, "CC01"));
            customers.Add(new Customer("C006", "Nguyễn Thị Thanh Thảo", false, "CC02"));
            customers.Add(new Customer("C007", "Nguyễn Văn Tiến Đạt", true, "CC01"));
            customers.Add(new Customer("C008", "Nguyễn Thị Diễm Thúy", false, "CC02"));
            customers.Add(new Customer("C009", "Nguyễn Thị Trà My", false, "CC01"));
            customers.Add(new Customer("C010", "Phạm Nguyễn Tuyết Như", false, "CC02"));

            staffs.Add(new Staff("ST001", "Nguyễn Văn A", "Ca Sáng", "Hà Nội", true, new DateTime(1999, 12, 22), "0325845489"));
            staffs.Add(new Staff("ST002", "Nguyễn Thị B", "Ca Chiều", "Hà Nội", false, new DateTime(1999, 10, 14), "0397578059"));
            staffs.Add(new Staff("ST003", "Trần Văn C", "Car Ngày", "Hà Nội", true, new DateTime(1999, 02, 28), "0857139116"));

            bills.Add(new Bill("B001", new DateTime(2021, 05, 01), "C001", "ST001"));
            bills.Add(new Bill("B002", new DateTime(2021, 05, 02), "C002", "ST002"));
            bills.Add(new Bill("B003", new DateTime(2021, 05, 03), "C003", "ST003"));
            bills.Add(new Bill("B004", new DateTime(2021, 05, 04), "C004", "ST001"));
            bills.Add(new Bill("B005", new DateTime(2021, 05, 05), "C005", "ST002"));
            bills.Add(new Bill("B006", new DateTime(2021, 05, 06), "C006", "ST003"));
            bills.Add(new Bill("B007", new DateTime(2021, 05, 07), "C007", "ST001"));
            bills.Add(new Bill("B008", new DateTime(2021, 05, 08), "C008", "ST002"));
            bills.Add(new Bill("B009", new DateTime(2021, 05, 09), "C009", "ST003"));
            bills.Add(new Bill("B010", new DateTime(2021, 05, 10), "C010", "ST001"));
            bills.Add(new Bill("B011", new DateTime(2021, 05, 11), "C001", "ST002"));
            bills.Add(new Bill("B012", new DateTime(2021, 05, 12), "C002", "ST003"));
            bills.Add(new Bill("B013", new DateTime(2021, 05, 13), "C003", "ST001"));
            bills.Add(new Bill("B014", new DateTime(2021, 05, 14), "C004", "ST002"));
            bills.Add(new Bill("B015", new DateTime(2021, 05, 15), "C005", "ST003"));

            billDetails.Add(new BillDetail(10, "B001", "R001"));
            billDetails.Add(new BillDetail(20, "B002", "R002"));
            billDetails.Add(new BillDetail(30, "B003", "R003"));
            billDetails.Add(new BillDetail(40, "B004", "R004"));
            billDetails.Add(new BillDetail(50, "B005", "R005"));
            billDetails.Add(new BillDetail(60, "B006", "R006"));
            billDetails.Add(new BillDetail(70, "B007", "R007"));
            billDetails.Add(new BillDetail(80, "B008", "R008"));
            billDetails.Add(new BillDetail(90, "B009", "R009"));
            billDetails.Add(new BillDetail(100, "B010", "R010"));
            billDetails.Add(new BillDetail(110, "B011", "R011"));
            billDetails.Add(new BillDetail(120, "B012", "R012"));
            billDetails.Add(new BillDetail(130, "B013", "R013"));
            billDetails.Add(new BillDetail(140, "B014", "R014"));
            billDetails.Add(new BillDetail(150, "B015", "R015"));

            receptNotes.Add(new ReceptNote("RN001", new DateTime(2021, 05, 01), "Đảm bảo chất lượng", "S001", "ST001"));
            receptNotes.Add(new ReceptNote("RN002", new DateTime(2021, 05, 02), "Đảm bảo chất lượng", "S002", "ST002"));
            receptNotes.Add(new ReceptNote("RN003", new DateTime(2021, 05, 03), "Không Đảm bảo chất lượng", "S003", "ST003"));
            receptNotes.Add(new ReceptNote("RN004", new DateTime(2021, 05, 04), "Đảm bảo chất lượng", "S004", "ST001"));
            receptNotes.Add(new ReceptNote("RN005", new DateTime(2021, 05, 05), "Đảm bảo chất lượng", "S005", "ST002"));
            receptNotes.Add(new ReceptNote("RN006", new DateTime(2021, 05, 06), "Không Đảm bảo chất lượng", "S006", "ST003"));
            receptNotes.Add(new ReceptNote("RN007", new DateTime(2021, 05, 07), "Đảm bảo chất lượng", "S001", "ST001"));
            receptNotes.Add(new ReceptNote("RN008", new DateTime(2021, 05, 08), "Đảm bảo chất lượng", "S002", "ST002"));
            receptNotes.Add(new ReceptNote("RN009", new DateTime(2021, 05, 09), "Không Đảm bảo chất lượng", "S003", "ST003"));
            receptNotes.Add(new ReceptNote("RN010", new DateTime(2021, 05, 10), "Đảm bảo chất lượng", "S004", "ST001"));
            receptNotes.Add(new ReceptNote("RN011", new DateTime(2021, 05, 11), "Đảm bảo chất lượng", "S005", "ST002"));
            receptNotes.Add(new ReceptNote("RN012", new DateTime(2021, 05, 12), "Không Đảm bảo chất lượng", "S006", "ST003"));
            receptNotes.Add(new ReceptNote("RN013", new DateTime(2021, 05, 13), "Đảm bảo chất lượng", "S001", "ST001"));
            receptNotes.Add(new ReceptNote("RN014", new DateTime(2021, 05, 14), "Đảm bảo chất lượng", "S002", "ST002"));
            receptNotes.Add(new ReceptNote("RN015", new DateTime(2021, 05, 15), "Không Đảm bảo chất lượng", "S003", "ST003"));
            receptNotes.Add(new ReceptNote("RN016", new DateTime(2021, 05, 16), "Đảm bảo chất lượng", "S004", "ST001"));
            receptNotes.Add(new ReceptNote("RN017", new DateTime(2021, 05, 17), "Đảm bảo chất lượng", "S005", "ST002"));
            receptNotes.Add(new ReceptNote("RN018", new DateTime(2021, 05, 18), "Không Đảm bảo chất lượng", "S006", "ST003"));
            receptNotes.Add(new ReceptNote("RN019", new DateTime(2021, 05, 19), "Đảm bảo chất lượng", "S001", "ST001"));
            receptNotes.Add(new ReceptNote("RN020", new DateTime(2021, 05, 20), "Đảm bảo chất lượng", "S002", "ST002"));

            receptNoteDetails.Add(new ReceptNoteDetail(45000000, 10, "RN001", "R001"));
            receptNoteDetails.Add(new ReceptNoteDetail(35000000, 20, "RN002", "R002"));
            receptNoteDetails.Add(new ReceptNoteDetail(25000000, 30, "RN003", "R003"));
            receptNoteDetails.Add(new ReceptNoteDetail(30000000, 40, "RN004", "R004"));
            receptNoteDetails.Add(new ReceptNoteDetail(40000000, 50, "RN005", "R005"));
            receptNoteDetails.Add(new ReceptNoteDetail(50000000, 60, "RN006", "R006"));
            receptNoteDetails.Add(new ReceptNoteDetail(55000000, 70, "RN007", "R007"));
            receptNoteDetails.Add(new ReceptNoteDetail(60000000, 80, "RN008", "R008"));
            receptNoteDetails.Add(new ReceptNoteDetail(65000000, 90, "RN009", "R009"));
            receptNoteDetails.Add(new ReceptNoteDetail(70000000, 100, "RN010", "R010"));
            receptNoteDetails.Add(new ReceptNoteDetail(45000000, 110, "RN011", "R011"));
            receptNoteDetails.Add(new ReceptNoteDetail(35000000, 120, "RN012", "R012"));
            receptNoteDetails.Add(new ReceptNoteDetail(25000000, 130, "RN013", "R013"));
            receptNoteDetails.Add(new ReceptNoteDetail(30000000, 140, "RN014", "R014"));
            receptNoteDetails.Add(new ReceptNoteDetail(40000000, 150, "RN015", "R015"));
            receptNoteDetails.Add(new ReceptNoteDetail(50000000, 160, "RN016", "R016"));
            receptNoteDetails.Add(new ReceptNoteDetail(55000000, 170, "RN017", "R017"));
            receptNoteDetails.Add(new ReceptNoteDetail(60000000, 180, "RN018", "R018"));
            receptNoteDetails.Add(new ReceptNoteDetail(65000000, 190, "RN019", "R019"));
            receptNoteDetails.Add(new ReceptNoteDetail(70000000, 200, "RN020", "R020"));
        }

        public static void cau1()
        {
            //in ra danh sách tên các gạo theo từng loại gạo

            Console.WriteLine("Danh sách tên các gạo theo từng loại gạo");
            var result = from r in rices
                         join rc in riceCategories on r.getCategoryId() equals rc.getId()
                         select new
                         {
                             RiceName = r.getName(),
                             RiceCategoryName = rc.getName()
                         };
            foreach (var r in riceCategories) 
            { 
                Console.WriteLine("Loại gạo: " + r.getName());
                foreach (var item in result)
                {
                    if (item.RiceCategoryName == r.getName())
                    {
                        Console.WriteLine(item.RiceName + ".");
                    }
                }
            }
            

        }

        public static void cau2()
        {
            //in ra danh sách rice có giá bán lớn hơn 50.000đ
            Console.WriteLine("Danh sách rice có giá bán lớn hơn 50.000đ");
            var result = from r in rices
                         where r.getUnitPrice() > 50000
                         select new
                         {
                             RiceName = r.getName(),
                             RicePrice = r.getUnitPrice()
                         };
            foreach (var item in result)
            {
                Console.WriteLine("Giá bán: " + item.RicePrice);
                foreach (var r in rices)
                {
                    if (item.RiceName == r.getName())
                    {
                        Console.WriteLine("Tên gạo: " + r.getName());
                    }
                }
            }
        }

        public static void cau3()
        {
            //in ra tổng số lượng gạo ứng với mỗi tên gạo, nếu trùng tên thì cộng dồn số lượng
            Console.WriteLine("Danh sách số lượng gạo ứng với tên gạo");
            var result = from r in rices
                         join rc in riceCategories on r.getCategoryId() equals rc.getId()
                         join rnd in receptNoteDetails on r.getId() equals rnd.getRiceID()
                         select new
                         {
                             RiceName = r.getName(),
                             RiceCategoryName = rc.getName(),
                             RiceQuantity = rnd.getQuantity()
                         };
            var test = from kq in result
                       group kq by kq.RiceName into g
                          select new
                          {
                            RiceName = g.Key,
                            RiceQuantity = g.Sum(x => x.RiceQuantity)
                          };
            foreach (var item in test)
            {
                Console.WriteLine("Tên gạo: " + item.RiceName);
                Console.WriteLine("Số lượng: " + item.RiceQuantity + " tấn.");
            }
            
        }

        public static void cau4()
        {
            //tính tổng số tiền mà mối nhân viên bán được
            Console.WriteLine("Tổng số tiền mà mỗi nhân viên bán được");
            var result = from b in bills
                         join bd in billDetails on b.getID() equals bd.getBillID()
                         join r in rices on bd.getRiceID() equals r.getId()
                         join s in staffs on b.getStaffID() equals s.getId()
                         select new
                         {
                             StaffName = s.getName(),
                             RiceName = r.getName(),
                             RiceQuantity = bd.getQuantity(),
                             RicePrice = r.getUnitPrice()
                         };
            var test = from kq in result
                       group kq by kq.StaffName into g
                          select new
                          {
                            StaffName = g.Key,
                            Total = g.Sum(x => x.RiceQuantity * x.RicePrice)
                          };
            foreach (var item in test)
            {
                Console.WriteLine("Tên nhân viên: " + item.StaffName);
                Console.WriteLine("Tổng số tiền: " + item.Total + " đồng.");
            }
        }

        public static void cau5()
        {
            //tinh tổng số lượng gạo và số tiền mà từng nhà cung cấp đã cung cấp hàng
            Console.WriteLine("Tổng số lượng gạo và số tiền mà từng nhà cung cấp đã cung cấp hàng");
            var result = from r in rices
                         join s in supliers on r.getSupplierId() equals s.getId()
                         join rnd in receptNoteDetails on r.getId() equals rnd.getRiceID()
                         select new
                         {
                             SuplierName = s.getName(),
                             RiceName = r.getName(),
                             RiceQuantity = rnd.getQuantity(),
                             RicePrice = rnd.getUnitPrice()
                         };
            var test = from kq in result
                       group kq by kq.SuplierName into g
                              select new
                              {
                             SuplierName = g.Key,
                             TotalQuantity = g.Sum(x => x.RiceQuantity),
                             TotalPrice = g.Sum(x => x.RiceQuantity * x.RicePrice)
                              };
            foreach (var item in test)
            {
                Console.WriteLine("Tên nhà cung cấp: " + item.SuplierName);
                Console.WriteLine("Tổng số lượng: " + item.TotalQuantity + " tấn.");
                Console.WriteLine("Tổng số tiền: " + item.TotalPrice + " đồng.");
            }
        }
    }
}
