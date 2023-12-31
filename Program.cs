internal class Program
{
    private static void Main(string[] args)
    {
       
      
        int deger1, deger2, toplam;

        Console.WriteLine("İlk değeri giriniz:");
        deger1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("İkinci değeri giriniz:");
        deger2 = Convert.ToInt32(Console.ReadLine());

        toplam = deger1 + deger2;

        Console.WriteLine("Sonuç = {0}", toplam);

        Console.ReadKey();
    }
}