// See https://aka.ms/new-console-template for more information
using System.Data.SqlTypes;

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