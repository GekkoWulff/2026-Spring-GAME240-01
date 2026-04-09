Console.WriteLine("How can I help you today?");
Console.ReadLine();
Console.WriteLine("Of course!");

string numberOne, numberTwo; 
double a, b;
string operation;

string equation;

//Parse converts text to int "10" -> 10

while (true)
{
    Console.WriteLine("Please enter an equation into the calculator. If you want the program to end, type ''Finished''.");
    equation = Console.ReadLine();
    string[] numbers = equation.Split('+', '-', '*', '/', '%');
   
    
    
    int index;
    for (index = 0; index < numbers.Length; index++)
    {
        Console.WriteLine(equation[index]);
    }

    /* numberOne = Console.ReadLine();
    a = double.Parse(numberOne);
    Console.WriteLine("Alright. Now, what is your second number?");
    numberTwo = Console.ReadLine();
    b = double.Parse(numberTwo);
    Console.WriteLine("What operation do you want to use?");
    operation = Console.ReadLine();
    */

    double result;
    result = 0;
}

/*  if (operation == "finished")
  {
      Console.WriteLine("Thanks for playing!");
      break;
  }
  else if (operation == "+")
  {
      result = a + b;
  }
  else if (operation == "-")
  {
      result = a - b;
  }
  else if (operation == "*")
  {
      result = a * b;
  }
  else if (operation == "/")
  {
      result = a / b;
  }
  else if (operation == "%")
  {
      result = a % b;
  }

  Console.WriteLine(result);

  Console.WriteLine("Thanks for playing!");
}
*/