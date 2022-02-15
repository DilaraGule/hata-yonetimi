using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz.");
            try{
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayı " + sayi);

            }
            catch(Exception ex){
                Console.WriteLine("Hata! " + ex.Message.ToString());

            }
            /*finally{
                Console.WriteLine("İşlem Tamamlandı");
            }*/

            try{
                //int a = int.Parse(null);
                //int b = int.Parse("test");
                int c = int.Parse("-2000000000");

            }
            catch(ArgumentNullException ex){
                Console.WriteLine("boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex){
                Console.WriteLine("uygunsuz veri tipi ");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex){
                Console.WriteLine("değer çok küçük veya çok büyük ");
                Console.WriteLine(ex);
            }
        }
    }
}
