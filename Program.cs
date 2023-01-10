using System;

namespace Tip_Donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
         // Implicit Conversion (Bilinçsiz Dönüşüm):
         // Düşük kapasiteli bir değişkenin kendinden daha yüksek kapasiteli bir değişken dönüştürülmesi.
         Console.WriteLine("-o-o-o- Implicit Conversion -o-o-o-");

         byte byt = 1;
         sbyte sbyt = 2;
         short srt = 3;

         int int1 = byt+sbyt+srt;
         Console.WriteLine("int1:" + int1);

         long lng1 = int1;
         Console.WriteLine("lng1:" + lng1);

         float flt1 = lng1;
         Console.WriteLine("flt1:" + flt1);

         string str1 = "Utku";
         char chr1 = 'K';
         object obj1 = str1+chr1+lng1;
         Console.WriteLine("obj1:"+obj1);

         // Explicit Conversion (Bilinçli Dönüşüm):
         // "Convert" - "Parse" - "ToString"
         Console.WriteLine("-o-o-o- Explicit Conversion -o-o-o-");

         int int2 = 16;
         byte byt2 = (byte)int2; // Parantezin içi, sağındaki veri tipini parantezdeki veri tipine dönüştürmeye çalışır.
         Console.WriteLine("byt2:"+byt2);

         int int3 = 255;
         byte byt3 = (byte)int3;
         Console.WriteLine("byt3:"+byt3);

         float flt2 = 12.6f;
         byte byt4 = (byte)flt2;
         Console.WriteLine("byt4:"+byt4); // Tam sayıya yuvarladı. Çevrimlerde veri kaybı olabilir.

         // "ToString" Dönüşüm:
         Console.WriteLine("-o-o-o- ToString Donusum -o-o-o-");

         int int4 = 100;
         string str2 = int4.ToString();
         Console.WriteLine("str2:"+str2);

         string str3 = 24.8f.ToString();
         Console.WriteLine("str3:"+str3);

         // System.Convert Dönüşüm:
         Console.WriteLine("-o-o-o- System.Convert Donusum -o-o-o-");

         string str4 = "5", str5 = "7";
         int int5, int6;
         int Toplam,

         int7 = Convert.ToInt32(str4);
         int6 = Convert.ToInt32(str5);

         Toplam = int7+int6;
         Console.WriteLine("Toplam:"+Toplam);

         // Deneme:
         Console.WriteLine("-o-o-o- Deneme -o-o-o-");
         byte a = 1;
         int b = Convert.ToInt32(a);
         Console.WriteLine("b:"+b);

         string stra = "5";
         byte bytb;
         bytb = Byte.Parse(stra);
         Console.WriteLine("stringtobyte:"+bytb);

         decimal dcma = 14.1;
         float flta;
         
        

         long lnga = 1;
         int intd;
         intd = Convert.ToInt32(lnga);
         Console.WriteLine("intd:"+intd);

         // Parse Dönüşüm:
         // string ifadelere dönüştürmede kullanılır.
         Console.WriteLine("-o-o-o- Parse Donusum -o-o-o-");
         ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "12.36";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("Rakam1:"+rakam1);
            Console.WriteLine("Double1:"+double1);
        }

    }
}