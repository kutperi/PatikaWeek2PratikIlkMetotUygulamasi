

// Geriye değer döndürmeyen bir void metot tanımlıyorum.
static void Lyrics()
{
    Console.WriteLine("Ji min can û ceger kuştin\nDil û mêlak hemî miştin\nTijî tîr û ber û xişt in\nBes e ev malmîratî\n");
}

Lyrics(); // Bu metodu çağırdığında şarkı sözlerini paylaşıyor.

// Burada rastgele bir sayı üretip 2'ye bölümünden kalanı geriye döndürüyor.
static int ModNumbers()
{
    Random rnd = new Random();
    int rastgele = rnd.Next(1, 11);
    return rastgele % 2;
}

Console.WriteLine("Rastgele sayının 2'ye bölümünde kalan: " + ModNumbers()); // Burada metodun çalışıp çalışmadığını kontrol ediyorum.


// Kullanıcıdan 3. metodun çalışıp çalışmadığını buradan başlayarak kontrol ediyorum.

Console.Write("\nLütfen ilk sayıyı girin: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Lütfen ikinci sayıyı girin: ");
int number2 = Convert.ToInt32(Console.ReadLine());
static int ProductNumbers(int number1, int number2) // Parametre alan ve geriye değer döndüren bir metot tanımlıyorum.
{
    return number1*number2;
}

Console.WriteLine("Girdiğiniz sayıların çarpımı: " + ProductNumbers(number1,number2));


// Tanımladığım dördüncü metodu kullanıcıdan adını soyadını girmesini isteyerek kontrol ediyorum.
Console.Write("\nLütfen isminizi yazınız: ");
string name = Console.ReadLine();

Console.Write("Lütfen soyadınızı yazınız: ");
string surname = Console.ReadLine();

GreetUser(name, surname);
static void GreetUser(string name, string surname) // Parametre alan ve geriye değer döndürmeyen bir metot tanımlıyorum.
{
    Console.WriteLine($"Hoşgeldiniz {name} {surname}");
}

