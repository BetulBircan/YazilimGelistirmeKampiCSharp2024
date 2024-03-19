// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Add();
Add();
Add();
Add();
var result = Add2(50,20);
Console.WriteLine(result);
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

