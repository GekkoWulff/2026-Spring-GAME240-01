int absolute1(int number)
{
    if (number > 0)
    {
        
    }
    else
    {
        number = number * -1;
    }

    return number;

    //implementation (write it out)


    //calculate some number; return keyword to return answer
    //return _____; 
}

int absolute2(int number)
{
    Math.Abs(number);

    return number;
}


int absWrappedFunction(int number)
{ 
    return absolute2(number);
 
}

var number = 5;
var number2 = number;
var x = absolute1;

bool isEven(int number)
{
    return number % 2 == 0; 
}

bool isOdd(int number)
{
    return number % 2 != 0; 
}

bool isPositive(int number)
{
    return number > 0; 
}

bool isNegative(int number)
{
    return number < 0; 
}

//putting functions to arrays; simplified code looks  
int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int i = 0;
while (i < numbers.Length)
{
    bool trait = numbers[i] % 2 == 0;
    Console.WriteLine(numbers[i] % 2 == 0);
    // equivalent to Console.WriteLine(numbers[i] + " is " + isEven);
    i++;
}



