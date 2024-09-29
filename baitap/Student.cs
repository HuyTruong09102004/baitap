using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    internal class Student
    {
        private int mssv;
        private string Hoten;
        private int Tuoi;

        public int MSSV { get => mssv; set => mssv = value; }
        public string hoten { get => Hoten; set => Hoten = value; }
        public int tuoi { get => Tuoi; set => Tuoi = value; }

        public Student(int mssv, string Hoten, int Tuoi)
        { 
            this.mssv = mssv;   
            this.Hoten = Hoten;
            this.Tuoi = Tuoi;
        }
        public override string ToString()
        {
            return "Student(mssv= "+mssv+",Hoten="+hoten+",Tuoi="+tuoi+")";
        }
    }
}

