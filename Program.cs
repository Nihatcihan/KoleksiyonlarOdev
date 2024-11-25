// See https://aka.ms/new-console-template for more information
//Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)


using System.Collections;

ArrayList sayilar = new ArrayList();
Console.WriteLine("Lütfen 20 adet sayı giriniz");
try
{
    for (int i = 0; i < 20 ; i++)
    sayilar.Add(Convert.ToInt32(Console.ReadLine()));
}
catch (System.Exception)
{
    Console.WriteLine("Lütfen doğru bir değer giriniz");
}
sayilar.Sort();

int kucukortalama = (Convert.ToInt32(sayilar[0])+Convert.ToInt32(sayilar[1])+Convert.ToInt32(sayilar[2]))/3;
int buyukortalama = (Convert.ToInt32(sayilar[17])+Convert.ToInt32(sayilar[18])+Convert.ToInt32(sayilar[19]))/3;

Console.WriteLine("Küçüklerin ortalaması: "+kucukortalama);
Console.WriteLine("Büyüklerin ortalaması: "+buyukortalama);
Console.WriteLine("Ortalamların toplamı: "+(buyukortalama+kucukortalama));