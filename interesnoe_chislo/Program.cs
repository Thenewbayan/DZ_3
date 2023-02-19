// Число считаем интересным если произведение всех его цифр делится на их сумму без остатка (например 22=(2*2)%(2+2)=0)
//создать массив из 10 случайных интересных чисел в диапазоне от 10 до 1000(я так понял что исключая 1000)
//начнемссссс
Console.WriteLine("Число считаем интересным, если произведение его цифр кратно их сумме");
int [] InterestNumbers={};
int index=0;//массив интересных чисел
int count=0;
while(index<10)// пока не заполним массив
{
//int number=new Random().Next(10,1000);//генерим случайное число в диапазоне
int number =22;
//находим его цифры по отдельности
//Console.WriteLine(number);
int deegre=1;//стеень десятки для определения чисел
int digit=1;//разрядность числа
while(number/Math.Pow(10,deegre)!=0)
{
    digit=digit+1;
    deegre=deegre+1;
    Console.WriteLine(digit);
    Console.WriteLine(deegre);
}
if (digit==2)//для 2 разрядных чисел
{//числа а в с справо налево
    int numberA=Convert.ToInt32(number%10);
    int numberB=Convert.ToInt32((number/Math.Pow(10, 1))%10);//нашли цифры для разрядов
    if((numberA*numberB)%(numberA+numberB)==0)//если совпадает то записываем в массив
    {
        InterestNumbers[index]=number;
        Console.WriteLine(count);
        count++;
        index++;
        Console.WriteLine(number);
        
    }
    else //если нет то счетчик ++
    {
        count++;
    }
}
if (digit==3)//для трехразрядных чисел
{
   int numberA=Convert.ToInt32(number%10);
   int numberB=Convert.ToInt32((number/Math.Pow(10, 1))%10); 
   int numberC=Convert.ToInt32((number/Math.Pow(10, 2))%10);
   if ((numberA*numberB*numberC)%(numberA+numberB+numberC)==0)//то же самое, находим разряды, если да, то в массив
   {
    InterestNumbers[index]=number;
        //Console.WriteLine(count);
        count++;
        index++;
       // Console.WriteLine(number);
   }
   else
   {
        count++;
   }
}
}
Console.WriteLine(InterestNumbers);
double KPI=(index/count)*100;
Console.WriteLine(Math.Round(KPI, 3));