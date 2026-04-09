
Console.WriteLine("How can I help you today?");
Console.ReadLine();
Console.WriteLine("Of course!");

//Parse converts text to int "10" -> 10


bool runCalculator = true;

while (runCalculator == true)
{
    Console.WriteLine("What equation do you want to solve? Type \"Done\" to end the progam.");
  
    
    string response;
    response = Console.ReadLine();
    
   
    if (response.ToLower() == "done")
    {
        Console.WriteLine("Thanks for playing!");
        break;
    }
    //this stuff^^ is all DONE 
    
    string[] numbersInResponse = response.Split(' ');
//split up the equation into parts; 

    int lengthCheck;
    lengthCheck = 3;
    
    //I want to ask "if this operand is present in the equation, then run this loop"

    if (lengthCheck > numbersInResponse.Length)
    {
        Console.WriteLine("This isn't an equation. Try using the calculator properly this time."); 
    }
    
    string operation;
    operation = numbersInResponse[1];
    
    
    if (operation == "+")
    {
        double result = double.Parse(numbersInResponse[0]) + double.Parse(numbersInResponse[2]);
        Console.WriteLine($"{numbersInResponse[0]} + {numbersInResponse[2]} equals {result}");
    }

    else if (operation == "-")
    {
       double result = double.Parse(numbersInResponse[0]) - double.Parse(numbersInResponse[2]); 
       Console.WriteLine($"{numbersInResponse[0]} - {numbersInResponse[2]} equals {result}");
    }

    else if (operation == "*")
    { 
        double result = double.Parse(numbersInResponse[0]) * double.Parse(numbersInResponse[2]); 
        Console.WriteLine($"{numbersInResponse[0]} * {numbersInResponse[2]} equals {result}");
    }

    else if (operation == "/")
    {
        double result = double.Parse(numbersInResponse[0]) / double.Parse(numbersInResponse[2]);
        Console.WriteLine($"{numbersInResponse[0]} / {numbersInResponse[2]} equals {result}");
    }

    else if (operation == "%")
    {
        double result = double.Parse(numbersInResponse[0]) % double.Parse(numbersInResponse[2]);
        Console.WriteLine($"{numbersInResponse[0]} % {numbersInResponse[2]} equals {result}");
    }
    else if (operation == "/" && double.Parse(numbersInResponse[2]) == 0)
    {
        Console.WriteLine("This isn't an equation. Try using the calculator properly this time.");
    }
    else
    {
        Console.WriteLine("I don't understand. Please try again later."); 
    }

}




/*splits numbers before and after into two different variables;
 then putting the operation sign in an array and messing around;

 -split on spaces
 array (index 0 is 1, index 1 is operand, index 2 is 2)
 second value is always operand (if arr.equals +/-)
 arr[0]

 string s = "name"
 if (s.Equals("name"))
 array[] = "1" "+" "2"
 num1 = Int.Parse(array[0])
*/



/*splits numbers before and after into two different variables;
 then putting the operation sign into an array and messing around;
 
 -split on spaces
 array (index 0 is 1, index 1 is operand, index 2 is 2)
 second value is always operand (if arr.equals +/-)
 arr[0]
 
 string s = "name"
 if (s.Equals("name")) 
 array[] = "1" "+" "2"
 num1 = Int.Parse(array[0])
*/


/*
foreach (string equationPart in spaces)
{
    if (equation.ToLower() == "done")
    {
        Console.WriteLine("Thanks for playing!");
        break; 
    }
   if (index == int.Parse(operations[0]))
   {
      Console.WriteLine(equationPart + equationPart);
   }
   if (index == int.Parse(operations[1]))
   {
       Console.WriteLine(int.Parse(equationPart) -  int.Parse(equationPart));
   }
}
*/

