
// İmplicit Casting    otomatşk şekilde yapılır


//int number = 25;
//double doubleNumber = number; // Implicit casting from int to double

//Console.WriteLine(number.GetType());
//Console.WriteLine(doubleNumber.GetType());

// 

// Explicit Casting    manuel olarak yapılır

//double anotherDoubleNumber = 25.75;
//int number= (int)anotherDoubleNumber; // Explicit casting from double to int

//Console.WriteLine(number);
//Console.WriteLine(number.GetType());


//Console.Write("Lütfen doğum tarihinizi giriniz: ");

//string dateOfBirth = Console.ReadLine();

//// (1)
//int age= 2026- Convert.ToInt32(dateOfBirth);

//Console.WriteLine(age);


//Console.Write("Lütfen doğum tarihinizi giriniz: ");
//int dateOfBirth =Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Yaşınız: {2026 - dateOfBirth}");


// Kullanıcıdan bir yıl alınız. Şuanki yılla arasındaki farkı hesaplayınız.


//int sayi1 = 20;
//int sayi2 = 30;
////Console.WriteLine($"Sayıların çarpımı: {sayi1 * sayi2}");

//// * çarpma
//Console.WriteLine($"Sayıların çarpımı: {sayi1 * sayi2}");

////  / 
//Console.WriteLine($"Sayıların bölümü: {sayi1 / sayi2}");

// % modülüs 

//Console.WriteLine(sayi2 % sayi1); // 30 % 20 = 10

//sayi2--;
//Console.WriteLine(sayi2); 

// Kullanıcıdan iki adet sayı alınız. birinci sayının ikinci sayıya bölümünden kalanı hesaplayınız.

Console.Write("Lütfen birinci sayıyı giriniz:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci SAyıyı giriniz: ");
int num2 = Convert.ToInt32(Console.ReadLine());

//int result = num1 % num2;

Console.WriteLine($"Bölümden kalan: {num1%num2}");























