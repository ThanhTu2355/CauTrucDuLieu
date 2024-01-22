using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTrucDanhSachDon
{
    internal class DanhSachLienKetDon
    {
        private Node head;
        public DanhSachLienKetDon()
        {
            head = null;
        }
        public void ThemDau(int x)
        {
            Node p = new Node(x);
            p.Next = head;
            head = p;
        }
        public void ThemCuoi(int x)
        {
            Node p = new Node(x);
            if (head == null)
            {
                head = p;
            }
            else
            {
                Node q = head;
                while (q.Next != null)
                {
                    q = q.Next;
                }
                q.Next = p;
            }
        }
        public void XoaDau()
        {
            if (head != null)
            {
                Node p = head;
                head = head.Next;
                p.Next = null;
            }
        }
        public void XoaCuoi()
        {
            if (head != null)
            {
                Node p = head;
                Node q = null;
                while (p.Next != null)
                {
                    q = p;
                    p = p.Next;
                }
                q.Next = null;
            }
        }
        public void XoaNodebatKy(int x)
        {
            if(head!=null)
            {
                Node p = head;
                Node q = null;
                while (p != null && p.Info!=x)
                {
                    q = p;
                    p = p.Next;
                }
                if(p!=null)
                {
                    if (p == head)
                    {
                        XoaDau();
                    }
                    else
                    {
                        q.Next = p.Next;
                        p.Next = null;
                    }
                }
            }
        }
        public Node TimMax()
        {
            Node max = head;
            Node p = null;
            while (p != null)
            {
                if (p.Info > max.Info)
                {
                    max = p;
                }
                p = p.Next;
            }

            return max;
        }
        public float TinhTrungBinh()
        {
            float sum = 0;
            float dem = 0;
            Node p = head;
            while(p!=null)
            {
                sum += p.Info;
                dem++;

                p = p.Next;
            }
            return sum / dem;
        }
        public void Xuat()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write($"{p.Info}\t");
                p = p.Next;
            }
        }
    }
}
