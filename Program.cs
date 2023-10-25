internal class Program
{
    private static void Main(string[] args)
    {
       int deger1, deger2, toplam;
        Console.WriteLine("ilk değerini giriniz :");
        deger1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ikinci değeri giriniz :");
        deger2 = Convert.ToInt32(Console.ReadLine());
        toplam = deger1 + deger2;
        Console.WriteLine("sonuç = {0} " + toplam);
        Console.ReadKey();
       
    }
}