namespace Ders5;

internal class Program
{
    static void Main(string[] args)
    {

        // IF ELSE YAPISI
        // Koşullara göre farklı işlemler yapmak için if-else yapısı kullanılır.

        //Console.WriteLine("1. sayıyı giriniz: ");
        //int sayi1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("2.sayıyı giriniz: ");
        //int sayi2 = Convert.ToInt32(Console.ReadLine());

        //if (sayi1 > sayi2) // içerisi true olursa çalışır
        //{
        //    Console.WriteLine("1. sayı 2. sayıdan büyüktür.");
        //}
        //else if (sayi1 < sayi2) // içerisi true olursa çalışır
        //{
        //    Console.WriteLine("1. sayı 2. sayıdan küçüktür.");
        //}
        //else
        //{
        //    Console.WriteLine("1. sayı 2. sayıya eşittir.");
        //}

        // Alıştırma(3)
        // Girilen sayının pozitif,negatif veya
        // sıfır olduğunu ekrana yazdıran bir program geliştiriniz.



        // 


        //Console.WriteLine("Lütfen bir sayı giriniz:");
        //int sayi=Convert.ToInt32(Console.ReadLine());

        //if (sayi > 0)
        //{
        //    Console.WriteLine("Girilen sayı pozitiftir.");
        //}
        //else if (sayi < 0)
        //{
        //    Console.WriteLine("Girilen sayı negatiftir.");

        //}
        //else
        //{
        //    Console.WriteLine("Girilen sayı sıfırdır.");
        //}


        // Alıştırma(4)
        // Girilen sayının tek mi çift mi olduğunu
        // ekrana yazdıran bir program geliştiriniz

        // Lütfen bir sayı girniz: 5
        // Girilen sayı tektir.
        // Lütfen bir sayı girniz: 6
        // Girilen sayı çifttir.

        //Console.WriteLine("Lütfen bir sayı giriniz:");
        //int sayi= Convert.ToInt32(Console.ReadLine());

        //if (sayi % 2 == 0)
        //{
        //    Console.WriteLine("Sayı çifttir.");
        //}
        //else
        //{
        //    Console.WriteLine("Sayı tektir.");
        //}

        // Switch Case Yapısı

        string haftaGunu = "Cumartesi";

        switch (haftaGunu)
        {
            case "Pazartesi":
                Console.WriteLine("Haftanun ilk günü");
                break;
            case "Salı":
                Console.WriteLine("Haftanın ikinci günü");
                break;
            case "Çarşamba":
                Console.WriteLine("Haftanun üçüncü günü");
                break;
            case "Perşembe":
                Console.WriteLine("Perşembe");
                break;
            case "Cuma":
                Console.WriteLine("Cuma");
                break;
            case "Cumartesi":
                Console.WriteLine("Haftanın altıncı günü");
                break;
            case "Pazar":
                Console.WriteLine("Pazar");
                break;
            default:
                Console.WriteLine("Geçersiz gün");
                break;
        }








        //if (haftaGunu == 1)
        //{
        //    Console.WriteLine("pazartesi");
        //}
        //else if (haftaGunu == 2)
        //{
        //    Console.WriteLine("salı");
        //}
        //else if (haftaGunu == 3)
        //{
        //    Console.WriteLine("çarşamba");
        //}
        //else if (haftaGunu == 4)
        //{
        //    Console.WriteLine("perşembe");
        //}
        //else if (haftaGunu == 5)
        //{
        //    Console.WriteLine("cuma");
        //}
        //else if (haftaGunu == 6)
        //{
        //    Console.WriteLine("cumartesi");
        //}
        //else
        //{
        //    Console.WriteLine("geçersiz gün");
        //}


        // Alıştırma(6)
        // Switch case kullanarak basit bir 4 işlem uygulaması geliştiriniz. 

        // lütfen 1. sayıyı giriniz: 5
        // lütfen 2. sayıyı giriniz: 3
        // lütfen yapmak istediğiniz işlemi seçiniz: +, -, *, /


        Console.WriteLine("Lütfen 1. sayıyı giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen 2. sayıyı giriniz: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: +, -, *, /");
        
        char islem = Convert.ToChar(Console.ReadLine());

        switch (islem)
        {
            case '+':
                Console.WriteLine(sayi1+sayi2);
                break;

            case '-':
                Console.WriteLine(sayi1 - sayi2);
                break;

            case '*':
                Console.WriteLine(sayi1 * sayi2);
                break;

            case '/':
                if (sayi2 == 0)
                {
                    Console.WriteLine("Bir sayı sıfıra bölünemez.");
                }
                else
                {
                    Console.WriteLine(sayi1 / sayi2);
                }
                break;

            default:
                Console.WriteLine("Geçersiz işlem.");
                break;


        }
           
              











    }
}
