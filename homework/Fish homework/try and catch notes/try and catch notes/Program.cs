try //try to access an array element (out of bounds)
{
    int[] myArray = new[] { 1, 2, 3, 4, 5 };
    int element;
    element = myArray[10] = 92; 
    element = element * 5 / 2;
    Console.WriteLine(element);
}
catch (IndexOutOfRangeException myException) //we get the name for this from the error message
{
    Console.WriteLine("You must type an index between 0 and 4.");
}

int x()
{
    try //trying to divide two numbers (by zero)
    {
        int a = 5;
        int b = 0;
        int divide = a / b;
        Console.WriteLine(divide);
        return divide;
        Console.WriteLine("hello");
    }
    catch (Exception myException)
    {
        Console.WriteLine("Something went wrong, please try again :)");
        throw myException; //this actively passes off the problem to somebody else (me in group projects be like) 
    }
    finally
    {
        Console.WriteLine("Aw hell, let's run it anyways");
       
    }

    Console.WriteLine("Hello!");
    return 0; 
}

x();

Console.WriteLine("Howdy!");

bool isFilePathValid = false;

while (isFilePathValid == false)
{
    Console.WriteLine("Yo, where my file at?");
    string filepath = Console.ReadLine();
    try
    {
        StreamReader reader = new StreamReader(filepath);
        isFilePathValid = true;

        string firstLine;
        firstLine = reader.ReadLine();
        Console.WriteLine(firstLine);

        reader.Close();
    }
    catch (Exception e)
    {
        Console.WriteLine("Something went wrong finding your file");
    }

}

Console.WriteLine("Adios!");


