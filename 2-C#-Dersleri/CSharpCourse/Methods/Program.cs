// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Add();
Add();
Add();
Add();
var result = Add2(50,20);
Console.WriteLine(result);
var result2 = Add3(4);
Console.WriteLine(result2);
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