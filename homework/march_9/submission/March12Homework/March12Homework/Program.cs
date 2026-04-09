/*
int[] numbers = [123, 89, 0, -10, 7];
int i = 0;

while (i < numbers.Length)
{
    int currentNumber = numbers[i];
    Console.WriteLine(numbers[0]);
    Console.WriteLine(numbers[4]);
    Console.WriteLine(numbers[1]);
    Console.WriteLine(numbers[2]);
    Console.WriteLine(numbers[3]);
    i = i + 1;
}
*/


//for each number, compare them one at a time
//current number to the biggest number so far 
//stop when we've compared all the numbers 
//when we looked at each number we stop 

int[] numberLine = {12, 8, 4, -9, 37, 780, 99};

int biggestSoFar;

//compare element 0 to element 1
if (numberLine[0] > numberLine[1])
{ 
    biggestSoFar = numberLine[0];
}
else 
{
    biggestSoFar = numberLine[1];
}
int index = 0;
while (index < numberLine.Length)
{
    Console.WriteLine("The biggest number is " + biggestSoFar);
   if (numberLine[index] > biggestSoFar)
    {
        biggestSoFar = numberLine[index];
        
    }  index++;
}

Console.WriteLine("Great! Now let's check the smallest ones!");

int[] numberList = {23, 9, 76, -400, 88, 24, 56, 99999, 874};

int smallestSoFar;

if (numberList[0] < numberList[1])
{
    smallestSoFar = numberList[0];
}
else 
{
    smallestSoFar = numberList[1];
}

index = 0;
while (index < numberList.Length)
{
    Console.WriteLine("The smallest number is " + smallestSoFar);
    if (numberList[index] < smallestSoFar)
    {
        smallestSoFar = numberList[index];
        
    }  index++;
}


//scope = property of variables and where you can use the variable 
/*
ex: int i = 4
cannot use int i before Line 18/wherever it falls before declaring the variable 

 if (i == 5) 
 {
 int insideIf;
 insideIf = 10000; 
 Console.WriteLine(insideIf); 
 }
 
 insideIf is scoped to the inside of the if statement 
 
 
 */