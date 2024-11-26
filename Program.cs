using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace busForSchool
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            List<string> studentList = new List<string>();
            int studentCount = 0;
            int busCapacity = 0;
            int decision;

            while (true)
            {
                GetMenu();
                decision = int.Parse(Console.ReadLine());
                switch (decision)
                {
                    case 1:
                        AddStudent(studentList, ref studentCount);
                        break;
                    case 2:
                        Console.WriteLine($"toplam öğrenci sayısı: {studentCount}");
                        break;
                    case 3:
                        BusCapacity(ref busCapacity);
                        break;
                    case 4:
                        goto print;
                    default:
                        Console.WriteLine("Hatalı Giriş Yaptınız");
                        break;
                }
            }
            print:
            if (busCapacity < studentCount) 
            {
                Console.WriteLine("otobüs kapastiesi aşılmıştır");
            }
            else Console.WriteLine("otosbüs hazır");

        }

        private static void AddStudent(List<string> studentList, ref int studentCount)
        {
            Console.WriteLine("Öğrenci Adını Giriniz");
            string studentName = Console.ReadLine();
            studentList.Add(studentName);
            studentCount++;
        }

        private static void BusCapacity(ref int busCapatity)
        {
            Console.WriteLine("Otobüs Kapasitesini Giriniz");
            int busCapacity = Convert.ToInt32(Console.ReadLine());
        }
        private static void GetMenu()
        {
            Console.Clear();
            Console.WriteLine(Menu);
            Console.Write("Ana Sayfa>");
        }
        private static string Menu => @"lütfen yapmak istediğiniz işlemi seçiniz
1.Öğrenci Ekle
2.Devam Et
3.Otobüs Kapasitesini seç";
    }
}