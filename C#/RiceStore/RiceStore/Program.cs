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
            cauhoiThem();
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

            rices.Add(new Rice("R001", "Gạo Nếp Cẩm", "Còn hàng", 45000));
            rices.Add(new Rice("R002", "Gạo Nàng Thơm", "Còn hàng", 35000));
            rices.Add(new Rice("R003", "Gạo Lức", "Còn hàng", 25000));
            rices.Add(new Rice("R004", "Gạo Dẻo", "Còn hàng", 30000));
            rices.Add(new Rice("R005", "Gạo Nở", "Còn hàng", 40000));
            rices.Add(new Rice("R006", "Gạo Tám Xoan", "Còn hàng", 50000));
            rices.Add(new Rice("R007", "Gạo Tám Thơm", "Còn hàng", 55000));
            rices.Add(new Rice("R008", "Gạo Tám Hoa", "Còn hàng", 60000));
            rices.Add(new Rice("R009", "Gạo Tám Phước Lộ", "Còn hàng", 65000));
            rices.Add(new Rice("R010", "Gạo ST25", "Còn hàng", 70000));

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

            bills.Add(new Bill("B001", new DateTime(2021, 05, 1), "C001", "ST001"));
            bills.Add(new Bill("B002", new DateTime(2021, 05, 2), "C002", "ST002"));
            bills.Add(new Bill("B003", new DateTime(2021, 05, 3), "C003", "ST003"));
            bills.Add(new Bill("B004", new DateTime(2021, 05, 4), "C004", "ST001"));
            bills.Add(new Bill("B005", new DateTime(2021, 05, 5), "C005", "ST002"));
            bills.Add(new Bill("B006", new DateTime(2021, 05, 6), "C006", "ST003"));
            bills.Add(new Bill("B007", new DateTime(2021, 05, 7), "C007", "ST001"));
            bills.Add(new Bill("B008", new DateTime(2021, 05, 8), "C008", "ST002"));
            bills.Add(new Bill("B009", new DateTime(2021, 05, 9), "C009", "ST003"));
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
            bills.Add(new Bill("B021", new DateTime(2021, 05, 21), "C001", "ST003"));
            bills.Add(new Bill("B022", new DateTime(2021, 05, 22), "C002", "ST001"));
            bills.Add(new Bill("B023", new DateTime(2021, 05, 23), "C003", "ST002"));
            bills.Add(new Bill("B024", new DateTime(2021, 05, 24), "C004", "ST003"));
            bills.Add(new Bill("B025", new DateTime(2021, 05, 25), "C005", "ST001"));
            bills.Add(new Bill("B026", new DateTime(2021, 05, 26), "C006", "ST002"));
            bills.Add(new Bill("B027", new DateTime(2021, 05, 27), "C007", "ST003"));
            bills.Add(new Bill("B028", new DateTime(2021, 05, 28), "C008", "ST001"));
            bills.Add(new Bill("B029", new DateTime(2021, 05, 29), "C009", "ST002"));
            bills.Add(new Bill("B030", new DateTime(2021, 05, 30), "C010", "ST003"));

            billDetails.Add(new BillDetail(10, "B001", "R001"));
            billDetails.Add(new BillDetail(20, "B002", "R002"));
            billDetails.Add(new BillDetail(30, "B003", "R003"));
            billDetails.Add(new BillDetail(40, "B004", "R004"));
            billDetails.Add(new BillDetail(50, "B005", "R005"));
            billDetails.Add(new BillDetail(60, "B006", "R006"));
            billDetails.Add(new BillDetail(70, "B007", "R007"));
            billDetails.Add(new BillDetail(80, "B008", "R008"));
            billDetails.Add(new BillDetail(90, "B009", "R009"));
            billDetails.Add(new BillDetail(10, "B010", "R010"));
            billDetails.Add(new BillDetail(15, "B001", "R010"));
            billDetails.Add(new BillDetail(20, "B002", "R009"));
            billDetails.Add(new BillDetail(25, "B003", "R008"));
            billDetails.Add(new BillDetail(30, "B004", "R007"));
            billDetails.Add(new BillDetail(35, "B005", "R006"));
            billDetails.Add(new BillDetail(40, "B006", "R005"));
            billDetails.Add(new BillDetail(45, "B007", "R004"));
            billDetails.Add(new BillDetail(50, "B008", "R003"));
            billDetails.Add(new BillDetail(55, "B009", "R002"));
            billDetails.Add(new BillDetail(60, "B010", "R001"));
            billDetails.Add(new BillDetail(65, "B011", "R005"));
            billDetails.Add(new BillDetail(70, "B012", "R006"));
            billDetails.Add(new BillDetail(75, "B013", "R007"));
            billDetails.Add(new BillDetail(80, "B014", "R008"));
            billDetails.Add(new BillDetail(85, "B015", "R009"));
            billDetails.Add(new BillDetail(90, "B016", "R010"));
            billDetails.Add(new BillDetail(95, "B017", "R001"));
            billDetails.Add(new BillDetail(21, "B018", "R002"));
            billDetails.Add(new BillDetail(22, "B019", "R003"));
            billDetails.Add(new BillDetail(23, "B020", "R004"));
            billDetails.Add(new BillDetail(24, "B020", "R003"));
            billDetails.Add(new BillDetail(25, "B021", "R006"));
            billDetails.Add(new BillDetail(26, "B022", "R009"));
            billDetails.Add(new BillDetail(27, "B023", "R002"));
            billDetails.Add(new BillDetail(28, "B024", "R005"));
            billDetails.Add(new BillDetail(29, "B025", "R008"));
            billDetails.Add(new BillDetail(30, "B026", "R001"));
            billDetails.Add(new BillDetail(31, "B027", "R004"));
            billDetails.Add(new BillDetail(32, "B028", "R007"));
            billDetails.Add(new BillDetail(33, "B029", "R010"));
            billDetails.Add(new BillDetail(34, "B030", "R003"));
            billDetails.Add(new BillDetail(35, "B025", "R006"));
            billDetails.Add(new BillDetail(36, "B024", "R009"));
            billDetails.Add(new BillDetail(37, "B023", "R011"));
            billDetails.Add(new BillDetail(38, "B022", "R005"));
            billDetails.Add(new BillDetail(39, "B021", "R007"));
            billDetails.Add(new BillDetail(40, "B020", "R010"));
            billDetails.Add(new BillDetail(41, "B019", "R001"));
            billDetails.Add(new BillDetail(42, "B018", "R002"));
            billDetails.Add(new BillDetail(43, "B017", "R003"));
            billDetails.Add(new BillDetail(44, "B016", "R004"));
            billDetails.Add(new BillDetail(45, "B015", "R005"));
            billDetails.Add(new BillDetail(46, "B014", "R006"));
            billDetails.Add(new BillDetail(47, "B013", "R003"));
            billDetails.Add(new BillDetail(48, "B012", "R002"));
            billDetails.Add(new BillDetail(49, "B011", "R001"));
            billDetails.Add(new BillDetail(50, "B010", "R010"));
            billDetails.Add(new BillDetail(51, "B009", "R004"));
            billDetails.Add(new BillDetail(52, "B008", "R005"));
            billDetails.Add(new BillDetail(53, "B007", "R006"));
            billDetails.Add(new BillDetail(54, "B006", "R007"));
            billDetails.Add(new BillDetail(55, "B005", "R008"));
            billDetails.Add(new BillDetail(56, "B004", "R009"));
            billDetails.Add(new BillDetail(57, "B003", "R010"));

            receptNotes.Add(new ReceptNote("RN001", new DateTime(2021, 05, 1), "Đảm bảo chất lượng", "S001", "ST001"));
            receptNotes.Add(new ReceptNote("RN002", new DateTime(2021, 05, 2), "Đảm bảo chất lượng", "S002", "ST002"));
            receptNotes.Add(new ReceptNote("RN003", new DateTime(2021, 05, 3), "Không Đảm bảo chất lượng", "S003", "ST003"));
            receptNotes.Add(new ReceptNote("RN004", new DateTime(2021, 05, 4), "Đảm bảo chất lượng", "S004", "ST001"));
            receptNotes.Add(new ReceptNote("RN005", new DateTime(2021, 05, 5), "Đảm bảo chất lượng", "S005", "ST002"));
            receptNotes.Add(new ReceptNote("RN006", new DateTime(2021, 05, 6), "Không Đảm bảo chất lượng", "S006", "ST003"));
            receptNotes.Add(new ReceptNote("RN007", new DateTime(2021, 05, 7), "Đảm bảo chất lượng", "S001", "ST001"));
            receptNotes.Add(new ReceptNote("RN008", new DateTime(2021, 05, 8), "Đảm bảo chất lượng", "S002", "ST002"));
            receptNotes.Add(new ReceptNote("RN009", new DateTime(2021, 05, 9), "Không Đảm bảo chất lượng", "S003", "ST003"));
            receptNotes.Add(new ReceptNote("RN010", new DateTime(2021, 05, 10), "Đảm bảo chất lượng", "S004", "ST001"));
            receptNotes.Add(new ReceptNote("RN011", new DateTime(2021, 05, 11), "Đảm bảo chất lượng", "S005", "ST002"));
            receptNotes.Add(new ReceptNote("RN012", new DateTime(2021, 05, 12), "Không Đảm bảo chất lượng", "S006", "ST003"));
            receptNotes.Add(new ReceptNote("RN013", new DateTime(2021, 05, 13), "Đảm bảo chất lượng", "S001", "ST001"));
            receptNotes.Add(new ReceptNote("RN014", new DateTime(2021, 05, 14), "Đảm bảo chất lượng", "S002", "ST002"));
            receptNotes.Add(new ReceptNote("RN015", new DateTime(2021, 05, 15), "Không Đảm bảo chất lượng", "S003", "ST003"));
            receptNotes.Add(new ReceptNote("RN016", new DateTime(2021, 05, 16), "Đảm bảo chất lượng", "S004", "ST001"));
            receptNotes.Add(new ReceptNote("RN017", new DateTime(2021, 05, 17), "Đảm bảo chất lượng", "S005", "ST002"));
            receptNotes.Add(new ReceptNote("RN018", new DateTime(2021, 05, 18), "Không Đảm bảo chất lượng", "S006", "ST003"));

            receptNoteDetails.Add(new ReceptNoteDetail(100, 50000, "RN001", "R001"));
            receptNoteDetails.Add(new ReceptNoteDetail(200, 55000, "RN001", "R007"));
            receptNoteDetails.Add(new ReceptNoteDetail(300, 35000, "RN002", "R002"));
            receptNoteDetails.Add(new ReceptNoteDetail(400, 60000, "RN002", "R008"));
            receptNoteDetails.Add(new ReceptNoteDetail(500, 25000, "RN003", "R003"));
            receptNoteDetails.Add(new ReceptNoteDetail(600, 65000, "RN003", "R009"));
            receptNoteDetails.Add(new ReceptNoteDetail(700, 30000, "RN004", "R004"));
            receptNoteDetails.Add(new ReceptNoteDetail(800, 70000, "RN004", "R010"));
            receptNoteDetails.Add(new ReceptNoteDetail(900, 40000, "RN005", "R005"));
            receptNoteDetails.Add(new ReceptNoteDetail(1000, 45000, "RN006", "R006"));
            receptNoteDetails.Add(new ReceptNoteDetail(1100, 50000, "RN007", "R001"));
            receptNoteDetails.Add(new ReceptNoteDetail(1200, 55000, "RN007", "R007"));
            receptNoteDetails.Add(new ReceptNoteDetail(1300, 35000, "RN008", "R002"));
            receptNoteDetails.Add(new ReceptNoteDetail(1400, 60000, "RN008", "R008"));
            receptNoteDetails.Add(new ReceptNoteDetail(1500, 25000, "RN009", "R003"));
            receptNoteDetails.Add(new ReceptNoteDetail(1600, 65000, "RN009", "R009"));
            receptNoteDetails.Add(new ReceptNoteDetail(1700, 30000, "RN010", "R004"));
            receptNoteDetails.Add(new ReceptNoteDetail(1800, 70000, "RN010", "R010"));
            receptNoteDetails.Add(new ReceptNoteDetail(1900, 40000, "RN011", "R005"));
            receptNoteDetails.Add(new ReceptNoteDetail(2000, 45000, "RN012", "R006"));
            receptNoteDetails.Add(new ReceptNoteDetail(2100, 50000, "RN013", "R001"));
            receptNoteDetails.Add(new ReceptNoteDetail(2200, 55000, "RN013", "R007"));
            receptNoteDetails.Add(new ReceptNoteDetail(2300, 35000, "RN014", "R002"));
            receptNoteDetails.Add(new ReceptNoteDetail(2400, 60000, "RN014", "R008"));
            receptNoteDetails.Add(new ReceptNoteDetail(2500, 25000, "RN015", "R003"));
            receptNoteDetails.Add(new ReceptNoteDetail(2600, 65000, "RN015", "R009"));
            receptNoteDetails.Add(new ReceptNoteDetail(2700, 30000, "RN016", "R004"));
            receptNoteDetails.Add(new ReceptNoteDetail(2800, 70000, "RN016", "R010"));
            receptNoteDetails.Add(new ReceptNoteDetail(2900, 40000, "RN017", "R005"));
            receptNoteDetails.Add(new ReceptNoteDetail(3000, 45000, "RN018", "R006"));

            foreach (var item in receptNoteDetails)
            {
                item.setUnitPrice((int)(item.getUnitPrice() * 0.8));
            }
                

        }

        public static void cau1()
        {
            Console.WriteLine("Tìm và in ra danh sách 3 nhà cung cấp gạo có số lượng gạo bán được nhiều nhất. Sắp xếp theo thứ tự giảm dần.");
            var result = from r in rices
                         join rnd in receptNoteDetails on r.getId() equals rnd.getRiceID()
                         join rn in receptNotes on rnd.getReceptNoteID() equals rn.getId()
                         join s in supliers on rn.getSuplierID() equals s.getId()
                         select new
                         {
                             SuplierName = s.getName(),
                             RiceName = r.getName(),
                             RiceQuantity = rnd.getQuantity()
                         };
            var test = from kq in result
                       group kq by kq.SuplierName into g
                          select new
                          {
                            SuplierName = g.Key,
                            RiceQuantity = g.Sum(x => x.RiceQuantity)
                          };
            var test1 = test.OrderByDescending(x => x.RiceQuantity).Take(3);
            foreach (var item in test1)
            {
                Console.WriteLine("Tên nhà cung cấp: " + item.SuplierName);
                Console.WriteLine("Số lượng gạo: " + item.RiceQuantity + " kg.");
            }

        }

        public static void cau2()
        {
            Console.WriteLine("Câu 2: Danh sách gạo có giá bán lớn hơn 50.000đ");
            var result = from r in rices
                         where r.getUnitPrice() > 50000
                         select new
                         {
                             RiceName = r.getName(),
                             RiceUnitPrice = r.getUnitPrice()
                         };
            foreach (var item in result)
            {
                Console.WriteLine("Tên gạo: " + item.RiceName);
                Console.WriteLine("Giá bán: " + item.RiceUnitPrice + " đồng.");
            }
        }

        public static void cau3()
        {
            Console.WriteLine("Câu 3: Danh sách số lượng gạo ứng với tên gạo");
            //Danh sách số lượng gạo ứng với tên gạo nếu trùng tên gạo thì cộng dồn số lượng gạo
            var result = from r in rices
                         join rnd in receptNoteDetails on r.getId() equals rnd.getRiceID()
                         join rn in receptNotes on rnd.getReceptNoteID() equals rn.getId()
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
            foreach (var item in test)
            {
                Console.WriteLine("Tên gạo: " + item.RiceName);
                Console.WriteLine("Số lượng gạo: " + item.RiceQuantity + " kg.");
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
            Console.WriteLine("Câu 6: Tính và in ra tổng số lượng gạo đảm bảo chất lượng và không đảm bảo chất lương của từng gạo. Tìm và in ra các nhà cung cấp cung cấp gạo không đảm bảo chất lương.");
            var result = from r in rices
                         join rnd in receptNoteDetails on r.getId() equals rnd.getRiceID()
                         join rn in receptNotes on rnd.getReceptNoteID() equals rn.getId()
                         where rn.getMoreInfo() == "Đảm bảo chất lượng"
                         select new
                         {
                             RiceName = r.getName(),
                             RiceQuantity = rnd.getQuantity(),
                             RiceMoreInfo = rn.getMoreInfo()
                         };
            var test = from kq in result
                       group kq by kq.RiceName into g
                              select new
                              {
                             RiceName = g.Key,
                             RiceQuantity = g.Sum(x => x.RiceQuantity),
                             RiceMoreInfo = g.Select(x => x.RiceMoreInfo).Distinct()
                              };
            Console.WriteLine("Gạo đảm bảo chất lượng: ");
            foreach (var item in test)
            {
                Console.WriteLine("Tên gạo: " + item.RiceName);
                Console.WriteLine("Số lượng gạo: " + item.RiceQuantity + " kg.");
            }
            var result1 = from r in rices
                          join rnd in receptNoteDetails on r.getId() equals rnd.getRiceID()
                          join rn in receptNotes on rnd.getReceptNoteID() equals rn.getId()
                          where rn.getMoreInfo() == "Không Đảm bảo chất lượng"
                          select new
                          {
                              RiceName = r.getName(),
                              RiceQuantity = rnd.getQuantity(),
                              RiceMoreInfo = rn.getMoreInfo()
                          };
            var test1 = from kq in result1
                        group kq by kq.RiceName into g
                              select new
                              {
                             RiceName = g.Key,
                             RiceQuantity = g.Sum(x => x.RiceQuantity),
                             RiceMoreInfo = g.Select(x => x.RiceMoreInfo).Distinct()
                              };
            Console.WriteLine("Gạo không đảm bảo chất lượng: ");
            foreach (var item in test1)
            {
                Console.WriteLine("Tên gạo: " + item.RiceName);
                Console.WriteLine("Số lượng gạo: " + item.RiceQuantity + " kg.");
            }
        }

        public static void cau7()
        {
            Console.WriteLine("Câu 7: Danh sách khách hàng đã mua gạo và số lượng gạo mà khách hàng đó đã mua");
            //Danh sách khách hàng đã mua gạo, tên từng gạo, số lượng gạo mà khách hàng đó đã mua nếu trùng tên khách hàng thì cộng dồn số lượng gạo
            var result = from c in customers
                         join b in bills on c.getId() equals b.getCustomerID()
                         join bd in billDetails on b.getID() equals bd.getBillID()
                         join r in rices on bd.getRiceID() equals r.getId()
                         select new
                         {
                             CustomerName = c.getName(),
                             RiceName = r.getName(),
                             RiceQuantity = bd.getQuantity()
                         };
            var test = from kq in result
                       group kq by kq.CustomerName into g
                                select new
                                {
                              CustomerName = g.Key,
                              RiceName = g.Select(x => x.RiceName).Distinct(),
                              RiceQuantity = g.Sum(x => x.RiceQuantity)
                                };
            foreach (var item in test)
            {
                Console.WriteLine("Tên khách hàng: " + item.CustomerName);
                Console.Write("Tên gạo: " );
                foreach (var i in item.RiceName)
                {
                    Console.Write(i);
                    if (i != item.RiceName.Last())
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Số lượng gạo: " + item.RiceQuantity + " kg.");
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
            Console.WriteLine("Câu 10: Tính tỷ lệ % số lượng gạo nhập vào mà có chất lượng không đảm bảo của từng gạo đồng thời in ra danh sách các nhà cung cấp có tỷ lệ % số lượng gạo nhập vào mà có chất lượng không đảm bảo cao nhất");
            var result = from r in rices
                         join rnd in receptNoteDetails on r.getId() equals rnd.getRiceID()
                         join rn in receptNotes on rnd.getReceptNoteID() equals rn.getId()
                         where rn.getMoreInfo() == "Không Đảm bảo chất lượng"
                         select new
                         {
                             RiceName = r.getName(),
                             RiceQuantity = rnd.getQuantity(),
                             RiceMoreInfo = rn.getMoreInfo()
                         };
            var test = from kq in result
                       group kq by kq.RiceName into g
                       select new
                       {
                           RiceName = g.Key,
                           RiceQuantity = g.Sum(x => x.RiceQuantity),
                           RiceMoreInfo = g.Select(x => x.RiceMoreInfo).Distinct()
                       };
            var result1 = from r in rices
                          join rnd in receptNoteDetails on r.getId() equals rnd.getRiceID()
                          join rn in receptNotes on rnd.getReceptNoteID() equals rn.getId()
                          select new
                          {
                              RiceName = r.getName(),
                              RiceQuantity = rnd.getQuantity(),
                              RiceMoreInfo = rn.getMoreInfo()
                          };
            var test1 = from kq in result1
                        group kq by kq.RiceName into g
                        select new
                        {
                            RiceName = g.Key,
                            RiceQuantity = g.Sum(x => x.RiceQuantity),
                            RiceMoreInfo = g.Select(x => x.RiceMoreInfo).Distinct()
                        };

            foreach (var item in test)
            {
                Console.WriteLine("Tên gạo: " + item.RiceName);
                Console.WriteLine("Tỷ lệ % số lượng gạo nhập vào mà có chất lượng không đảm bảo: " + (item.RiceQuantity / test1.First(x => x.RiceName == item.RiceName).RiceQuantity) * 100 + "%");
            }
            var max = (test.Max(x => x.RiceQuantity) / test1.First(x => x.RiceName == test.First(y => y.RiceQuantity == test.Max(z => z.RiceQuantity)).RiceName).RiceQuantity) * 100;
            foreach (var item in test)
            {
                if ((item.RiceQuantity / test1.First(x => x.RiceName == item.RiceName).RiceQuantity) * 100 == max)
                {
                    Console.WriteLine("Nhà cung cấp có tỷ lệ % số lượng gạo nhập vào mà có chất lượng không đảm bảo cao nhất: " + supliers.Find(x => x.getId() == receptNotes.Find(y => y.getId() == receptNoteDetails.Find(z => z.getRiceID() == rices.Find(t => t.getName() == item.RiceName).getId()).getReceptNoteID()).getSuplierID()).getName());
                }
            }
        }

        public static void cauhoiThem() 
        {
            Console.WriteLine("Câu hỏi thêm: Tìm và in ra tên khách hàng và tên gạo mà khách hàng đó mua nhiều nhất và số lượng gạo đó");
            var result = from c in customers
                         join b in bills on c.getId() equals b.getCustomerID()
                         join bd in billDetails on b.getID() equals bd.getBillID()
                         join r in rices on bd.getRiceID() equals r.getId()
                         select new
                         {
                             CustomerName = c.getName(),
                             RiceName = r.getName(),
                             RiceQuantity = bd.getQuantity()
                         };
            var test = from kq in result
                       group kq by kq.CustomerName into g
                          select new
                          {
                            CustomerName = g.Key,
                            RiceName = g.Select(x => x.RiceName),
                            RiceQuantity = g.Select(x => x.RiceQuantity)
                          };
            foreach (var item in test)
            {
                Console.WriteLine("Tên khách hàng: " + item.CustomerName);
                Console.Write("Tên gạo: ");
                int max = item.RiceQuantity.Max();
                int index = item.RiceQuantity.ToList().IndexOf(max);
                Console.WriteLine(item.RiceName.ToList()[index]);
                Console.WriteLine("Số lượng gạo: " + max + " kg.");
            }
        }
    }

    internal class list<T>
    {
    }
}
