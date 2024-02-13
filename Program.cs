
#region Task 1

Console.WriteLine("TASK 1");
int num = 12;

if  (num % 2 == 0)
{
    Console.WriteLine("cutdur");
} else
{
    Console.WriteLine("tekdir");
}
Console.WriteLine("\n");

#endregion

#region Task 2

Console.WriteLine("TASK 2");
int a = 13;
if ( a % 21 == 0 )
{
    Console.WriteLine("bolunur");
}else
{
    Console.WriteLine("bolunmur");
}

Console.WriteLine("\n");

#endregion

#region Task 3

Console.WriteLine("TASK 3");
int n = 12;
int m = 26;


if ( n % 2 == 0 && m % 2 == 0)
{
    Console.WriteLine(n+m);
}
else
{
    Console.WriteLine("n ve ya m cut deyildir");
}

Console.WriteLine("\n");


#endregion

#region Task 4

Console.WriteLine("TASK 4");

int temp = 17;
if ( temp < 15)
{
    Console.WriteLine("Hava soyuqdur");
} else
{
    Console.WriteLine("Hava istidir");
}

Console.WriteLine("\n");


#endregion

#region Task 5

Console.WriteLine("TASK 5");

int x, y, z;
x = 12;
y = 47;
z = 126;
int sum = 0;

if ( x > 10 && x < 100)
{
    sum += x;
}

if ( y > 10 && y < 100) { sum += y; }

if ( z > 10 && z < 100) { sum += z; }


Console.WriteLine(sum);

Console.WriteLine("\n");


#endregion

#region Task 6

Console.WriteLine("TASK 6");

int monthNumber = 4;

if ( monthNumber == 1) { Console.WriteLine("January"); }
else if (monthNumber == 2) { Console.WriteLine("February"); }
else if (monthNumber == 3) { Console.WriteLine("March"); }
else if (monthNumber == 4) { Console.WriteLine("April"); }
else if (monthNumber == 5) { Console.WriteLine("May"); }
else if (monthNumber == 6) { Console.WriteLine("June"); }
else if (monthNumber == 7) { Console.WriteLine("July"); }
else if (monthNumber == 8) { Console.WriteLine("August"); }
else if (monthNumber == 9) { Console.WriteLine("September"); }
else if (monthNumber == 10) { Console.WriteLine("October"); }
else if (monthNumber == 11) { Console.WriteLine("November"); }
else if (monthNumber == 12) { Console.WriteLine("December"); }
else { Console.WriteLine("Wrong Input"); }


Console.WriteLine("\n");


#endregion

#region Task 7

Console.WriteLine("TASK 7");

int number = 231;

int ones = number % 10;
number /= 10;
int tens = number % 10;
number /= 10;
int hundreds = number % 10;

int result = ones * tens * hundreds;

Console.WriteLine(result);

Console.WriteLine("\n");


#endregion

#region Task 8

Console.WriteLine("TASK 8");

int productOne = 40;
int productTwo = 50;
int productThree = 20;

int checkOut;
int freeProduct;

if (productOne <= productTwo)
{
    if (productOne <= productThree)
    {
        freeProduct = productOne;
    }
    else
    {
        freeProduct = productThree;
    }
}
else
{
    if (productTwo <= productThree)
    {
        freeProduct = productTwo;
    }
    else
    {
        freeProduct = productThree;
    }
}

checkOut = productOne + productTwo + productThree - freeProduct;

Console.WriteLine(checkOut);


#endregion