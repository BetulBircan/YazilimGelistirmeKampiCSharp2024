// See https://aka.ms/new-console-template for more information

//Value Types-
//Integer(int) : Tam Sayıdaki değerleri Tutar.Değer tiplidir.Integerin alabileceği değer -2 milyar 147 milyon 483 bin 648 il3 2 milyar 147 milyon 483 bin 647 değerleri arasındadır.

//veri tipi     //değişken adı   //değer
int             number1 = 2147483647;
Console.WriteLine("Number1 is {0}",number1);

//int number2 = -2147483648; //hata vermez  | bu iki aınır arasında değer alır.
//int number3 = 2147483647; // hata vermez  | 32 bitlik yer kaplar

//Long 19 karakterli sayıları alabilir
long number2 = -9223372036854775808; //sınır buradan başlar  9223372036854775807 değerleri arasında değer alabilir. 64 bitlik yer kaplar.
Console.WriteLine("Number2 is {0}",number2);

//short veri tipi 16 bitlik yer kaplar.
short number3 = -32768;  //sınır buradan başlar 32767 arasında değer alabilir.
Console.WriteLine("Number3 is {0}",number3);

//Console.WriteLine("Hello, World!");
Console.ReadLine();