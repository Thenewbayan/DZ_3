// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число и мы проверим является ли оно полиндромом");
// сделаем через строку, и потом как с массивом проверим значения
string pol=Console.ReadLine();// ввод числа в формате строки
int number;
int coeff=0;
bool PolNumber=int.TryParse(pol, out number);
if (PolNumber)
{
    Console.WriteLine("Все хорошо, вы использовали только числа при вводе");
    int lenghtPol=pol.Length;
    int index=0;
    while(index<(lenghtPol/2))
    {
       if(pol[index]==pol[(lenghtPol-1)-index])
       {
            index++;
            Console.WriteLine(index);
            coeff=0;
            Console.WriteLine(coeff);
            return;
       }
       if(pol[index]!=pol[(lenghtPol-1)-index])
       {
         coeff--;
         Console.WriteLine(index);
         index++;
         Console.WriteLine(coeff);
         return;
       }
    }
    if(coeff<0)
    {
        Console.WriteLine("Число не является полиндромом");
    }
    if (coeff==0)
    {
        Console.WriteLine("Число полиндром, то есть читается справа налево и слева направо одинаково");
    }//не выводит 34 или 38 строки, вводишь число и выводит только строку 14 и все
}
else
{
    Console.WriteLine("Вы сжульничали и ввели не только цифры");
}

