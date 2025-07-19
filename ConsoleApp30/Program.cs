using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // fayl yaratish
            string path = "text.txt";

            //  File.Create(path).Close();
            //  Console.WriteLine(File.Create(path));

            // faylga yozish
            //string matn = "Salom barchaga";
            //File.WriteAllText("text.txt", matn);


            // fayldan o'qish
            string malumot = File.ReadAllText("text.txt");
            Console.WriteLine(malumot);



            //// fayl bor yo'qligini tekshirish

            //if (File.Exists("text.txt"))
            //{
            //    File.Delete("text.txt"); // faylni o'chirish

            //    Console.WriteLine("Fayl bor va o'chirildi");
            //}

            //else
            //{
            //    Console.WriteLine("Fayl topilmadi");
            //}


            Console.WriteLine(Path.Combine("D:\\net\\filesc#\\filesc#\\obj", path));


            // Fayl haqida ma'lumotlar

            FileInfo fayl = new FileInfo("text.txt");

            Console.WriteLine("Fayl nomi: " + fayl.Name);
            Console.WriteLine("To‘liq yo‘l: " + fayl.FullName);
            Console.WriteLine("Hajmi: " + fayl.Length + " bayt");
            Console.WriteLine("Yaratilgan vaqti: " + fayl.CreationTime);
        }
    
    }
}
