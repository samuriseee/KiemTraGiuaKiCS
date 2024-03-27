namespace KiemTraGiuaKi;

public class KhuPho
{
    public string TenKhuPho { get; set; }
    public List<HoGiaDinh> DanhSachHoGiaDinh { get; set; }
    
    public KhuPho()
    {
        DanhSachHoGiaDinh = new List<HoGiaDinh>();
    }
    
    public KhuPho(string tenKhuPho, List<HoGiaDinh> danhSachHoGiaDinh)
    {
        TenKhuPho = tenKhuPho;
        DanhSachHoGiaDinh = danhSachHoGiaDinh;
    }
    
    public void SetDanhSachHoGiaDinh(List<HoGiaDinh> danhSachHoGiaDinh)
    {
        DanhSachHoGiaDinh = danhSachHoGiaDinh;
    }
    
    public void ThemHoGiaDinh(HoGiaDinh hoGiaDinh)
    {
        DanhSachHoGiaDinh.Add(hoGiaDinh);
    }
    
    public void toString()
    {
        Console.WriteLine("Tên khu phố: " + TenKhuPho);
        foreach (HoGiaDinh hoGiaDinh in DanhSachHoGiaDinh)
        {
            Console.WriteLine("Số nhà: " + hoGiaDinh.SoNha);
            Console.WriteLine("Số thành viên: " + hoGiaDinh.SoThanhVien);
            Console.WriteLine("Số con trai: " + hoGiaDinh.SoConTrai);
            Console.WriteLine("Số con gái: " + hoGiaDinh.SoConGai);
            foreach (Nguoi nguoi in hoGiaDinh.ThanhVien)
            {
                Console.WriteLine("Họ tên: " + nguoi.HoTen);
                Console.WriteLine("Tuổi: " + nguoi.Tuoi);
                Console.WriteLine("Nghề nghiệp: " + nguoi.NgheNghiep);
                Console.WriteLine("Số CMND: " + nguoi.SoCMND);
            }
        }
    }
}