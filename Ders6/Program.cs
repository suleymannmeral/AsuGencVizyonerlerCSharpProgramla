
namespace Ders6;

internal class Program
{
    static void Main(string[] args)
    {



        // Döngüler 
        //Döngüler, bir kod bloğunu belirli
        //bir koşul sağlandığı sürece veya belirli sayıda tekrar çalıştırmamızı sağlayan yapılardır.

        //(1) While Döngüsü




        //while, belirtilen koşul doğru olduğu sürece çalışır. Koşul, döngünün başında kontrol edilir.


        //while (condition)  // Condition true oldugu sürece bu kod blogu calısır
        //{
        //    // code block to be executed
        //}


        //int sayi = 5;

        //while(sayi>5) // false 
        //{
        //    Console.WriteLine("Hello world");
        //}

        //sayi--;

        //int sayi = 10;

        //while (sayi > 5) // koşulum true o yüzden çalışır 
        //{

        //    Console.WriteLine("Hello world");
        //    sayi--;

        //}

        //Console.WriteLine("Döngü bitti");


        //int sayi = 0;
        //while(sayi<=10)
        //{
        //    Console.WriteLine(sayi);
        //    sayi++;
        //}



        // Kullanıcının girdiği miktar kadar ekrana hello world yazalım. 

        //Console.WriteLine("Lütfen bir sayı giriniz");
        //int sayi = Convert.ToInt32(Console.ReadLine());
        //int baslangic= 0;

        //while (baslangic < sayi)
        //{
        //    Console.WriteLine("Hello world");
        //    //baslangic++;
        //    sayi--;
        //}


        // Do While
        //int sayi = 5;
        //do
        //{
        //    Console.WriteLine(sayi);
        //}
        //while (sayi > 6);


        //while (sayi > 6)
        //{
        //    Console.WriteLine("hello");
        //}






        //1. İterasyon  




        // 1'den kullanıcının girdiği sayıya kadar olan'sayıları ekrana yazdılarım



        // For Loop 

        //for (statement 1; statement 2; statement 3)
        //{
        //    // code block to be executed
        //}



        //Statemen1:  kod bloğunun yürütülmesinden önce(bir kez) yürütülür. 
        // Statement2: Kod bloğunun yürütülmesi için gereken koşulu tanımlar.
        // Statemen3: kod bloğu yürütüldükten sonra (her seferinde) çalıştırılır.



        //for(int baslangic = 0; baslangic<5;baslangic++ )
        //{
        //    Console.WriteLine($"{baslangic+1}-> hellow");
        //}

        // Kullanıcıdan aldığınız ismi ekrana kullanıcının istediği kadar yazdıran bir porgram yazınız.



        // 0 dan başlayarak 10 sayıya kadar olan çift sayıları ekrana yazdırınız.

        //for (int baslangic = 0; baslangic < 10; baslangic+=2)
        //{
        //    Console.WriteLine(baslangic);
        //}



        //  Nested Loops


        //for (int i = 1; i <= 3; i++)
        //{

        //    for (int j = 1; j <= 3; j++)
        //    {
        //        Console.Write("* ");
        //    }


        //    Console.WriteLine();
        //}

        // ***
        // ***
        // ***







        //Foreach Loop

        //foreach (type variableName in arrayName)
        //{
        //    // code block to be executed
        //}



        //string[] araba = {"Volvo","Ford","BMW"};

        //foreach(string arabaAdi in araba )
        //{
        //    Console.WriteLine( arabaAdi );
        //}




        //string[] programmingLanguages = { "C#","Python","Java","Dart","Fortran"};

        //foreach (var i in programmingLanguages)
        //{
        //    Console.WriteLine(i);
        //}


        //for (int i = 0; i <= 5; i++)
        //{
        //    if (i == 3)
        //        break;


        //    Console.WriteLine(i);

        //}
        //for (int i = 0; i <= 5; i++)
        //{
        //    if (i == 3)
        //    {

        //        continue;
        //    }



        //    Console.WriteLine(i);

        //}

        // 1 den 10a kadar çift sayıalrı ekrana yazdıırn
        //for(int i = 1;i<10;i++)
        //{
        //    if (i % 2 != 0)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(i);


        //}










        //Break








        //Döngüden çıkmak için kullanılır.
        //for (int i = 0; i < 10; i++)
        //{
        //    if (i == 4)
        //    {
        //        break;
        //    }
        //    Console.WriteLine(i);
        //}

        // Continue
        //`continue` ifadesi, belirli bir koşul gerçekleştiğinde(döngü içindeki) bir iterasyonu keser ve döngüdeki bir sonraki yineleme ile devam eder.

       

        // Arrays 
        //Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.
        //Diziler, her bir değer için ayrı değişkenler tanımlamak yerine, birden fazla değeri tek bir değişkende depolamak için kullanılır.

        string[] meyve = { "Elma", "Armut", "Muz" };
        int[] sayilar = { 8,7,6,15,980,-2 };
        int[] sayilar2 = { 8,7,6,15,980,-3 };

        //Console.WriteLine(meyve.Length);

        //Array.Sort(sayilar); 
        //Array.Reverse(sayilar); //Terse çevirir
        //Console.WriteLine(sayilar.SequenceEqual(sayilar2));

        //Random.Shared.Shuffle(sayilar); // dizilerin elemanlarını karıstırı
        //foreach(int i in sayilar)
        //{
        //    Console.WriteLine(i);
        //}

        //foreach(int i in sayilar2)
        //{
        //    Console.WriteLine(i);
        //}


        //foreach (int a in sayilar)
        //{
        //    Console.WriteLine(a);

        //}

        //Sort an Array



        //Multidimensional Arrays





        //int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

        ////for (int i = 0; i < numbers.GetLength(0); i++)
        ////{
        ////    for (int j = 0; j < numbers.GetLength(1); j++)
        ////    {
        ////        Console.WriteLine(numbers[i, j]);
        ////    }
        ////}


        //Console.WriteLine(numbers[1,1]);







        // Alıstırmalar
        // Kullanıcının Girdiği Sayının Faktöriyelini Hesaplayan bir program yazın.
        // (0 faktoriyelin bir oldugunu dikkate alın)
        Console.Write("Bir sayı giriniz: ");
        string giris = Console.ReadLine();

        if (int.TryParse(giris, out int sayi)) // 
        {
            if (sayi < 0)
            { 
                Console.WriteLine("Negatif sayıların faktöriyeli hesaplanamaz.");
            
            }
            else
            {
                int i = 1; int faktoriyel = 1;
                while (i <= sayi)
                {
                    faktoriyel *= i;
                    i++;
                }

                Console.WriteLine("Faktöriyel: " + faktoriyel);
            }
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir tam sayı giriniz!");
        }




    }
}
