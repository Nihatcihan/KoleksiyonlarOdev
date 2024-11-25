// See https://aka.ms/new-console-template for more information
//Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

using System.Collections;

   Console.Write("Lutfen bir cumle giriniz: ");
        string cumle = Console.ReadLine();
        cumle = cumle.ToLower();

        ArrayList list = new ArrayList();
        foreach(var item in cumle) {
            if (item == 'a' || item == 'e' || item == 'ı' || item == 'i' || item == 'o' || item == 'ö'|| item == 'u' || item == 'ü')
            {
                list.Add(item);
            }
        }
        
        Console.WriteLine("Dizinin sesli elemanlari: ");
        foreach(var item in list)
            Console.Write(item + ",");
    