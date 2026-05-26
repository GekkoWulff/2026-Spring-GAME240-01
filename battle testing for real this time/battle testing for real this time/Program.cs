
int coordinateStateX = 0;
int coordinateStateY = 2;

//MOVEMENT FUNCTION GROUP
void MoveInDirection(string direction)
{
    if (direction == "north")
    {
        coordinateStateY = coordinateStateY + 1;
        Console.WriteLine("You venture North");
    }
    else if (direction == "west")
    {
        coordinateStateX = coordinateStateX + 1;
        Console.WriteLine("You venture West");
    }
    else if (direction == "east")
    {
        coordinateStateX = coordinateStateX - 1;
        Console.WriteLine("You venture East");
    }
    else if (direction == "south")
    {
        coordinateStateY = coordinateStateY - 1; 
        Console.WriteLine("You venture South");
    }
    else
    {
        Console.WriteLine("I'm afraid I do not know that route, Adventurer.");
    }
}

//ITEM TAKING FUNCTION GROUP
void TakeAnItem(string item)
{
    if (item == "sword")
    {
        Console.WriteLine("You have found an Old Sword! It should work fine for your purposes, Adventurer.");
    }
    else if (item == "greatsword")
    {
        Console.WriteLine("A Greatsword! A noble warrior once wielded such a blade to slay a fearsome dragon!");
    }
    else
    {
        Console.WriteLine("I am afraid you cannot take that, Adventurer");
    }
} 

int enemyHealth = 5;
int bossHealth = 15; 

//fighting terms and conditions bool collection 
bool rollInitative = true; //are we in active combat

bool bugbearAppears = true; //bugbear appearance trigger
bool orcAppears = true; //orc appearance trigger
bool goblinAppears = true; //goblin appearance trigger

bool isGoblinDead = false; //does not restart the fight if you venture into the area again
bool isOrcDead = false; //does not restart the fight if you venture into the area again
bool isBugbearDead = false; //does not restart the fight if you venture into the area again


bool doesHaveSword = false;
bool doesHaveGreatsword = false;
//WEAPON array
string[] weaponOptions = { "sword", "greatsword" };

//USING A WEAPON
void UseAnItem(string myWeapon)
{
    if (myWeapon == "sword")
    {
        if (doesHaveSword == true)
        {
            UseAnItem(weaponOptions[0]);
            Console.WriteLine("You use the Rusted Sword! It swings and wounds the enemy deeply.");
            enemyHealth--; 
        }
        else if (doesHaveSword == false)
        {
            Console.WriteLine("You do not have a sword to use, adventurer!");
        }
    }
    else if (myWeapon == "greatsword")
    {
        if (doesHaveGreatsword == true)
        {
            UseAnItem(weaponOptions[1]);
            Console.WriteLine("You use the Greatsword! It cleaves through the enemy with a mighty blow! WHOOSH!");
            bossHealth = bossHealth - 3; 
        }
        else if (doesHaveGreatsword == false)
        {
            Console.WriteLine("You do not yet have the Greatsword, adventurer.");
        }
    }
    else
    {
        Console.WriteLine("I am afraid you cannot use that here, Adventurer");
    }
}


string input; //stores whatever is from ReadLine
string command; //the action taken from ReadLine
string additionalInfo; //what it says on the tin; context for what the action will do

input = Console.ReadLine();
input = input.ToLower();
string[] splitInput = input.Split(" ");
command = splitInput[0];
additionalInfo = splitInput[1];


if ((coordinateStateX == 0) && (coordinateStateY == 2))
{
    if (bugbearAppears == true)
    {
        Console.WriteLine("The snarling grows louder as you encroach on the sound...");
        Console.WriteLine("...");
        Console.WriteLine("A gigantic bugbear charges from the treeline with a great shout!");
        while (rollInitative == true)
        {
            enemyHealth = 7;
            Console.WriteLine("What will you do, adventurer?");
            if (enemyHealth < 0)
            {
                Console.WriteLine("You are locked in combat!");
                if (command == "use")
                {
                    UseAnItem(additionalInfo);
                }
            }
            else if (enemyHealth == 0)
            {
                Console.WriteLine("The bugbear falls with a sickening yell!");
                Console.WriteLine("You have defeated the bugbear!");
                rollInitative = false;
                bugbearAppears = false;
                break;
            }
               
        }
    }
    else if (bugbearAppears = false)
    {
        Console.WriteLine("There are no more monsters to fight here, Adventurer.");
        Console.WriteLine();
        Console.WriteLine("More of the forest can be seen to the south.");
        Console.WriteLine("To the east is more of the forest.");
        Console.WriteLine("To the west lies a majestic mountain range.");
        Console.WriteLine("To the north lies a dense, dark forest.");
    }
}