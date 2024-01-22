using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTrucDanhSachDon
{
    class Program
    {
        static void Nhap(DanhSachLienKetDon ds)
        {
            string chon = "y";
            do
            {
                Console.Write("Nhap gia tri nut : ");
                int x = int.Parse(Console.ReadLine());
                ds.ThemCuoi(x);
                Console.Write("Hay chon y/n ");
                chon = Console.ReadLine();
            } while (chon != "n");
        }
        static void Main(string[] args)
        {
            DanhSachLienKetDon ds = new DanhSachLienKetDon();
            Nhap(ds);
            Console.WriteLine("Danh sach ");
            ds.Xuat();
            Console.WriteLine("\nDanh sach xoa dau");
            ds.XoaDau();
            ds.Xuat();

            Console.WriteLine("\nDanh sach xoa cuoi");
            ds.XoaCuoi();
            ds.Xuat();

            Console.Write("\nDanh sach sau khi xoa nut bat ky : ");
            int x = int.Parse(Console.ReadLine());
            ds.XoaNodebatKy(x);
            ds.Xuat();

            Console.WriteLine($"\nGia tri nut lon nhat : {ds.TimMax().Info}");
            Console.WriteLine($"\nGia tri trung binh cua danh sach : {ds.TinhTrungBinh()}");

            Console.ReadLine();
        }
    }
}
