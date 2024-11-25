// See https://aka.ms/new-console-template for more information
// Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

// Negatif ve numeric olmayan girişleri engelleyin.
// Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
// Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

using System.Collections;
int kontrol=0;
ArrayList sayilar = new ArrayList();
Console.WriteLine("Lütfen 20 adet sayı giriniz");
try
{
    for (int i = 0; i < 20 ; i++)
    sayilar.Add(Convert.ToUInt32(Console.ReadLine()));
}
catch (System.Exception)
{
    Console.WriteLine("Lütfen doğru bir değer giriniz");
}

ArrayList asallar =new ArrayList();
ArrayList asalOlmayan = new ArrayList();

foreach (uint item in sayilar)
{
    kontrol=0;
    for (int i = 2; i < item; i++)
    {
        if(item%i ==0){
            asalOlmayan.Add(item);
            break;
        }
        else
            kontrol++;

        if(kontrol == item-2)
            asallar.Add(item);
    }
}
asallar.Sort();
asallar.Reverse();
asalOlmayan.Sort();
asalOlmayan.Reverse();
Console.WriteLine("Asal olmayan sayılar");
foreach (uint item in asalOlmayan) //büyükten küçüğe
    Console.WriteLine(item);
Console.WriteLine("Asal Sayılar");
foreach (uint item in asallar) //büyükten küçüğe
    Console.WriteLine(item);

long toplam1 =0,toplam2=0;
long ortalama1 =0, ortalama2=0;
foreach (uint item in asalOlmayan)
    toplam1 += item;
foreach (uint item in asallar)
    toplam2 += item;

ortalama1 = toplam1/asalOlmayan.Count;
ortalama2 = toplam2/asallar.Count;

Console.WriteLine("AsalOlmayanlar dizisinin eleman sayisi: "+asalOlmayan.Count+" ortalaması: "+ortalama1);
Console.WriteLine("Asallar dizisinin eleman sayisi: "+asallar.Count+" ortalaması: "+ortalama2);