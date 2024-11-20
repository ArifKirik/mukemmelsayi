namespace _221120241014_Arif_Kirik_Mükemmel_sayı
{
    internal class Program
    {
        static void Main(string[] args)
        { int sayi,bölentoplam;
            bölentoplam = 0;
            Console.WriteLine("bir sayı giriniz:");
            sayi=Convert.ToInt32(Console.ReadLine());

            for(int i = sayi; i >0; i/=10)
            {
                bölentoplam =+ i % 10;
            }
            if(bölentoplam==sayi)
            {
                Console.WriteLine("sayi mükemmel sayıdır");
            }
            else
            {
                Console.WriteLine("sayi mükemmel değildir");
            }

        }
    }
}
