// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//var number = 10;
var number = 11;
//mantıksal operatörler, ==
if (number == 10)
{
    Console.WriteLine("Number is 10");
}
else if(number == 20) 
{
    Console.WriteLine("Number is 20");
}
else
{
    Console.WriteLine("Number is not 10");
}

//Single Line If : İF ELSE bloklaro yerine tek satırda if else yapabiliriz ternary operatörü ile
                                //şartdoğruysa            //şart yanlışsa
Console.WriteLine(number == 10 ? "Sayı 10 a eşittir" : "Sayı 10 a eşit değildir.");

Console.ReadLine();
