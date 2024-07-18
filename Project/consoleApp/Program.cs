// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World! Musa Çınar");



using System.Collections;
using System.ComponentModel;
using System.Text;

/*Console.Write("Sayı giriniz: ");
int sayi1 =Convert.ToInt32(Console.ReadLine());

Console.Write("Sayı giriniz: ");
int sayi2 =Convert.ToInt32(Console.ReadLine());

int toplam = sayi1+sayi2;
Console.WriteLine(toplam);*/


//ad soyad yas

/*Console.Write("Adı:");
var ad = Console.ReadLine();

Console.Write("Soyadı:");
var soyad = Console.ReadLine();

Console.Write("Yas:");
var yas = Console.ReadLine();

string  mesaj= $"{ad} {soyad} kişisi {yas} yaşındadır";

Console.WriteLine(mesaj);*/

/*var simdi = DateTime.Now;
Console.WriteLine(simdi);
Console.WriteLine(simdi.Year);*/




// string [] isimler = new string [5];

// isimler[0]= "ali";
// isimler[1]= "ayşe";
// isimler[2]= "ahmet";
// isimler[3]= "mehmet";
// isimler[4]= "nur";

//string [] isimler ={"ali","ahmet","yavuz", "mehemet","ayşe"};

//isimler[0]="abc";


// int[] numaralar = new int [5];

// numaralar[0]=100;
// numaralar[1]=200;
// numaralar[2]=300;
// numaralar[3]=400;
// numaralar[4]=500;


/*int [] numaralar ={100,200,300,400,500,600};

Console.WriteLine($"{numaralar[5]} numaralı öğrencinin adı {isimler[0]}" );



string [] sehirler = {"İstanbul","Ankara","Antalya","Mugla"};

foreach(var sehir  in sehirler [2..]){
    Console.WriteLine(sehir);
}*/



/*
string[] ogrenciler ={"ali","ayşe","mehmet"};
int[,] notlar = new int [3,3];


notlar[0,0]=50;
notlar[0,1]=60;
notlar[0,2]=70;

notlar[1,0]=50;
notlar[1,1]=40;
notlar[1,2]=90;

notlar[2,0]=70;
notlar[2,1]=80;
notlar[2,2]=50;



int toplam = notlar [0,0] + notlar [0,1] + notlar [0,2];
int ortalama = toplam / 3;
 Console.WriteLine($"{ogrenciler[0]}isimli ogrencinin not ortalaması {ortalama}");
*/



// int? a = null;
// int b = 20;

// var sonuc = (a ?? 0)+b ;
// Console.WriteLine(sonuc);




String username ="musacinar";
string password ="123456";
bool sonuc ;
sonuc = (username =="musacinar");
sonuc = (password=="123456");

Console.WriteLine(sonuc);