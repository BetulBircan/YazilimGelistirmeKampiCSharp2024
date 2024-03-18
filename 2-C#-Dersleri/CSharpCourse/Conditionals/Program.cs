// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//var number = 10;
//var number = 11;
var number = 201;
//mantıksal operatörler, ==
//if (number == 10)
//{
//    Console.WriteLine("Number is 10");
//}
//else if (number == 20)
//{
//    Console.WriteLine("Number is 20");
//}
//else
//{
//    Console.WriteLine("Number is not 10");
//}

//Single Line If : İF ELSE bloklaro yerine tek satırda if else yapabiliriz ternary operatörü ile
//şartdoğruysa            //şart yanlışsa
//Console.WriteLine(number == 10 ? "Sayı 10 a eşittir" : "Sayı 10 a eşit değildir.");

//ctrl +k+d : formatlama

//Switch-case bloğu : if else if yerine avantaj olarak kullanılır.
//switch (number)
//{
//    case 10:
//        Console.WriteLine("Sayı 10");
//        break;
//    case 20:
//        Console.WriteLine("Sayı 20");
//        break;
//    default:
//        Console.WriteLine("Sayı 10 veya 20 değildir.");
//        break;
//}

if(number >= 0 && number <= 100)
{
    Console.WriteLine("Number is between 0-100");
}
else if(number >= 101 && number <= 200)
{
    Console.WriteLine("Number is between 101-200");
}
else if(number > 200 || number < 0) 
{
    Console.WriteLine("Number is less than 0 or greater than 200");
}


Console.ReadLine();
