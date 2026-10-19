

// parametreli ve geriye deger döndürmeyen

// parametrleti ve geriye değer döndüren

//parametresiz geriye değer döndüren

// parametresiz geriye değer döndürmeyen



// parametresiz geriye değer döndürmeyen

//MerhabaBurdur();
//MerhabaAksaray();



//static void MerhabaAksaray()
//{
//    Console.WriteLine("Merhaba Aksaray");
//}

//static void MerhabaBurdur()
//{
//    Console.WriteLine("Merhab Burdur");
//}


// parametreli ve geriye deger döndürmeyen
//static void BenimYasim(int age)
//{
//    Console.WriteLine("Benim yaşım" + age);
//}


//BenimYasim(24);


//static int KareAlanı(int kenar)
//{
//    return kenar * kenar;

//}



//Console.WriteLine(KareAlanı(7));


//static double PiSayisiniDondur()
//{
//    return Math.PI;
//}
//Console.WriteLine(PiSayisiniDondur());



//static string BilgilerimiGetir(string ad,string numara,int yas,string soyad)
//{

//    return $"Adım{ad}, numaram: {numara}, yaşım: {yas} soyad: {soyad} ";
//}




//Console.WriteLine(BilgilerimiGetir("süleyman", "26", 24,"meral"));


// Örnek Sorular


// ===================================================================
// Alıştırma (1): Daire Alan ve Çevre Hesaplama
// ===================================================================
// Soru: Kullanıcıdan yarıçap uzunluğu alınan bir dairenin alanını ve çevresini 
//       hesaplayan bir program yazınız.
// 
// Kabul Kriterleri (Acceptance Criteria):
// - Kullanıcıdan yarıçap (r) değeri alınmalıdır (ondalıklı sayılar desteklenmelidir).
// - Dairenin alanı hesaplanmalıdır (Alan = pi * r * r).
// - Dairenin çevresi hesaplanmalıdır (Çevre = 2 * pi * r).
// - Sonuçlar ekran çıktısı olarak kullanıcıya sunulmalıdır.

//Readline
//int tipte bir değişken olusturucam
////Writeline
///


//Console.Write("Lütfen yarıçap giriniz: ");
//int yaricap= Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Dairenin Alanı:"+DaireAlaniHesapla(yaricap));
//double daireCevresi = DaireCevresiHesapla(yaricap);
//Console.WriteLine("Dairenin Çevresi:"+daireCevresi);



//static double DaireAlaniHesapla(double yaricap)
//{
//    return Math.PI * yaricap * yaricap;
//}

//static double DaireCevresiHesapla(double yaricap)
//{
//    return 2 * Math.PI * yaricap;
//}


// Örnek Sorular

// ===================================================================
// Alıştırma (2): FizzBuzz Algoritma Uygulaması
// ===================================================================
// Soru: Kullanıcıdan bir tam sayı alın ve 1'den bu sayıya kadar olan sayıları 
//       belirli koşullara göre ekrana yazdırın.
// 
// Kabul Kriterleri (Acceptance Criteria):
// - 1'den girilen sayıya kadar olan döngü eksiksiz kurulmalıdır.
// - Sayı 3'e tam bölünüyorsa sayı yerine "Fizz" yazdırılmalıdır.
// - Sayı 5'e tam bölünüyorsa sayı yerine "Buzz" yazdırılmalıdır.
// - Sayı hem 3'e hem de 5'e tam bölünüyorsa "FizzBuzz" yazdırılmalıdır.
// - Bu koşulların hiçbirini sağlamıyorsa sayının kendisi yazdırılmalıdır.

//Console.Write("Lütfen bir sayı giriniz:");
//int sayi = Convert.ToInt32(Console.ReadLine());

//for(int i = 1; i<= sayi; i++)
//{

//    if (i % 3 == 0 && i % 5 == 0)
//    {
//        Console.WriteLine("FizzBuzz");
//    }
//    else if(i%5==0)
//    {
//        Console.WriteLine("Buzz");
//    }
//    else if(i%3==0)
//    {
//        Console.WriteLine("Fizz");
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }
//}













// // Alıştırma (3): 1'den N Sayısına Kadar Olan Sayıların Toplamı


//Console.WriteLine("Lütfen bir sayı giriniz: ");
//int sayi = Convert.ToInt32(Console.ReadLine());

//int sonuc = SayilarinToplami(sayi);

//Console.WriteLine("Toplam değer:" + sonuc);

//static int SayilarinToplami(int n)
//{
//    int toplam = 0;

//    for(int i = 0; i<n;i++)
//    {
//        toplam = toplam + i;  // toplam+=i
//    }

//    return toplam;


//}




// ===================================================================
// Alıştırma (4): Maksimum Sayı Bulma Mantığı
// ===================================================================
// Soru: Math kütüphanesindeki Max metodunun mantığını simüle eden, kullanıcıdan 
//       alınan iki sayıdan büyük olanı bulan bir program yazınız.
// 
// Kabul Kriterleri (Acceptance Criteria):
// - Kullanıcıdan 2 adet tamsayı girdisi alınmalıdır.
// - Girilen sayılar karşılaştırılarak büyük olan değer tespit edilmelidir.
// - Büyük olan sayı ekrana anlaşılır bir mesajla yazdırılmalıdır.


Console.Write("Lütfen birinci sayıyı giriniz:");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Lütfen ikinci sayıyı giriniz:");
int sayi2 = Convert.ToInt32(Console.ReadLine());

BuyukSayiyiBul(sayi1, sayi2);

static void BuyukSayiyiBul(int x , int y)
{
    if(x<y)
    {
        Console.WriteLine($"{y} sayısı daha büyüktür.");
    }
    else if(x>y)
    {
        Console.WriteLine($"{x} sayısı daha büyüktür");
    }
    else
    {
        Console.WriteLine("sayılar eşittir");
    }


}


 













