using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(2240, "Huy" , 17);
            Student s2 = new Student(2241, "Anh" , 18);
            Student s3 = new Student(2242, "Duy" , 14);
            Student s4 = new Student(2243, "Tam" , 15);
            Student s5 = new Student(2244, "Dat" , 11);
            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);

            Console.WriteLine(students.ToString());
            foreach (var x in students) { Console.WriteLine(x.ToString()); };

            Console.WriteLine("--------------------------");
            var stu = students.Where(x => x.tuoi >= 15 && x.tuoi <= 18);
            Console.WriteLine("Danh sach hoc sinh co tuoi tu 15 den 18: ");
            foreach (var x in stu) { Console.WriteLine(x.ToString()); };

            Console.WriteLine("--------------------------");
            var stA = students.Where(x => x.hoten.StartsWith("A"));
            Console.WriteLine("Danh sach hoc sinh bat dau bang chu A: ");
            foreach (var x in stA) { Console.WriteLine(x.ToString()); };

            Console.WriteLine("--------------------------");
            var TT = students.Sum(x => x.tuoi);
            Console.WriteLine("Tong so tuoi:" +TT);
            var maxTuoi = students.Where(x => x.tuoi == students.Max(y => y.tuoi));


            Console.WriteLine("--------------------------");
            Console.WriteLine("Hoc sinh co so tuoi lon nhat: ");
            foreach(var x in maxTuoi) { Console.WriteLine(x.ToString()); };

            Console.WriteLine("--------------------------");
            Console.WriteLine("Danh sach sap xep theo tuoi tang dan: ");
            var stup = students.OrderBy(x => x.tuoi).ThenBy(m=>m);
            foreach (var x in stup) { Console.WriteLine(x.ToString()); };
        }
    }
}
