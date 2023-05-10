using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BaiThucHanh
{
    public class DaThuc
    {
        public SoHang Head;

        public void Them(double heso, int somu)
        {
            var newSoHang = new SoHang { HeSo = heso, SoMu = somu };
            if (Head == null) 
            {
                Head = newSoHang;
                Head.KeTiep = Head; 
            }
            else 
            {
                SoHang prev = null, curr = Head;
                while (curr != Head && curr.SoMu > somu)
                {
                    prev = curr;
                    curr = curr.KeTiep;
                }

                if (curr == Head && curr.SoMu <= somu) 
                {
                    newSoHang.KeTiep = Head;
                    Head = newSoHang;
                }
                else 
                {
                    prev.KeTiep = newSoHang;
                    newSoHang.KeTiep = curr;
                }
            }

        }
        public void RutGon()
        {
            SoHang prev = null, curr = Head;
            while (curr != null)
            {
                if (curr.HeSo == 0)
                {
                    if (prev != null)
                    {
                        prev.KeTiep = curr.KeTiep;
                    }
                    else
                    {
                        Head = curr.KeTiep;
                    }
                }
                else
                {
                    SoHang temp = curr.KeTiep;
                    while (temp != null && temp.SoMu == curr.SoMu)
                    {
                        curr.HeSo += temp.HeSo;
                        temp = temp.KeTiep;
                    }
                    prev = curr;
                    curr = curr.KeTiep;
                }
            }
        }
        public static DaThuc Cong(DaThuc dathuc1, DaThuc dathuc2)
        {
            DaThuc result = new DaThuc();
            SoHang p1 = dathuc1.Head;
            SoHang p2 = dathuc2.Head;
            while (p1 != null || p2 != null)
            {
                if (p1 == null)
                {
                    result.Them(p2.HeSo, p2.SoMu);
                    p2 = p2.KeTiep;
                }
                else if (p2 == null)
                {
                    result.Them(p1.HeSo, p1.SoMu);
                    p1 = p1.KeTiep;
                }
                else if (p1.SoMu > p2.SoMu)
                {
                    result.Them(p1.HeSo, p1.SoMu);
                    p1 = p1.KeTiep;
                }
                else if (p1.SoMu < p2.SoMu)
                {
                    result.Them(p2.HeSo, p2.SoMu);
                    p2 = p2.KeTiep;
                }
                else 
                {
                    double heso = p1.HeSo + p2.HeSo;
                    if (heso != 0)
                    {
                        result.Them(heso, p1.SoMu);
                    }
                    p1 = p1.KeTiep;
                    p2 = p2.KeTiep;
                }
            }
            result.RutGon();
            return result;
        }

        public void DoiDau()
        {
            SoHang current = Head;
            while (current != null)
            {
                current.HeSo *= -1;
                current = current.KeTiep;
            }
        }

        public DaThuc Tich(DaThuc dathuc2)
        {
            DaThuc result = new DaThuc();
            SoHang current1 = Head;
            while (current1 != null)
            {
                SoHang current2 = dathuc2.Head;
                while (current2 != null)
                {
                    double heSo = current1.HeSo * current2.HeSo;
                    int soMu = current1.SoMu + current2.SoMu;
                    result.Them(heSo, soMu);
                    current2 = current2.KeTiep;
                }
                current1 = current1.KeTiep;
            }
            result.RutGon();
            return result;
        }
        public DaThuc Chep()
        {
            DaThuc newDathuc = new DaThuc();

            SoHang currentNode = Head;
            while (currentNode != null)
            {
                SoHang newNode = new SoHang();
                newNode.HeSo = currentNode.HeSo;
                newNode.SoMu = currentNode.SoMu;

                if (newDathuc.Head == null)
                {
                    newDathuc.Head = newNode;
                }
                else
                {
                    SoHang lastNode = newDathuc.Head;
                    while (lastNode.KeTiep != null)
                    {
                        lastNode = lastNode.KeTiep;
                    }
                    lastNode.KeTiep = newNode;
                }

                currentNode = currentNode.KeTiep;
            }

            return newDathuc;
        }
        public void InDaThuc()
        {
            SoHang p = Head;
            bool isFirstTerm = true;
            while (p != null)
            {
                if (p.HeSo != 0)
                {
                    if (isFirstTerm)
                    {
                        Console.Write(p.HeSo);
                        isFirstTerm = false;
                    }
                    else if (p.HeSo > 0)
                    {
                        Console.Write(" + " + p.HeSo);
                    }
                    else
                    {
                        Console.Write(" - " + (-p.HeSo));
                    }

                    if (p.SoMu != 0)
                    {
                        Console.Write("x^" + p.SoMu);
                    }
                }

                p = p.KeTiep;
            }

            if (isFirstTerm)
            {
                Console.Write(0);
            }
        }









    }
}
