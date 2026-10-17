
        // ===================================================================
        // Alıştırma (1): FizzBuzz Algoritma Uygulaması
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

        //Console.Write("Bir tam sayı giriniz: ");
        //int sayi1 = Convert.ToInt32(Console.ReadLine());

        //for (int i = 1; i <= sayi1; i++)
        //{
        //    if (i % 3 == 0 && i % 5 == 0)
        //    {
        //        Console.Write("FizzBuzz ");
        //    }
        //    else if (i % 3 == 0)
        //    {
        //        Console.Write("Fizz ");
        //    }
        //    else if (i % 5 == 0)
        //    {
        //        Console.Write("Buzz ");
        //    }
        //    else
        //    {
        //        Console.Write(i + " ");
        //    }
        //}
        // ===================================================================
        // Alıştırma (2): Maksimum Sayı Bulma Mantığı
        // ===================================================================
        // Soru: Math kütüphanesindeki Max metodunun mantığını simüle eden, kullanıcıdan 
        //       alınan iki sayıdan büyük olanı bulan bir program yazınız.
        // 
        // Kabul Kriterleri (Acceptance Criteria):
        // - Kullanıcıdan 2 adet tamsayı girdisi alınmalıdır.
        // - Girilen sayılar karşılaştırılarak büyük olan değer tespit edilmelidir.
        // - Büyük olan sayı ekrana anlaşılır bir mesajla yazdırılmalıdır.
        //Console.Write("Birinci sayıyı giriniz: ");
        //int sayiA = Convert.ToInt32(Console.ReadLine());
        //Console.Write("İkinci sayıyı giriniz: ");
        //int sayiB = Convert.ToInt32(Console.ReadLine());

        //int maxDeger;

        //if (sayiA > sayiB)
        //{
        //    maxDeger = sayiA;
        //}
        //else
        //{
        //    maxDeger = sayiB;
        //}

        //Console.WriteLine($"Girilen sayılar arasından büyük olan: {maxDeger}");




        // ===================================================================
        // Alıştırma (3): Sesli ve Sessiz Harf Sayacı
        // ===================================================================
        // Soru: Kullanıcıdan alınan bir kelimedeki sesli ve sessiz harf miktarını 
        //       hesaplayıp raporlayan program yazınız.
        // 
        // Kabul Kriterleri (Acceptance Criteria):
        // - Kullanıcıdan bir kelime (string) girdisi istenmelidir.
        // - Kelimedeki sesli harfler (a, e, ı, i, o, ö, u, ü) ayrı olarak sayılmalıdır.
        // - Kelimedeki sessiz harfler ayrı olarak sayılmalıdır.
        // - Çıktı şu formatta verilmelidir: "[Kelime] Kelimesindeki Sesli Harf Miktari: X , Sessiz Harf Miktarı: Y"

        //Console.Write("Bir kelime giriniz: ");
        //string kelime = Console.ReadLine();

        //int sesliSayisi = 0;
        //int sessizSayisi = 0;
        //string sesliler = "aeıioöuüAEIİOÖUÜ";

        //foreach (char harf in kelime)
        //{
        //    if (char.IsLetter(harf))
        //    {
        //        if (sesliler.Contains(harf))
        //        {
        //            sesliSayisi++;
        //        }
        //        else
        //        {
        //            sessizSayisi++;
        //        }
        //    }
        //}
        //Console.WriteLine($"{kelime} Kelimesindeki Sesli Harf Miktari: {sesliSayisi} , Sessiz Harf Miktarı: {sessizSayisi}");


        // ===================================================================
        // Alıştırma (4): Daire Alan ve Çevre Hesaplama
        // ===================================================================
        // Soru: Kullanıcıdan yarıçap uzunluğu alınan bir dairenin alanını ve çevresini 
        //       hesaplayan bir program yazınız.
        // 
        // Kabul Kriterleri (Acceptance Criteria):
        // - Kullanıcıdan yarıçap (r) değeri alınmalıdır (ondalıklı sayılar desteklenmelidir).
        // - Dairenin alanı hesaplanmalıdır (Alan = pi * r * r).
        // - Dairenin çevresi hesaplanmalıdır (Çevre = 2 * pi * r).
        // - Sonuçlar ekran çıktısı olarak kullanıcıya sunulmalıdır.

        //Console.Write("Dairenin yarıçapını (r) giriniz: ");
        //double yariCap = Convert.ToDouble(Console.ReadLine());

        //double alan = Math.PI * yariCap * yariCap;
        //double cevre = 2 * Math.PI * yariCap;

        //Console.WriteLine($"Alan: {alan:F2}");
        //Console.WriteLine($"Çevre: {cevre:F2}");
