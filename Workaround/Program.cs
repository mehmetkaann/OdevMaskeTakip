using Business.Concrete;
using Entities.Concrete;
using System;
using System.Reflection.Metadata;

namespace Workaround
{
    class Program
    {

        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Mehmet Kaan";
            person1.LastName = "Şirin";
            person1.DateOfBirthYear = 2006;
            person1.NationalIdentity = 12345678900;


            SelamVer(isim: "Ayşe");
            SelamVer();

            int sonuc = Topla(3, 5);
            Console.WriteLine(sonuc);


            string[] sehirler1 = new string[] { "Ankara", "Konya", "İstanbul" };
            

            foreach (String sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

        }


        static void SelamVer(string isim="Kullanıcı!")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1= 10, int sayi2= 20) 
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc);
            return sonuc;
        }

    }
}


