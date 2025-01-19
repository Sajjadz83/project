//تعیین مثلث قایم الزاویه بودن با توجه به ورودی های کاربر

ّConsole.Write("Enter a number:");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter a number:");
int b = int.Parse(Console.ReadLine());
Console.Write("Enter a number:");
int c = int.Parse(Console.ReadLine());
if (a == b * b + c * c)
{
    if (b == c * c + a * a)
    {
        if (c == a * a + b * b)
        {
            Console.WriteLine("this is a triangle");
        }
        else
        {



            Console.WriteLine("this is not triangle");


        }

    }
    else
    {

        Console.WriteLine("this is not triangle");

    }
}
else
{
    Console.WriteLine("this is not triangle");
}



//الگوریتمی بنویسید که دو عدد را به عنوان ورودی دریافت کرده و بزرگترین و کوچکترین عدد را مشخص کنئ
while (true)
{
    Console.Clear();
    Console.Write("Enter first number:");
    int number1 = int.Parse(Console.ReadLine());
    Console.Write("Enter second numbere:");
    int number2 = int.Parse(Console.ReadLine());
    if (number1 == number2)
    {
        Console.WriteLine("number1==number2");
        Console.ReadKey();
        continue;
    }
    if (number1 > number2)
    {
        Console.WriteLine($"{number1} > {number2}");
        Console.ReadKey();
        return;
    }
    else
    {
        Console.WriteLine($"{number2} > {number1}");
        Console.ReadKey();
        return;
    }
}


//الگوریتک قبلی را طوری بنویسید که بین سه عدد باشد و فقط بزرگترین را چاپ کند
while (true)
{
    Console.Clear();
    Console.WriteLine("Enter a number");
    int number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter a number:");
    int number2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter a number:");
    int number3 = int.Parse(Console.ReadLine());
    if (number1 > number2 && number1 > number3)
    {
        Console.WriteLine(number1); Console.ReadKey(); return;
    }
    if (number2 > number1 && number2 > number3)
    {
        Console.WriteLine(number2); Console.ReadKey(); return;
    }
    if (number3 > number1 && number3 > number2)
    {
        Console.WriteLine(number3); Console.ReadKey(); return;
    }
}


//الگوریتمی بنویسید که عددی از کاربر دریافت کند و زوج یا فرد بودن آن را مشخص کند

Console.Write("Enter a number:");
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine("number is even");
}
else
{
    Console.WriteLine("number id ood");
}


//الگوریتم بنئویسید که عددی بگیرد و تعیین کند عدد اول است یا نه 
Console.Write("Enter a number:");
int N=int.Parse(Console.ReadLine());
for (int i = 2; i < N; i++)
{
    int R = N - 1 * N / i;
    if (R == 0)
    {
        Console.WriteLine("this number is not prime ");
    }
    if (i < N)
    {
        Console.WriteLine("thid number is prime");
    }
}