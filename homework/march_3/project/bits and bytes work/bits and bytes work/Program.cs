/* 
int = 4 bytes long 
    4 * 8 = 32 bits long 
    2 ^ 32 = a real big number 
double = 8 bytes 
    8 * 8 = 64 bits 
    2 ^ 64 = even bigger number 
bool 

int myNumber;
//myNumber =
// -(2^32)-1 possible values
//0
//(2^32) possible values


//64 bit integer
long myLongNumber; 
//32 bit integer is normal int 
//SEE ABOVE
//16 bit integer
short myShortNumber; 
//8 bit integer
byte watchOutIByte; 
//half byte is a nybble 


// 32 bit floating point number (half of a double) 
// usually used for game graphics 
float myFloat; 
//64 bit floating point number 
double myDouble;
//bool is one byte 
bool myBool;

/*
 SI units
 Kilo = 1000 bytes
 Mega = 1000 kilobytes
 Giga = 1000 megabytes
 Tera = 1000 gigabytes 
 
 
 int[] myArray = new int[20]
 20 * 4 bytes = 80 bytes 
 
 double[] myArray = new int[20]
   20 * 8 bytes = 160 bytes
   
myString.Length to get length
char oneLetter 
- is string for a single character 
- use apostraphes (') 
*/
//strings are immutable
//arrays are mutable 


//swap a and b so that a = 99 and b = 10 
int a;
int b;
a = 10;
b = 99;

int c;
c = a; //c is now 10 <- temporary variable
a = b; //a is now 99 
b = c; //b is now 10 
Console.WriteLine("A is now " + a);
Console.WriteLine("B is now " + b);

//using a while loop, find the biggest and smallest numbers in an array 

int[] numbers = [123, 5, 0, -10, 7];
//sum all the numbers in the array 
int i = 0;

while (i < numbers.Length)
{
   //do something
   int currentNumber = numbers[i];
   Console.WriteLine(numbers[0]);
   Console.WriteLine(numbers[4]);
   Console.WriteLine(numbers[1]);
   Console.WriteLine(numbers[2]);
   Console.WriteLine(numbers[3]);
   i = i + 1;
}


int biggest;
int smallest;
int sum = numbers[0];
sum = sum + numbers[1] 
          sum = sum + numbers[2] + numbers[3] + numbers[4]; 
//sum is 125
Console.WriteLine("Sum equals " + sum); 

