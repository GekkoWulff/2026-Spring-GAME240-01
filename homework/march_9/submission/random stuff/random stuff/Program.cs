string[] animals = {"bonnethead shark", "sea turtle", "cat", "owl", "cobra", "horse", "cassowary"};
string favoriteAnimal = "cassowary"; 

//set index to 0 to write out the entire array 

bool haveWeFoundMyFavorite;
haveWeFoundMyFavorite = false; 

foreach (string animal in animals) //variable, variable name in collection/array 
{
    Console.WriteLine(animal);
    if (animal == favoriteAnimal)
    {
        haveWeFoundMyFavorite = true;
        break; 
    }
    else
    {
        haveWeFoundMyFavorite = false;
    }
}


if (haveWeFoundMyFavorite == true)
{
    Console.WriteLine("Yippee! You found it!");
}
else if (haveWeFoundMyFavorite == false)
{
    Console.WriteLine("Aw, rats! Better try again!");
}





/*
int a = 412;
int b = 100; 

int result = a/b;
int remainder = a % b; 

Console.WriteLine(a + "/" + b + " equals " + result + " remainder " + remainder);

*/

/* 
int i = 0;
while (i <= 100)
{
    int b = 2;
    int result = i / b;
    int remainder = i % b;
    Console.WriteLine(result + ", remainder " + remainder);
    i++;
}

*/

/* 
int i = 0;
while (i <= 100)
{
    Console.WriteLine("is " + i + " odd?     ");
    Console.WriteLine((i % 2) == 1);
    i++;
}
    */