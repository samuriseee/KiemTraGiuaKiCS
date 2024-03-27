
// init a main file to run program

using System;

namespace KiemTraGiuaKi
{
    class Program
    {
        static void Main(string[] args)
        {
            KhuPho khuPho = new KhuPho();
            Console.WriteLine("Nhập tên khu phố:");
            khuPho.TenKhuPho = Console.ReadLine();
            Console.WriteLine("Nhập số lượng hộ dân:");
            int soLuongHo = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < soLuongHo; i++)
            {
                HoGiaDinh hoGiaDinh = new HoGiaDinh();

                Console.WriteLine("Nhập số lượng thành viên:");
                int soLuongThanhVien = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < soLuongThanhVien; j++)
                {
                    Nguoi thanhVien = new Nguoi();
                    Console.WriteLine("Nhập tên thành viên:");
                    thanhVien.HoTen = Console.ReadLine();
                    Console.WriteLine("Nhập tuổi thành viên:");
                    thanhVien.Tuoi = Convert.ToInt32(Console.ReadLine());
                    hoGiaDinh.ThemNguoi(thanhVien);
                }
                khuPho.ThemHoGiaDinh(hoGiaDinh);
            }
            
            Console.WriteLine("Thông tin của các hộ dân trong khu phố:");
            khuPho.toString();
            
            Console.WriteLine("Tìm hộ gia đình có số con trai >=2: ");
            List<HoGiaDinh> hoGiaDinhCoContrai2 = khuPho.DanhSachHoGiaDinh.Where(hoGiaDinh => hoGiaDinh.SoConTrai >= 2).ToList();
            hoGiaDinhCoContrai2.ForEach(hoGiaDinh => hoGiaDinh.toString());
            
            Console.WriteLine("Tìm hộ gia đình có số con từ 5 đến 10:");
            List<HoGiaDinh> hoGiaDinhCoConTu5Den10 = khuPho.DanhSachHoGiaDinh.Where(hoGiaDinh => hoGiaDinh.SoThanhVien >= 5 && hoGiaDinh.SoThanhVien <= 10).ToList();
            
            Console.WriteLine("Tính tổng số thành viên trong khu phố: ");
            int tongSoThanhVien = khuPho.DanhSachHoGiaDinh.Sum(hoGiaDinh => hoGiaDinh.SoThanhVien);
            Console.WriteLine("Tổng số thành viên trong khu phố: " + tongSoThanhVien);
            
            Console.WriteLine("Tìm các hộ gia đình có người tên 'Hùng': ");
            List<HoGiaDinh> hoGiaDinhCoNguoiTenHung = khuPho.DanhSachHoGiaDinh.Where(hoGiaDinh => hoGiaDinh.ThanhVien.Any(nguoi => nguoi.HoTen.Contains("Hùng"))).ToList();

            Console.WriteLine("Thống kê số con nam, nữ trong khu phố: ");
            int tongSoConNam = khuPho.DanhSachHoGiaDinh.Sum(hoGiaDinh => hoGiaDinh.SoConTrai);
            int tongSoConNu = khuPho.DanhSachHoGiaDinh.Sum(hoGiaDinh => hoGiaDinh.SoConGai);
            Console.WriteLine("Tổng số con nam: " + tongSoConNam);
            Console.WriteLine("Tổng số con nữ: " + tongSoConNu);
        }
        
    }
}
