﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTrucDanhSachDon
{

    class Node
    {
        private int info;
        private Node next;

        public Node(int x)
        {
            info = x;
            next = null;
        }
        public int Info
        {
            set { info = value; }
            get { return info; }
        }
        public Node Next
        {
            set { next = value; }
            get { return next; }
        }
    }
    class DanhSachLienKetDon
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
        public void Xuat()
        {
            Node p = head;
            while(p != null)
            {
                Console.Write($"{p.Info}\t");
                p = p.Next;
            }
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            DanhSachLienKetDon ds = new DanhSachLienKetDon();
            ds.ThemDau(2);
            ds.ThemDau(1);

            ds.ThemCuoi(3);
            ds.Xuat();
            Console.ReadLine();
        }
    }
}