//create the text adventure game! 
//do NOT have multiple bool/true variables about player movement, make ONE variable that changes 
//REFER BACK TO THE SWITCH CASE MARIO ASSIGNMENT FOR CHARACTER CREATION STUFF 

//string playerState;
//playerState = "movement"; 

enum Color
{
    green, 
    red,
    yellow,
}

Color state = Color.green;

while (true)
{
    switch (state)
    {
        case Color.green:
            Console.Write("The color is ");
                Console.WriteLine("Green");
            Thread.Sleep(1000);
            state = Color.yellow;
            break; 
        case Color.yellow:
            Console.Write("The color is ");
            Console.WriteLine("Yellow");
            Thread.Sleep(1000);
            state = Color.red;
            break; 

        case Color.red:
            Console.Write("The color is ");
            Console.WriteLine("Red");
            Thread.Sleep(1000);
            state = Color.green;
            break; 
    }
}
