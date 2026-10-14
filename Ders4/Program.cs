namespace Ders4;

internal class Program
{
    static void Main(string[] args)
    {

        //int sayi = 5;
        ////sayi++; // sayının değerini 1 artırır
        ////sayi -= 3; // sayının değerini 3 azaltır  sayi = sayi - 3
        //sayi += 5; // sayının değerini 5 artırır  sayi = sayi + 5


        //Console.Write(sayi);

        //int x = 10;
        //Console.WriteLine(x == 10);   // false
        //Console.WriteLine(x != 10);   // true

        //Console.WriteLine(x > 10);  // true 
        //Console.WriteLine(x <= 10);  // false 

        //bool a = false;
        //bool b = true;
        //Console.WriteLine(a && b);
        //Console.WriteLine(a || b);

        //int num1 = 10;
        //int num2 = 20;

        //bool sonuc = num1 > num2;  // false 0 
        //bool sonuc2 = num1 < num2; // true 

        //Console.WriteLine(sonuc && sonuc2);

        //bool a = true;

        //Console.WriteLine(!a);  


        //int a = 10;
        //int b = 20;
        //int sonuc= a + b;

        // Math Kütüphanesi

        //double a = Math.Pow(5, 3.23);  // 3^3 = 27 Üs alır

        //double b = Math.Sqrt(4 + 5); // 49 un karekökünü alır


        //Console.Write(Math.Ceiling(4.3)); // 5.0  Yukarı yuvarlar
        //Console.Write(Math.Floor(4.3)); // 4.0  Aşağı yuvarlar
        //Console.Write(Math.Sin(Math.PI/2)); // 0.8939966636005579  Sinüs değerini verir
        //Console.Write(Math.Abs(-5)); // 5  Mutlak değerini verir
        //Console.WriteLine(Math.Max(2,3));


        //const  int  a = 5;

        //  // a = 10;  // This will cause a compile-time error since a is constant

        //  Console.WriteLine(a);



        // Stringler

        //string product= "bilgisayaroyun";
        //string type = "Oyun";

        //string sonuc = string.Concat(product, type,"aasdas");  // BilgisayarOyun string degiskeleri birlestirir
        //string sonuc = product + type;

        //product++;  // This will cause a compile-time error since product is a string and cannot be incremented




        //Console.WriteLine(product.ToLower()); // bilgisayarı küçük harflerle yazdırır
        //Console.WriteLine(product.ToUpper()); // BİLGİSAYAR  büyük harflerle yazdırır

        //string newWord= product.Replace("BİlGİSaYAR", "Ders4"); // Bilgisayar kelimesini Ders4 ile değiştirir
        //Console.WriteLine(product);

        //Console.WriteLine(product[0]);
        //Console.Write(product.Length); 
        //Console.WriteLine(product.Substring(2, 3));

        //Console.WriteLine(product.Replace("BİlGİSaYAR", "Ders4")); 











        //Kullanıcıdan iki adet sınav notunu alıp ortalamasını hesaplayın. Ekrana Aşağıdaki gibi yazdırın. if blogu kullanılmasın
        // 1.Sınav: 70
        // 2.Sınav: 80
        // Ortalama: 75
        // Geçme Durumu: False


        //Console.Write("Lütfen 1. Sınav Notunuzu Giriniz: ");
        //int exam1 = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Lütfen 2. Sınav notunuzu giriniz.");
        //int exam2 = Convert.ToInt32(Console.ReadLine());

        //double average = (exam1 + exam2) / 2;

        //bool isPassed = average >= 50;

        //Console.WriteLine($"1. Sınav: {exam1}");
        //Console.WriteLine($"2. Sınav: {exam2}");
        //Console.WriteLine($"Ortalama: {average}");
        //Console.WriteLine($"Geçme Durumu: {isPassed}");







        // Kullanıcıdan Adını ve Soyadınız Alınız. ve Ekrana Aşağıdaki gibi yazdırın.
        // Adınız: Sül*****
        // Soyadınız: ****al

        //Console.Write("Lütfen Adınızı Giriniz: ");
        //string name = Console.ReadLine();
        //Console.Write("Lütfen Soyadınızı Giriniz: ");
        //string surname = Console.ReadLine();

        //Console.WriteLine($"Adınız: {name.Substring(0, 2)}*****");
        //Console.WriteLine($"Soyadınız: ****{surname.Substring(surname.Length - 2)}");


        //Random random = new Random();

        //Console.WriteLine(random.Next(0, 17));




  










    }
}
