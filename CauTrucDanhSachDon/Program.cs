using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTrucDanhSachDon
{
        class Program
    {
        static void Main(string[] args)
        {
            DanhSachLienKetDon ds = new DanhSachLienKetDon();
            Console.WriteLine("Danh sach ");
            ds.ThemDau(2);
            ds.ThemDau(1);

            ds.ThemCuoi(3);
            ds.Xuat();
            Console.WriteLine("\nDanh sach xoa dau");
            ds.XoaDau();
            ds.Xuat();
            Console.WriteLine("\nDanh sach xoa cuoi");
            ds.XoaCuoi();
            ds.Xuat();
            Console.ReadLine();
        }
    }
}
