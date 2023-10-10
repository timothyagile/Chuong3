using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3_NguyenPhucThinh_22521415
{
    public class PhanSo
    {
        private int tu;
        private int mau;
        public int Tu
        {
            get { return tu; } set { tu = value; }
        }
        public int Mau
        {
            get { return mau; }
            set
            {
                mau = value;
            }
        }
        public PhanSo RutGon()
        {
            int a = Math.Abs(this.Tu);
            int b = Math.Abs(this.Mau);
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            this.Tu /= a;
            this.Mau /= b;
            return this;
        }
        public PhanSo(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public PhanSo() { }
        public PhanSo Cong(PhanSo a)
        {
            PhanSo tmp = new PhanSo();
            tmp.tu = Tu * a.Mau + Mau * a.Tu;
            tmp.Mau = Mau * a.Mau;
            tmp = tmp.RutGon();
            return tmp;
        }
        public PhanSo Tru(PhanSo a)
        {
            PhanSo tmp = new PhanSo();
            tmp.tu = Tu * a.Mau - Mau * a.Tu;
            tmp.Mau = Mau * a.Mau;
            tmp = tmp.RutGon();
            return tmp;
        }
        public PhanSo Nhan(PhanSo a)
        {
            PhanSo tmp = new PhanSo(1, 1);
            tmp.tu = Tu * a.Tu;
            tmp.Mau = Mau * a.Mau;
            tmp = tmp.RutGon();
            return tmp;
        }
        public PhanSo Chia(PhanSo a)
        {
            PhanSo tmp = new PhanSo(1, 1);
            tmp.tu = Tu * a.Mau;
            tmp.Mau = Mau * a.Tu;
            tmp = tmp.RutGon();
            return tmp;
        }
        public override string ToString()
        {
            return this.Tu.ToString() + "/" + this.Mau.ToString();
        }
    }
}
