﻿// See https://aka.ms/new-console-template for more information

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

//byte : bellekte 8 bit yer kaplar. 0 ile 255 arasında değer tutar. Değer tiplidir.
byte number4 = 255; //256 ya da -1 değeri veremezsiniz.
Console.WriteLine("Number4 is {0}", number4);

//bool(boolean): Mantıksal veri tipidir, true ya da false değeri olur. şart koşullarında (if) genellikle kullanılır.
bool condition = false; //ya da true değeri alır. değer tiplidir.

//char : tek tırnak ile atama yapılır .tek harf , tek karakter tutar. ascii characterleri tutmaya yarar.
char character = 'A';
Console.WriteLine("Character is : {0}", character);

//integer değerine de çevrilebilir yani ascii kodu karşılığına. değer tiplidir.
Console.WriteLine("Character is {0}",(int)character);


//double : ondalıklı sayıları tutar. 10 gibi tam sayı da verilebilir.64 bitlik veri tutar. virgülden sonra 15 16 tane karakter tutar(sayı olarak)
double number5 = 10.4;
Console.WriteLine("Number5 is {0}", number5);

//decimal : double gibi ondalıklı sayıları tutar. para gibi hassas değerleri tutmak için kullanılır. virgülden sonra 28 29 tane değer tutabilir(sayı olarak).
decimal number6 = 10.4m;  //10.4M olarak yazılabilir. 10 gibi tam sayı da verilebilir
Console.WriteLine("Number6 is {0}", number6);


//Enum : programlamada magicstring denilen değerler tutmak yerine örneğin string days="mondays" diye string değerini karşılaştırmak yerine meela if("Fridays") {}
//yerine if(Days.Fridday) {} olarak değiştirebiliriz.

Console.WriteLine(Days.Friday);

//enum değerleri 0 dan başlar ve friday de 4 e karşılık gelir ekrana 4 yazar
Console.WriteLine((int)Days.Friday);

//var keywordü değişken türü değildirama değişken tutmak için kullanılır.
var number7 = 10; //değer neyse değişkenin veri tipi varda o olur.burada integer dır.
number7 = 'A'; //CHAR olduğu için ascii codu 65 atar o yüzden hata vermez.
Console.WriteLine("Number7 is {0}", number7);

//Şart Blokları(if) : Bizim uygulamalarımızda belli bir şarta göre uygulamanın akışını değiştirmek için kullanılan bloklardır.

//Console.WriteLine("Hello, World!");
Console.ReadLine();

//enum değerlerine başlangıç değeri verebiliriz. 1.sine 10 değeri verildiğinde 2.sini kendisi otomatik olarak 11 diye sıralı atar.
//istersek kendimiz hepsine başlangıç değeri de atayabiliriz
enum Days
{
    Monday = 10, Tuesday = 20, Wednesday, Thirsday, Friday, Saturday, Sunday
}



