//INTRO SEQUENCE 
Console.WriteLine("Hello Adventurer!");
Console.WriteLine(
    "You have found yourself in the extraordinary land of Zorp, a fantastical realm filled with monsters, mayhem, and a dragon most foul!");
Console.WriteLine("Mystery, battles and adventures await!");
Console.WriteLine(); 

int coordinateStateX = 0;
int coordinateStateY = 0;

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

bool orcDefeated = false;
bool goblinDefeated = false;
bool bugbearDefeated = false; 

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


//MAIN GAMEPLAY LOOP MAP 
bool adventureAwaits = true;
bool levelUp = false;
while (adventureAwaits == true)
{
    
   Console.WriteLine("What would you like to do, Aventurer?"); 
    string input; //stores whatever is from ReadLine
    string command; //the action taken from ReadLine
    string additionalInfo; //what it says on the tin; context for what the action will do

    input = Console.ReadLine();
    input = input.ToLower(); 
    string[] splitInput = input.Split(" ");
    command = splitInput[0];
    additionalInfo = splitInput[1]; 
    
    if (command == "move")
    {
        Console.WriteLine("Where do you want to go?");
        additionalInfo = Console.ReadLine();
        additionalInfo = additionalInfo.ToLower(); 
        //To do: handle movement in directions 
        if (additionalInfo == "north")
        {
            MoveInDirection(additionalInfo);
        }
        else if (additionalInfo == "west")
        {
            MoveInDirection(additionalInfo);
        }
        else if (additionalInfo == "east")
        {
            MoveInDirection(additionalInfo);
        }
        else if (additionalInfo == "south")
        {
            MoveInDirection(additionalInfo);
        }
        else
        {
            Console.WriteLine("I'm afraid I do not know that route, Adventurer."); 
        }
    }
    else if (command == "use") //using items in battle
    {
        UseAnItem(additionalInfo);
    }
    else if (command == "enter") //exit the tavern
    {
        if ((additionalInfo == "tavern") || (additionalInfo == ""))
        {
            coordinateStateX = 20;
            coordinateStateY = 10;
            Console.WriteLine("You enter the tavern. Despite the oil lamplight and lack of cobwebs, there is no visible life inside.");
            Console.WriteLine("Instead, you see a single sword lying on the ground. A decent metal, weighted evenly.");
            Console.WriteLine("Do you want to take the sword?");
            string tutorialAnswer = Console.ReadLine();
            if (tutorialAnswer == "yes")
            {
                Console.WriteLine("You take hold of the blade, hoisting it aloft.");
                TakeAnItem(additionalInfo); 
            }
            else if (tutorialAnswer == "no")
            {
                Console.WriteLine("...no?");
                Console.WriteLine("Adventurer, you need a sword to continue on");
            }
        }
    }
    else if (command == "exit") //exit the tavern
    {
        if ((additionalInfo == "tavern") || (additionalInfo == ""))
        {
            Console.WriteLine("You exit the tavern into the sulight.");
            coordinateStateX = 0;
            coordinateStateY = 0; 
        }
    }
    
    
    
    if ((coordinateStateX == 0) && (coordinateStateY == 0))
    {
        Console.WriteLine(
            "You stand outside a great tavern. There is no light nor sound emanating from it, yet you feel a sense that there is something to be found inside.");
        Console.WriteLine("To the south and east flows a great, roaring river.");
        Console.WriteLine("To the west grows a large, grassy plain.");
        Console.WriteLine("To the north lies a dense, dark forest.");
    }
    else if ((coordinateStateX == 1) && (coordinateStateY == 0))
    {
        Console.WriteLine("You approach the bank of the river. The running water is soothing to your ears.");
        Console.WriteLine("The river continues to the south.");
        Console.WriteLine("To the east is an impenetrable forest.");
        Console.WriteLine("To the west grows a large, grassy plain and the tavern.");
        Console.WriteLine("To the north lies a dense, dark forest with a strange laughing sound.");
    }
    else if ((coordinateStateX == -1) && (coordinateStateY == 0))
    {
        Console.WriteLine("You enter the plains. The yellow grass is dry and sways in the breeze.");
        Console.WriteLine("A beach can be seen to the south.");
        Console.WriteLine("To the east is the tavern.");
        Console.WriteLine("To the west lies more plains, and a ripple in the grass.");
        Console.WriteLine("To the north lies a dense, dark forest.");
    }
    else if ((coordinateStateX == -2) && (coordinateStateY == 0))
    {
        Console.WriteLine("You enter the plains. The rippling in the grass grows more intense.");

        //start the orc fight 
        //gain Greatbow after defeat 

        Console.WriteLine("A beach can be seen to the south.");
        Console.WriteLine("To the east is the plains.");
        Console.WriteLine("To the west lies a great cliff");
        Console.WriteLine("To the north lies a majestic mountain range.");
    }
    else if ((coordinateStateX == 0) && (coordinateStateY == 1))
    {
        Console.WriteLine("You enter the forest. The mottled sunlight casts odd shadows as you walk");
        Console.WriteLine("The tavern can be seen to the south.");
        Console.WriteLine("To the east is more forest, and eerie whisperings.");
        Console.WriteLine("To the west lies more forest.");
        Console.WriteLine("To the north lies a more forest and a low, snarling sound.");
    }
    else if ((coordinateStateX == 0) && (coordinateStateY == 2))
    {
        Console.WriteLine("The snarling grows louder as you encroach on the sound.");
        //start bugbear fight (5 hp) 
        Console.WriteLine("The forest can be seen to the south.");
        Console.WriteLine("To the east is more of the forest.");
        Console.WriteLine("To the west lies a majestic mountain range.");
        Console.WriteLine("To the north lies a dense, dark forest.");
    }
    else if ((coordinateStateX == 0) && (coordinateStateY == -1))
    {
        Console.WriteLine("You approach the bank of a rushing river, flowing towards the sea.");
        Console.WriteLine("An ocean can be seen to the south.");
        Console.WriteLine("To the east is a deep, dark forest.");
        Console.WriteLine("To the west lies a beach.");
        Console.WriteLine("To the north lies the tavern.");
    }
    else if ((coordinateStateX == -1) && (coordinateStateY == 1))
    {
        Console.WriteLine("You trek through the dark forest.");
        Console.WriteLine("The plains can be seen to the south.");
        Console.WriteLine("To the east is more forest.");
        Console.WriteLine("To the west and north lies a majestic mountain range.");
    }
    else if ((coordinateStateX == -1) && (coordinateStateY == 2))
    {
        Console.WriteLine("You climb up the mountain. The view is great from up here!");
        Console.WriteLine("The forest can be seen to the south.");
        Console.WriteLine("To the east is the forest, and a deep rumbling growl.");
        Console.WriteLine("To the west stands another mountain.");
        Console.WriteLine("To the north lie insurmountable mountain peaks.");
    }
    else if ((coordinateStateX == -1) && (coordinateStateY == -1))
    {
        Console.WriteLine("You step onto the beach. The air carries a distinct note of salt.");
        Console.WriteLine("An ocean can be seen to the south.");
        Console.WriteLine("To the east is a river feeding into the sea.");
        Console.WriteLine("To the west lies more sprawling beach.");
        Console.WriteLine("To the north lies the expansive plains");
    }
    else if ((coordinateStateX == -2) && (coordinateStateY == 1))
    {
        Console.WriteLine("You climb up the mountains. The view is great from up here!");
        Console.WriteLine("The plains can be seen to the south.");
        Console.WriteLine("To the east is a deep, dark forest.");
        Console.WriteLine("To the west lies a steep cliff.");
        Console.WriteLine("To the north lies a grand mountaintop.");
    }
    else if ((coordinateStateX == -2) && (coordinateStateY == 2))
    {
        if (levelUp == true)
        {
            //enter dragon fight 
        }

        if (levelUp == false)
        {
            Console.WriteLine("You summit the grand mountain peak. You get the feeling that something exciting might happen here...");
        }
        Console.WriteLine("Smaller mountains can be seen to the south and east.");
        Console.WriteLine("To the north and west lie insurmountable peaks.");
    }
    else if ((coordinateStateX == -2) && (coordinateStateY == -1))
    {
        Console.WriteLine("You step onto the beach. The wind carries a distinct note of salt.");
        Console.WriteLine("A deep ocean can be seen to the south and west.");
        Console.WriteLine("To the east sprawls more of the beach.");
        Console.WriteLine("To the north lies the expansive plains, and a ripple in the grass.");
    }
    else if ((coordinateStateX == 1) && (coordinateStateY == 1))
    {
        Console.WriteLine("The voices in the forest grow louder as you approach.");
        //enter goblin fight 
        Console.WriteLine("A rapid river lies to the south.");
        Console.WriteLine("To the east lies insurmountable mountains.");
        Console.WriteLine("More of the forest can be seen to the north and west.");
    }
    else if ((coordinateStateX == 1) && (coordinateStateY == 2))
    {
        Console.WriteLine("You walk further into the dark forest.");
        Console.WriteLine("Insurmountable mountains can be seen to the north and east.");
        Console.WriteLine("To the west grows more forest and a deep, growling sound.");
        Console.WriteLine("To the south lies more forest, and a whispering sound.");
    }
    else if ((coordinateStateX == 1) && (coordinateStateY == -1))
    {
        Console.WriteLine("You trek into the deep forest.");
        Console.WriteLine("A rushing river can be seen to the north and west.");
        Console.WriteLine("To the east sprawls an impenetrable forest.");
        Console.WriteLine("To the south lies a deep ocean.");
    }
    else if (((coordinateStateX == -2) && (coordinateStateY == -2)) ||
             ((coordinateStateX == -1) && (coordinateStateY == -2)) ||
             ((coordinateStateX == 0) && (coordinateStateY == -2)) ||
             ((coordinateStateX == -3) && (coordinateStateY == -1)))
    {
        Console.WriteLine("The ocean is dark and cold. You don't think you can swim this.");
    }
    else if (((coordinateStateX == -3) && (coordinateStateY == 1)) ||
             ((coordinateStateX == -3) && (coordinateStateY == 0)))
    {
        Console.WriteLine("Silvery mist swirls in the abyss. You don't think you can survive that fall.");
    }
    else if (((coordinateStateX == 1) && (coordinateStateY == 3)) ||
             ((coordinateStateX == -1) && (coordinateStateY == 3)) ||
             ((coordinateStateX == 0) && (coordinateStateY == 3)) ||
             ((coordinateStateX == -2) && (coordinateStateY == 3)) || ((coordinateStateX == 2) && (coordinateStateY == 2)) || ((coordinateStateX == 2) && (coordinateStateY == 1)))
    {
        Console.WriteLine("The mountain peaks are steep and austere. You don't think you can climb this.");
    }
    else if (((coordinateStateX == 2) && (coordinateStateY == 0)) ||
             ((coordinateStateX == 2) && (coordinateStateY == -1)) ||
             ((coordinateStateX == 1) && (coordinateStateY == -2)))
    {
        Console.WriteLine("Light cannot penetrate this part of the forest. You don't think you can continue through this.");
    }
  
    
    
    
//MONSTER NAME ARRAY AND PLACEHOLD VALUE 
    string[] monsterName = { "Orc", "Goblin", "Bugbear", "Dragon"};
    string monsterAppears;

    void rollInitiative(string monsterType)
    {
        if (monsterType == monsterName[0])
        {
            Console.WriteLine("You have encountered a fearsome " + monsterName[0] + "!");
            Console.WriteLine("What will you do, Adventurer?");
            string hitTheBastard;
            int enemyHealth = 5;
        }
        else if (monsterType == monsterName[1])
        {
            Console.WriteLine("You have encountered a fearsome " + monsterName[1] + "!");
            Console.WriteLine("What will you do, Adventurer?");
            string hitTheBastard;
            int enemyHealth = 3;
            if (command == "use")
            {
                UseAnItem(additionalInfo);
            }
        }
        else if (monsterType == monsterName[2])
        {
            Console.WriteLine("You have encountered a fearsome " + monsterName[2] + "!");
            Console.WriteLine("What will you do, Adventurer?");
            string hitTheBastard;
            int enemyHealth = 7;
            if (command == "use")
            {
                UseAnItem(additionalInfo);
            }
        }
    }
    
    
}


