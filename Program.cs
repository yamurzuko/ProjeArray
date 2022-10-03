Console.WriteLine("****** Dizinin Sıralanmış hali ******");

int[] sayiDizisi = {23,12,4,86,72,3,11,17};

foreach (var sayi in sayiDizisi)
{
    Console.Write(sayi + " ");
}

Console.WriteLine();

// Sort 
Console.WriteLine("****** Dizinin Sıralanmış hali ******");

Array.Sort(sayiDizisi);

foreach (var sayi in sayiDizisi)
{
    Console.Write(sayi + " ");
}

Console.WriteLine();

// Clear
Console.WriteLine("****** Dizinin İstenilen Degerlerini Silme ******");

Array.Clear(sayiDizisi,2,2);

foreach (var sayi in sayiDizisi)
{
    Console.Write(sayi + " ");
}

Console.WriteLine();

// Reverse
Console.WriteLine("****** Dizi elemanlarini tersten yazdirma ******");

Array.Reverse(sayiDizisi);

foreach (var sayi in sayiDizisi)
{
    Console.Write(sayi + " ");
}

Console.WriteLine();

// İndexOf

Console.WriteLine("***** Girilen degerin indeksini dönderir *****");

Console.WriteLine(Array.IndexOf(sayiDizisi,23));










