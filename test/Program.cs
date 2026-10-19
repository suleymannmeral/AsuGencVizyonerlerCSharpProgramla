
Console.Write("Öğrenci sayısını girin: ");
int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());

string enBasariliOgrenci = "";
string enDusukOgrenci = "";

double enYuksekOrtalama = -1;
double enDusukOrtalama = 101;
double sinifToplami = 0;

for (int i = 1; i <= ogrenciSayisi; i++)
{
    Console.WriteLine("\n" + i + ". öğrenci");

    Console.Write("Öğrencinin adı: ");
    string ad = Console.ReadLine();

    double toplam = 0;

    for (int j = 1; j <= 2; j++)
    {
        Console.Write(j + ". sınav notu: ");
        double not = Convert.ToDouble(Console.ReadLine());

        toplam += not;
    }

    double ortalama = toplam / 2;

    Console.WriteLine(ad + " öğrencisinin ortalaması: " + ortalama);

    sinifToplami += ortalama;

    if (ortalama > enYuksekOrtalama)
    {
        enYuksekOrtalama = ortalama;
        enBasariliOgrenci = ad;
    }

    if (ortalama < enDusukOrtalama)
    {
        enDusukOrtalama = ortalama;
        enDusukOgrenci = ad;
    }
}

double sinifOrtalamasi = sinifToplami / ogrenciSayisi;

Console.WriteLine("\n===== SINIF RAPORU =====");
Console.WriteLine("Sınıf ortalaması: " + sinifOrtalamasi);
Console.WriteLine("En yüksek ortalamaya sahip öğrenci: "
    + enBasariliOgrenci);
Console.WriteLine("En yüksek ortalama: " + enYuksekOrtalama);
Console.WriteLine("En düşük ortalamaya sahip öğrenci: "
    + enDusukOgrenci);
Console.WriteLine("En düşük ortalama: " + enDusukOrtalama);
