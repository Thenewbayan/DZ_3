// Представим банк, в котором алгоритм начисления процента по вкладу зависит от суммы вклада. 
// На вход будет подаваться число (сумма вклада). 
// При значении меньше 100, будет начислено 5 %, 
// если значение находится в диапазоне от ста до двухсот — 7 %, 
// если больше — 10 %. Отработав, программа должна вывести общую сумму с начисленными процентами.
Console.WriteLine("Создадим программу для начисления дохода (в % годовых) по вкладу");
Console.WriteLine("ВВедите сумму которую вы хотите вложить в наш банк");
double deposit=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите на сколько лет вы хотите сделать вклад (минимальный срок 1 год");
int ControlYear=Convert.ToInt32(Console.ReadLine());
int year=1;
while ((deposit<100)&&(year<=ControlYear))
{
    
    deposit=(deposit*1.05);// ставка по процентам в 21 и 27 строке аналогично
    year++;
}
while ((deposit>=100)&&(deposit<=200)&&(year<=ControlYear))
{
    
    deposit=(deposit*1.07);
    year++;
}
while ((deposit>200)&&(year<=ControlYear))
{
    
    deposit=(deposit*1.10);
    year++;
}
Console.WriteLine($"Таким образом, с вашей стартовой суммы за {ControlYear} лет получилось {Math.Round(deposit, 2)} денег");