namespace KiemTraGiuaKi;

public class HoGiaDinh
{
    public int SoThanhVien { get; set; }
    public int SoConTrai { get; set; }
    public int SoConGai { get; set; }
    public int SoNha { get; set; }
    public List<Nguoi> ThanhVien { get; set; }

    public HoGiaDinh(int soThanhVien, int soConTrai, int soConGai, int soNha)
    {
        SoThanhVien = soThanhVien;
        SoConTrai = soConTrai;
        SoConGai = soConGai;
        SoNha = soNha;
        ThanhVien = new List<Nguoi>();
    }
    
    public HoGiaDinh()
    {
        ThanhVien = new List<Nguoi>();
    }
    
    public void SetThanhVien(List<Nguoi> thanhVien)
    {
        ThanhVien = thanhVien;
    }
    
    public void ThemNguoi(Nguoi nguoi)
    {
        ThanhVien.Add(nguoi);
    }

    public void toString()
    {
        Console.WriteLine("Số nhà: " + SoNha);
        Console.WriteLine("Số thành viên: " + SoThanhVien);
        Console.WriteLine("Số con trai: " + SoConTrai);
        Console.WriteLine("Số con gái: " + SoConGai);
        foreach (Nguoi nguoi in ThanhVien)
        {
            Console.WriteLine("Họ tên: " + nguoi.HoTen);
            Console.WriteLine("Tuổi: " + nguoi.Tuoi);
            Console.WriteLine("Nghề nghiệp: " + nguoi.NgheNghiep);
            Console.WriteLine("Số CMND: " + nguoi.SoCMND);
        }
    }
}