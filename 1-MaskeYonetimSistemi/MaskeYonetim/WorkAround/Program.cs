// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello, World!");


Degiskenler();

Vatandas vatandas = new Vatandas();


//SelamVer();
//SelamVer();
//SelamVer();
SelamVer("Betül");
SelamVer("Halise");
SelamVer("Elif");
SelamVer("Zeynep");
SelamVer();



//int sonuc = Topla( );
int sonuc = Topla(6,58);

//Diziler/Arrays = tanımladığımız tipte veriler tutan yapılardır.
string ogrenci1 = "Betül";
string ogrenci2 = "Ebrar";
string ogrenci3 = "Kağan";

Console.WriteLine(ogrenci1);
Console.WriteLine(ogrenci2);
Console.WriteLine(ogrenci3);

string[] ogrenciler = new String[3];  //referans tipli ürünleri kullanabilmrn için nrelemen yani heap bölgesine kaydetmen lazım. stack kısmında da  ogrenciler değişkeni tutuluyor.
ogrenciler[0] = "Ebrar";
ogrenciler[1] = "Betül";
ogrenciler[2] = "Kağan";

ogrenciler = new String[4]; //new i gördüğü anda hrappta yeni bir alan tanımladı öncekiler gitti silindi yeni bir adreste tutuldu.
ogrenciler[3] = "Hüseyin";

//döngüler-for
for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

//Referans Tipler ----> Array,Class, Interface, Abstract

//Örnek : 
string[] sehirler1 = new[] {"İstanbul","Bolu","Kocaeli" };
string[] sehirler2 = new[] { "İzmir", "Ankara", "Bursa" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]); //Adana

Person person1 = new Person();
person1.FirstName = "Betül";
person1.LastName = "Bircan";
person1.DateOfBirthYear = 1996;
person1.NationalIdentityNumber = 123;
//burada tc kimlilk numarası gerçek olursa kabul ediyor

Person person2 = new Person();
person2.FirstName = "Gaye";

//dizi formatındaki yapıları döner.
foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

//2015-den beri diziler daha az kullanılmaktadır.onun yerine List<> kullanılır.
List<string> yenisSehirler1 = new List<string> {"Ankara 1","İstanbul 1","İzmir 1" };
yenisSehirler1.Add("Adana 1");
foreach (string sehir in yenisSehirler1)
{
    Console.WriteLine(sehir);
}

//Ornek 2 ----> Değer Tipler
int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1; //sayi2 = 10
sayi1 = 30;
Console.WriteLine(sayi2); //10

//maske verme işlemi-ptt
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);


Console.ReadLine();


//void methodlar sadece işi yapar geriye birşey döndürmez
//static void SelamVer()
//{
//    Console.WriteLine("Merhaba"); //parametresiz
//}

//parametreye default değer verebiliriz
static void SelamVer(string isim="İSİMSİZ")
{
    Console.WriteLine("Merhaba " + isim);
}


//burada hem toplar hem de int tipinde değer döndürür.
//static int Topla()
//{
//    return 5;
//}

static int Topla(int sayi1= 5,int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc );
    return sonuc;
}


static void Degiskenler()
{
string mesaj = "Merhaba";
double tutar = 100000;
int sayi = 100;
bool girisYapmisMi = false;

string ad = "Betül";
string soyad = "Bircan";
int dogumYili = 1996;
long tcNo = 12345678910;

Console.WriteLine(tutar * 1.18);

Console.WriteLine(tutar * 1.18);
}



public class Vatandas
{
    //property ler pascal case olarak tanımlanır.
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }

    //string ad = "Betül";
    //string soyad = "Bircan";
    //int dogumYili = 1996;
    //long tcNo = 12345678910;
}