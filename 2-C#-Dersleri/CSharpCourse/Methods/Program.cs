// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Add();
//Add();
//Add();
//Add();
//var result = Add2(50,20);
//Console.WriteLine(result);
var result2 = Add3(4);
Console.WriteLine(result2);

//number1 in değeri burada 20 ama ref olarak tanımlı
int number1 = 20;
int number2 = 100;
                     //değeri 30 oldu çünkü methodda 30 olarak tanımlandı onun referansıbı aldı
var result3 = Add4(ref number1, number2);
Console.WriteLine(result3);
Console.WriteLine(number1); //buraya da 30 yazar
Console.ReadLine();
//void de sadece işlem yap dediğimizde yapar.değer döndürmez
static void Add()
{
    Console.WriteLine("Added!!!!");
}

//parametreli methodla çalışmak
static int Add2(int number1, int number2)
{
    int sonuc = number1 + number2;
    return sonuc;
}

//default parametreli method . method parametresine varsayılan değer atabiliriz eğer method çağırılırken parametre verilmezse varsayılan değeri atar.
//varsayılan değer hep methpdun spn parametresine verilir.ilk e verilmez hata verir. ama iki parametre alıyorsa mesela iki parametreye de default değer verilebilir.

static int Add3(int x,int number1 = 30, int number2 = 30)
{
    int result = number1 + number2;
    return result;
}

//ref : değer tipli bir değişkeni referans tipli bir değişken olarak çevirir.
static int Add4(ref int number1, int number2)
{
    //number1 in değeri brada 30. ref keyword ile tanımlandı
    number1 = 30;
    return number1 + number2;
}