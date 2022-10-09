using System;

namespace diziler
{
    class Program 
    {
        static void Main(string[] args)
        {
            // dizi tanımlama 
            string[] renkler = new string[5];
            
            string[] hayvanlar = {"kedi", "köpek","at"," arı"};

            //2. yol
             var iller = new List<string>()
             {
                "çorum",
                "ankara",
                "istanbul",
                "adana"
             };

             //dizilere değer atama ve erişim

             Console.WriteLine(hayvanlar[1]);
             System.Console.WriteLine(iller[2]);

             //döngülerle dizi kullanımı 
             //klaveyeden girilen n tane sayının ortalamasını hesabı
             System.Console.Write("dizinin eleman sayısını giriniz: ");
             int diziUzunlugu=int.Parse(Console.ReadLine());
             int [] sayiDisizi= new int[diziUzunlugu];
             for (int i = 0; i < diziUzunlugu; i++)
             {
                System.Console.Write("{0}. sayıyı giriniz ", i+1);
                sayiDisizi[i]=int.Parse(Console.ReadLine());
                
             }

             int toplam=0;
             foreach (var sayi in sayiDisizi)
             {
                toplam+=sayi;

             }
             System.Console.WriteLine("ortalama :"+ toplam/diziUzunlugu);
        }
    }
}