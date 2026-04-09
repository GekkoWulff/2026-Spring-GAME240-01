double divide(int dividend, int divisor)
{
    double x = (double)dividend / (double)divisor;
    return x; 
}

double result;
result = divide(5, 2);
Console.WriteLine(result);

/*
int timeOfDay = 5;

int getTimeOfDay()
{
    //actually do shit in here 
}


Console.WriteLine("The current time is " + getTimeOfDay());
*/ 

//'return' replaces values and doesn't write to the console
// void makes sure the function is not returned and does not turn into a value 
// 