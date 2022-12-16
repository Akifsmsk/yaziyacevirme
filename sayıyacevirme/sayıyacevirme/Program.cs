namespace sayıyacevirme;
class Program
{
    static void Main(string[] args)
    {
        int a;
        string s = "";
        string[] Bb = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
        string[] Ob = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
        string[] Yb = { "Yüz", "İkiYüz", "ÜçYüz", "DörtYüz", "BeşYüz", "AltıYüz", "YediYüz", "SekizYüz", "DokuzYüz" };
        Console.WriteLine("Lütfen Sayı Gİriniz");
        a = int.Parse(Console.ReadLine());
        if (a / 100 >= 1)
        {
            s += Yb[(a / 100) - 1];
            a = a % 100;
        }
        if (a / 10 >= 1)
        {
            s += Ob[(a / 10) - 1];
            a = a % 10;
        }
        if (a % 10 != 0)
        {
            s += Bb[(a % 10) - 1];
        }
        Console.WriteLine(s);
        Console.WriteLine("Lütfen bir tuşa basınız...");
        Console.ReadKey(true);
    }
}    