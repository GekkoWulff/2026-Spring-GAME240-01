//finite state machines 
//Thread.Sleep() adds pauses in milliseconds to text appearance on console 
/*
string color;
color = "red"; 

while(true)
{
    if (color == "red")
    {
        Console.WriteLine("The color is " + color + "!");
        Thread.Sleep(3000);
        color = "green"; 
    }
    else if (color == "green")
    {
        Console.WriteLine("The color is " + color + "!");
        Thread.Sleep(3000);
        Console.WriteLine("Is there a car waiting?");
        string answer = Console.ReadLine();
        if (answer == "yes")
        {
            color = "yellow"; 
        }
        else if (answer == "no")
        {
            //do nothing 
        }
    }
    else if (color == "yellow")
    {
        Console.WriteLine("The color is " + color + "!");
        Thread.Sleep(1500);
        color = "red"; 
    }
}
*/

string state;
state = "basic mario";
/*//all possible states:
basic
fire flower
mirror cherry
cat bell 
tanooki*/



//possible to get 

while (true) //if we just got a power-up, what happens? 
{
    Console.WriteLine("What item did Mario get?");
    string powerUp = Console.ReadLine();
    
    if (state == "basic mario")
    {
        if (powerUp == "flower")
        {
            state = "fire mario";
            Console.WriteLine("If-a you don't like-a the heat, then stay out of-a the kitchen!");
        }
        else if (powerUp == "cherry")
        {
            state = "mirror mario";
            Console.WriteLine("It's-a just like-a my brother Luigi!");
        }
        else if (powerUp == "bell")
        {
            state = "cat mario";
            Console.WriteLine("Do you think-a I can still eat spaghetti?");
        }
        else if (powerUp == "leaf")
        {
            state = "tanooki mario";
            Console.WriteLine("It's-a been a while since I've-a worn this thing!");
        }
        else if (powerUp == "shell")
        {
            state = "dead mario";
            Console.WriteLine("WAAAAAAUUUUUUUUGGGGGHHHHHH!!!!!");
            Console.WriteLine("GAME OVER");
            break; 
        }
    }
    else if (state == "fire mario")
    {
        if (powerUp == "flower")
        {
            state = "fire mario";
            Console.WriteLine("If-a you don't like-a the heat, then stay out of-a the kitchen!");
        }
        else if (powerUp == "cherry")
        {
            state = "mirror mario";
            Console.WriteLine("It's-a just like-a my brother Luigi!");
        }
        else if (powerUp == "bell")
        {
            state = "cat mario";
            Console.WriteLine("Do you think-a I can still eat spaghetti?");
        }
        else if (powerUp == "leaf")
        {
            state = "tanooki mario";
            Console.WriteLine("It's-a been a while since I've-a worn this thing!");
        }
        else if (powerUp == "shell")
        {
            state = "basic mario";
            Console.WriteLine("Mama mia!");
        }
    }
    else if (state == "mirror mario")
    {
        if (powerUp == "flower")
        {
            state = "fire mario";
            Console.WriteLine("If-a you don't like-a the heat, then stay out of-a the kitchen!");
        }
        else if (powerUp == "cherry")
        {
            state = "mirror mario";
            Console.WriteLine("It's-a just like-a my brother Luigi!");
        }
        else if (powerUp == "bell")
        {
            state = "cat mario";
            Console.WriteLine("Do you think-a I can still eat spaghetti?");
        }
        else if (powerUp == "leaf")
        {
            state = "tanooki mario";
            Console.WriteLine("It's-a been a while since I've-a worn this thing!");
        }
        else if (powerUp == "shell")
        {
            state = "basic mario";
            Console.WriteLine("Mama mia!");
        }
    }
    else if (state == "cat mario")
    {
        if (powerUp == "flower")
        {
            state = "fire mario";
            Console.WriteLine("If-a you don't like-a the heat, then stay out of-a the kitchen!");
        }
        else if (powerUp == "cherry")
        {
            state = "mirror mario";
            Console.WriteLine("It's-a just like-a my brother Luigi!");
        }
        else if (powerUp == "bell")
        {
            state = "cat mario";
            Console.WriteLine("Do you think-a I can still eat spaghetti?");
        }
        else if (powerUp == "leaf")
        {
            state = "tanooki mario";
            Console.WriteLine("It's-a been a while since I've-a worn this thing!");
        }
        else if (powerUp == "shell")
        {
            state = "basic mario";
            Console.WriteLine("Mama mia!");
        }
    }
    else if (state == "tanooki mario")
    {
        if (powerUp == "flower")
        {
            state = "fire mario";
            Console.WriteLine("If-a you don't like-a the heat, then stay out of-a the kitchen!");
        }
        else if (powerUp == "cherry")
        {
            state = "mirror mario";
            Console.WriteLine("It's-a just like-a my brother Luigi!");
        }
        else if (powerUp == "bell")
        {
            state = "cat mario";
            Console.WriteLine("Do you think-a I can still eat spaghetti?");
        }
        else if (powerUp == "leaf")
        {
            state = "tanooki mario";
            Console.WriteLine("It's-a been a while since I've-a worn this thing!");
        }
        else if (powerUp == "shell")
        {
            state = "basic mario";
            Console.WriteLine("Mama mia!");
        }
    }
}


switch (state)
{
    case "basic mario":
        Console.WriteLine("You're mini mario!"); 
        break;
    case "fire mario":
        break;
    case "mirror mario":
        break;
    case "cat mario":
        break;
    case "tanooki mario":
        break;
    
}
