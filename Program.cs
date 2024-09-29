
// ArrayList bir koleksiyondur.

// syntax : 

using System.Collections;


// koleksiyonda, diziler gibi kapasite vermek zorunda değilsiniz.
// koleksiyonlar, siz eleman girdikçe genişleyen yapılardırr.

// sonsuz adet eleman dahi girseniz koleksiyon her bir eleman girildiğinde, kapasitesini artırır.
// 

// arraylist koleksiyonu, içerisine object değer alan bir koleksiyondur.
//ArrayList arrayList= new ArrayList();

// koleksiyona eleman ekleyelim

//arrayList.Add("Mercedes");
//arrayList.Add("Audi");
//arrayList.Add("Fiat");

// yukarıdaki arraylist'e eleman ekledikçe, array list kapasitesini büyütüp bu elemanları alır.

// ArrayList'in içerisindeki eleman sayısını görmek için 
//int count = arrayList.Count;
//int capacity = arrayList.Capacity;

// Count, arraylist'in içerisindeki elaman sayısını söyler.
// Capacity : ArrayList'in alabileceği eleman sayısını belirtir.

// Capacity : Siz eleman girdikte artmaktadır.

// for döngüsü ile arraylist doldurma

/*ArrayList arrayList = new ArrayList();
for (int i = 0;i<30;i++){

    Console.WriteLine("Eleman giriniz");
    
    Console.WriteLine("Count : {0}-- Capacity : {1}",arrayList.Count,arrayList.Capacity);
}
*


// Array list iiçerisinden veri çekmek için dizilerdeki gibi arraylist içerisinden veri çekilebilir.
string deneme = arrayList[0].ToString();
*/
// Örnek : 

// Öğrenciden 10 adet not alıp bu notların toplamı ve ortalamsını ekrana yazdıralım

/*ArrayList notlar = new ArrayList();
for (int i = 0; i < 10; i++){

    Console.WriteLine("{0}. notu giriniz",i+1);
    notlar.Add(Console.ReadLine());
}
Console.WriteLine("Not girişi tamamlandı, entera basarak not bilgilerini alabilirsiniz");
Console.ReadLine();

int toplamNot = 0;
for (int i = 0;i<notlar.Count;i++){

  toplamNot+=int.Parse(notlar[i].ToString());

}
Console.WriteLine("Notlatın toplamı : {0} Ortalamsı : {1}",toplamNot,toplamNot/notlar.Count);
*/

// Sayısal loto oyununu arraylist ile yapınız

/*ArrayList kullanicidanGelen = new ArrayList();
ArrayList random=new ArrayList();

ArrayList bilinenSayilar = new ArrayList();

Random rnd = new Random();
for(int i=0;i<6;i++){

    Console.WriteLine("{0} sayıyı giriniz",i+1);
    kullanicidanGelen.Add(int.Parse(Console.ReadLine()));   
    random.Add(rnd.Next(1,49));
}

Console.WriteLine("Tahminlerin bitti, çekilişi görmek için enter");
Console.ReadLine();

// iki tane koleksiyonu kartezyen biçimde karşılaştıralım
for(int i=0;i<kullanicidanGelen.Count;i++){

    for(int j=0;j<random.Count;j++){
        // burada iki koleksiyonu birbiri ile karşılaştıralım
       if(Convert.ToInt32(kullanicidanGelen[i])==Convert.ToInt32(random[j])){

            // sayı bilinmiş demektir.
            bilinenSayilar.Add(kullanicidanGelen[i]); 

       }

    }
}
// Bilinen sayıları ekrana yazdıralım
Console.WriteLine("Bilinen Sayılar");
for(int i=0;i<bilinenSayilar.Count;i++){

    Console.Write("{0}-",bilinenSayilar[i]);
}
*/

// 1 ay sonraya not : 


// Koleksiyonların fonksiyonlarına göz atalım

ArrayList liste  = new ArrayList();

// Koleksiyonun içerisindeki verileri siler
//liste.Clear()

// Koleksiyon içerisindeki verileri sıralar
liste.Sort();

// Koleksiyon içerisindeki verileri tersten sıralar
liste.Reverse();

// Koleksiyonu diziye dönüştürür
object[] objectArray = liste.ToArray();

// koleksiyon içerisinde arama yapar, verdiğiniz değer koleksiyon içerisinde varsa, true yoksa false döndürür.
liste.Contains("10");

//Insert fonksiyonu, koleksiyon içerisine bir veriyi eklemek için kullanılır
// iki tane parametre alır.  ilk parametre hangi index'e eklemek istediğiniz. 
// ikinci paramtre ise verinin kendisidir.
liste.GetRange(1,10);
// GetRange fonksiyonu, koleksiyon içerisinden birden fazla veri getirmek için kullanılır
// verinin geleceği index ve bu indexden sonra kaç index veri getirilsin parametreleri ile çalışır
liste.Insert(4, "Insert et");

// Koleksiyonlarda count ve capacity birbirine eşitlemek için kullanılır.

// Örnek : Count : 5 Capacity : 8 ise, TrimToSize yapılınca, count ve capacity birbirine eşit oluyor.
liste.TrimToSize();

