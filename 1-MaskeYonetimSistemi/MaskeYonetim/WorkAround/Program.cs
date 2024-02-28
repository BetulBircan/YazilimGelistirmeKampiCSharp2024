// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Degiskenler();

Vatandas vatandas = new Vatandas();

Console.ReadLine();

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