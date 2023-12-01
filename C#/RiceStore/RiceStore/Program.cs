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
            cau6();
            Console.WriteLine("_____________________________________");
            cau7();
            Console.WriteLine("_____________________________________");
            cau8();
            Console.WriteLine("_____________________________________");
            cau9();
            Console.WriteLine("_____________________________________");
            cau10();
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

            foreach (var item in rices)
            {
                if (item.getCategoryId() == "RC01")
                {
                    item.setUnitPrice((int)(item.getUnitPrice() * 1.2));
                }
            }    

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
            bills.Add(new Bill("B016", new DateTime(2021, 05, 16), "C006", "ST001"));
            bills.Add(new Bill("B017", new DateTime(2021, 05, 17), "C007", "ST002"));
            bills.Add(new Bill("B018", new DateTime(2021, 05, 18), "C008", "ST003"));
            bills.Add(new Bill("B019", new DateTime(2021, 05, 19), "C009", "ST001"));
            bills.Add(new Bill("B020", new DateTime(2021, 05, 20), "C010", "ST002"));

            billDetails.Add(new BillDetail(10, "B001", "R001"));
            billDetails.Add(new BillDetail(20, "B002", "R002"));
            billDetails.Add(new BillDetail(30, "B003", "R003"));
            billDetails.Add(new BillDetail(20, "B004", "R004"));
            billDetails.Add(new BillDetail(35, "B005", "R005"));
            billDetails.Add(new BillDetail(10, "B006", "R006"));
            billDetails.Add(new BillDetail(45, "B007", "R007"));
            billDetails.Add(new BillDetail(71, "B008", "R008"));
            billDetails.Add(new BillDetail(65, "B009", "R009"));
            billDetails.Add(new BillDetail(55, "B010", "R010"));
            billDetails.Add(new BillDetail(15, "B011", "R011"));
            billDetails.Add(new BillDetail(35, "B012", "R012"));
            billDetails.Add(new BillDetail(50, "B013", "R013"));
            billDetails.Add(new BillDetail(75, "B014", "R014"));
            billDetails.Add(new BillDetail(100, "B015", "R015"));
            billDetails.Add(new BillDetail(10, "B016", "R016"));
            billDetails.Add(new BillDetail(20, "B017", "R017"));
            billDetails.Add(new BillDetail(30, "B018", "R018"));
            billDetails.Add(new BillDetail(20, "B019", "R019"));
            billDetails.Add(new BillDetail(35, "B020", "R020"));

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

            receptNoteDetails.Add(new ReceptNoteDetail(100, 45000, "RN001", "R001"));
            receptNoteDetails.Add(new ReceptNoteDetail(200, 35000, "RN002", "R002"));
            receptNoteDetails.Add(new ReceptNoteDetail(300, 25000, "RN003", "R003"));
            receptNoteDetails.Add(new ReceptNoteDetail(200, 30000, "RN004", "R004"));
            receptNoteDetails.Add(new ReceptNoteDetail(350, 40000, "RN005", "R005"));
            receptNoteDetails.Add(new ReceptNoteDetail(100, 50000, "RN006", "R006"));
            receptNoteDetails.Add(new ReceptNoteDetail(450, 55000, "RN007", "R007"));
            receptNoteDetails.Add(new ReceptNoteDetail(710, 60000, "RN008", "R008"));
            receptNoteDetails.Add(new ReceptNoteDetail(650, 65000, "RN009", "R009"));
            receptNoteDetails.Add(new ReceptNoteDetail(550, 70000, "RN010", "R010"));
            receptNoteDetails.Add(new ReceptNoteDetail(150, 45000, "RN011", "R011"));
            receptNoteDetails.Add(new ReceptNoteDetail(350, 35000, "RN012", "R012"));
            receptNoteDetails.Add(new ReceptNoteDetail(500, 25000, "RN013", "R013"));
            receptNoteDetails.Add(new ReceptNoteDetail(750, 30000, "RN014", "R014"));
            receptNoteDetails.Add(new ReceptNoteDetail(100, 40000, "RN015", "R015"));
            receptNoteDetails.Add(new ReceptNoteDetail(100, 45000, "RN016", "R016"));
            receptNoteDetails.Add(new ReceptNoteDetail(200, 35000, "RN017", "R017"));
            receptNoteDetails.Add(new ReceptNoteDetail(300, 25000, "RN018", "R018"));
            receptNoteDetails.Add(new ReceptNoteDetail(200, 30000, "RN019", "R019"));
            receptNoteDetails.Add(new ReceptNoteDetail(350, 40000, "RN020", "R020"));

            foreach (var item in receptNoteDetails)
            {
                item.setUnitPrice((int)(item.getUnitPrice() * 0.8));
            }
                

        }

        public static void cau1()
        {
            Console.WriteLine("Câu 1: Danh sách tên các gạo theo từng loại gạo");
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
            Console.WriteLine("Câu 2: Danh sách gạo có giá bán lớn hơn 50.000đ");
            var result = from r in rices
                         join rc in riceCategories on r.getCategoryId() equals rc.getId()
                         where r.getUnitPrice() > 50000
                         select new
                         {
                             RiceName = r.getName(),
                             RiceCategoryName = rc.getName(),
                             RicePrice = r.getUnitPrice()
                         };
            foreach (var item in result)
            {
                Console.WriteLine("Tên gạo: " + item.RiceName);
                Console.WriteLine("Loại gạo: " + item.RiceCategoryName);
                Console.WriteLine("Giá bán: " + item.RicePrice + " đồng.");
            }
            
        }

        public static void cau3()
        {
            Console.WriteLine("Câu 3: Danh sách số lượng gạo ứng với tên gạo");
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
                Console.WriteLine("Số lượng: " + item.RiceQuantity + " kg.");
            }
            
        }

        public static void cau4()
        {
            Console.WriteLine("Câu 4: Tổng số tiền mà mỗi nhân viên bán được và nhân viên có số tiền cao nhất");
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
            var max = test.Max(x => x.Total);
            foreach (var item in test)
            {
                if (item.Total == max)
                {
                    Console.WriteLine("Nhân viên có số tiền bán được cao nhất: " + item.StaffName);
                }
            }
        }

        public static void cau5()
        {
            Console.WriteLine("Câu 5: Danh sách số lượng gạo và tổng số tiền của từng nhà cung cấp đã cung cấp và nhà cung cấp có số tiền cao nhất");
            var result = from r in rices
                         join rnd in receptNoteDetails on r.getId() equals rnd.getRiceID()
                         join rn in receptNotes on rnd.getReceptNoteID() equals rn.getId()
                         join s in supliers on rn.getSuplierID() equals s.getId()
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
                             RiceQuantity = g.Sum(x => x.RiceQuantity),
                             Total = g.Sum(x => x.RiceQuantity * x.RicePrice)
                              };
            foreach (var item in test)
            {
                Console.WriteLine("Tên nhà cung cấp: " + item.SuplierName);
                Console.WriteLine("Số lượng gạo: " + item.RiceQuantity + " kg.");
                Console.WriteLine("Tổng số tiền: " + item.Total + " đồng.");
            }
            var max = test.Max(x => x.Total);
            foreach (var item in test)
            {
                if (item.Total == max)
                {
                    Console.WriteLine("Nhà cung cấp có tổng số tiền cao nhất: " + item.SuplierName);
                }
            }
        }

        public static void cau6()
        {
            Console.WriteLine("Câu 6: Danh sách số lượng gạo tồn kho lớn hơn 100 ");
            var result = from r in rices
                         join rc in riceCategories on r.getCategoryId() equals rc.getId()
                         join rnd in receptNoteDetails on r.getId() equals rnd.getRiceID()
                         select new
                         {
                             RiceName = r.getName(),
                             RiceCategoryName = rc.getName(),
                             RiceQuantity = rnd.getQuantity()
                         };
            foreach (var item in result)
            {
                if (item.RiceQuantity > 100)
                {
                    Console.WriteLine("Tên gạo: " + item.RiceName);
                    Console.WriteLine("Loại gạo: " + item.RiceCategoryName);
                    Console.WriteLine("Số lượng gạo: " + item.RiceQuantity + " kg.");
                }
            }
        }

        public static void cau7()
        {
            Console.WriteLine(" Câu 7: Danh sách khách hàng đã mua gạo và số lượng gạo mà khách hàng đó đã mua");
            var result = from c in customers
                         join b in bills on c.getId() equals b.getCustomerID()
                         join bd in billDetails on b.getID() equals bd.getBillID()
                         join r in rices on bd.getRiceID() equals r.getId()
                         select new
                         {
                             CustomerName = c.getName(),
                             RiceName = r.getName(),
                             RiceCaegory = r.getCategoryId(),
                             RiceQuantity = bd.getQuantity()
                         };
            var test = from kq in result
                       group kq by kq.CustomerName into g
                       select new
                       {
                           CustomerName = g.Key,
                           RiceName = g.Select(x => x.RiceName).Distinct(),
                           RiceCategory = g.Select(x => x.RiceCaegory).Distinct(),
                           RiceQuantity = g.Sum(x => x.RiceQuantity)
                       };
            foreach (var item in test)
            {
                Console.WriteLine("Tên khách hàng: " + item.CustomerName);
                Console.WriteLine("Số lượng gạo đã mua: " + item.RiceQuantity + " kg.");
                foreach (var s in item.RiceName)
                {
                    Console.WriteLine("Tên gạo: " + s);
                }
                foreach (var s in item.RiceCategory)
                {
                    foreach (var r in riceCategories)
                    {
                        if (s == r.getId())
                        {
                            Console.WriteLine("Loại gạo: " + r.getName());
                        }
                    }
                }
            }
        }

        public static void cau8()
        {
            Console.WriteLine("Câu 8: Tính tổng số liền ở mỗi hóa đơn và in ra hóa đơn có số lượng tiền lớn nhất");
            var result = from b in bills
                         join bd in billDetails on b.getID() equals bd.getBillID()
                         join r in rices on bd.getRiceID() equals r.getId()
                         select new
                         {
                             BillID = b.getID(),
                             RiceName = r.getName(),
                             RiceQuantity = bd.getQuantity(),
                             RicePrice = r.getUnitPrice()
                         };
            var test = from kq in result
                       group kq by kq.BillID into g
                          select new
                          {
                            BillID = g.Key,
                            Total = g.Sum(x => x.RiceQuantity * x.RicePrice)
                          };
            foreach (var item in test)
            {
                Console.WriteLine("Mã hóa đơn: " + item.BillID);
                Console.WriteLine("Tổng số tiền: " + item.Total + " đồng.");
            }
            var max = test.Max(x => x.Total);
            foreach (var item in test)
            {
                if (item.Total == max)
                {
                    Console.WriteLine("Hóa đơn có số lượng tiền lớn nhất: " + item.BillID);
                }
            }
        }

        public static void cau9()
        {
            Console.WriteLine("Câu 9: Tính tổng số tiền của mỗi phiếu nhập và in ra nhà cung cấp được nhập nhiều hàng nhất");
            var result = from rn in receptNotes
                         join rnd in receptNoteDetails on rn.getId() equals rnd.getReceptNoteID()
                         join r in rices on rnd.getRiceID() equals r.getId()
                         select new
                         {
                             ReceptNoteID = rn.getId(),
                             RiceName = r.getName(),
                             RiceQuantity = rnd.getQuantity(),
                             RicePrice = rnd.getUnitPrice()
                         };
            var test = from kq in result
                       group kq by kq.ReceptNoteID into g
                              select new
                              {
                             ReceptNoteID = g.Key,
                             QuantityTotal = g.Sum(x => x.RiceQuantity),
                             Total = g.Sum(x => x.RiceQuantity * x.RicePrice)
                              };
            foreach (var item in test)
            {
                Console.WriteLine("Mã phiếu nhập: " + item.ReceptNoteID);
                Console.WriteLine("Tổng số tiền: " + item.Total + " đồng.");
            }
            var max = test.Max(x => x.QuantityTotal);
            foreach (var item in test)
            {
                if (item.QuantityTotal == max)
                {
                    foreach (var s in supliers)
                    {
                        if (s.getId() == receptNotes.Find(x => x.getId() == item.ReceptNoteID).getSuplierID())
                        {
                            Console.WriteLine("Nhà cung cấp có được nhập nhiều hàng nhất: " + s.getName());
                        }
                    }
                }
            }
        }

        public static void cau10()
        {
            Console.WriteLine("Câu 10: Tính tỷ lệ % số lượng gạo nhập vào mà có chất lượng không đảm bảo đồng thời in ra danh sách các nhà cung cấp có tỷ lệ % số lượng gạo nhập vào mà có chất lượng không đảm bảo cao nhất");
            var result = from r in rices
                         join rnd in receptNoteDetails on r.getId() equals rnd.getRiceID()
                         select new
                         {
                             RiceName = r.getName(),
                             RiceQuantity = rnd.getQuantity()
                         };
            var test = from kq in result
                       group kq by kq.RiceName into g
                              select new
                              {
                             RiceName = g.Key,
                             RiceQuantity = g.Sum(x => x.RiceQuantity)
                              };
            var result1 = from r in rices
                          join rnd in receptNoteDetails on r.getId() equals rnd.getRiceID()
                          join rn in receptNotes on rnd.getReceptNoteID() equals rn.getId()
                          where rn.getMoreInfo() == "Không Đảm bảo chất lượng"
                          select new
                          {
                              RiceName = r.getName(),
                              RiceQuantity = rnd.getQuantity()
                          };
            var test1 = from kq in result1
                        group kq by kq.RiceName into g
                              select new
                              {
                             RiceName = g.Key,
                             RiceQuantity = g.Sum(x => x.RiceQuantity)
                              };
            var result2 = from t in test
                          join t1 in test1 on t.RiceName equals t1.RiceName
                          select new
                          {
                              RiceName = t.RiceName,
                              RiceQuantity = t.RiceQuantity,
                              RiceQuantity1 = t1.RiceQuantity
                          };
            var test2 = from kq in result2
                        select new
                        {
                            RiceName = kq.RiceName,
                            RiceQuantity = kq.RiceQuantity1,
                            RiceQuantity1 = kq.RiceQuantity,
                            Percent = (kq.RiceQuantity1 / kq.RiceQuantity) * 100
                        };
            foreach (var item in test2)
            {
                Console.WriteLine("Tên gạo: " + item.RiceName);
                Console.WriteLine("Tỷ lệ % số lượng gạo nhập vào mà có chất lượng không đảm bảo: " + item.Percent + "%.");
            }
            var max = test2.Max(x => x.Percent);
            foreach (var item in test2)
            {
                if (item.Percent == max)
                {
                    foreach (var s in supliers)
                    {
                        if (s.getId() == rices.Find(x => x.getName() == item.RiceName).getSupplierId())
                        {
                            Console.WriteLine("Nhà cung cấp có tỷ lệ % số lượng gạo nhập vào mà có chất lượng không đảm bảo cao nhất: " + s.getName());
                        }
                    }
                }
            }

        }
    }
}
