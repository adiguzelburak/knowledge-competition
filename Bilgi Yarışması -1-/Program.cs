using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bilgi_Yarışması__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** BURAK ADIGÜZEL BİLGİ YARIŞMASI *****");
            Console.Title = "******    2020 BÜYÜK ÖDÜLLÜ BİLGİ YARIŞMASI   ******* ";
            string adsoyad, memleket;
            Console.WriteLine("Yarışmacı Adı ve Soyadı: ");
            adsoyad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Yarışmacı Memleketi: ");
            memleket = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Bilgiler İçin Teşekkürler... Hazır Olduğunuz An Enter'a Basınız...");
            
            Console.WriteLine("İşte İlk Soru Geliyor... ");
            
            Console.WriteLine("Son Bir Hatırlatma Cevapları Büyük Harflerle Veriniz ve Sorulardan Sonra Enter'a Basmayı Unutmayın Başarılar...");

            Console.ReadLine();
            int dogru, yanlis, para;
            dogru = 0;
            yanlis = 0;
            para = 0;

            string s1;
            Console.WriteLine("Soru-1) Türkiye'nin Başkenti Hangi İlimizdir? ");
            s1 = Convert.ToString(Console.ReadLine());
            string c1;
            Console.WriteLine(" A)Niğde\n B)İzmit\n C)Ankara\n D)Giresun\n Cevabınız: ");
            c1 = Console.ReadLine();
            if (c1 == "C")
            {
                para = para + 1000;
                dogru = dogru + 1;
                Console.WriteLine("Tebrikler Doğru Cevap");
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Maalesef Yanlış Cevap");
            }
            Console.WriteLine();
            string s2;
            Console.WriteLine("Soru-2) Fenerbahçe Kuruluş Tarihi Ne Zamandır?  ");
            s2 = Convert.ToString(Console.ReadLine());
            string c2;
            Console.WriteLine(" A)1907\n B)1905\n C)1903\n D)1998\n Cevabınız: ");
            c2 = Console.ReadLine();
            if (c2 == "A")
            {
                para = para + 1000;
                dogru = dogru + 1;
                Console.WriteLine("Tebrikler Doğru Cevap");
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Maalesef Yanlış Cevap");
            }
            Console.WriteLine();
            string s3;
            Console.WriteLine("Soru-3) Aşağıdaki İllerden Hangisi Karadeniz'dedir? ");
            s3 = Convert.ToString(Console.ReadLine());
            string c3;
            Console.WriteLine(" A)Niğde\n B)İzmit\n C)Ankara\n D)Giresun\n Cevabınız: ");
            c3 = Console.ReadLine();
            if (c3 == "D")
            {
                para = para + 1000;
                dogru = dogru + 1;
                Console.WriteLine("Tebrikler Doğru Cevap");
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Maalesef Yanlış Cevap");
            }
            Console.WriteLine();
            string s4;
            Console.WriteLine("Soru-4) 2010-2011 Sezonu Şampiyonu Hangi Takımdır? ");
            s4 = Convert.ToString(Console.ReadLine());
            string c4;
            Console.WriteLine(" A)Fenerbahçe\n B)Trabzonspor\n C)Beşiktaş\n D)Osmanlıspor\n Cevabınız: ");
            c4 = Console.ReadLine();
            if (c4 == "A")
            {
                para = para + 1000;
                dogru = dogru + 1;
                Console.WriteLine("Tebrikler Doğru Cevap");
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Maalesef Yanlış Cevap");
            }
            Console.WriteLine();
            string s5;
            Console.WriteLine("Soru-5) Dünyaın Şekli Nasıldır? ");
            s5 = Convert.ToString(Console.ReadLine());
            string c5;
            Console.WriteLine(" A)Düz(Tepsi)\n B)Elips\n C)Kare\n D)Üçgen\n Cevabınız: ");
            c5 = Console.ReadLine();
            if (c5 == "B")
            {
                para = para + 1000;
                dogru = dogru + 1;
                Console.WriteLine("Tebrikler Doğru Cevap");
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Maalesef Yanlış Cevap");
            }

            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("****Bir Yarışmanın Daha Sonuna Geldik İşte Tablo****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***Yarışmacı Bİlgileri***");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Yarışmacı Adı ve Soyadı : "+adsoyad);
            Console.WriteLine();
            Console.WriteLine("Memleketi: "+memleket);

            Console.WriteLine("Bildiği Soru Sayısı : "+dogru);
            Console.WriteLine();
            Console.WriteLine("Yanlış Sayısı: "+yanlis);
            Console.WriteLine();
            Console.WriteLine("Kazanılan Para Ödülü: "+para);

            Console.WriteLine();
            Console.WriteLine("Katıldığınız İçin Teşekkürler...");



            Console.Read();
        }
    }
}
