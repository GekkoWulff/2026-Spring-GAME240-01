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
        coordinateStateX = coordinateStateX - 1;
        Console.WriteLine("You venture West");
    }
    else if (direction == "east")
    {
        coordinateStateX = coordinateStateX + 1;
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

//WEAPON CONDITIONS
bool doesHaveSword = true;
bool doesHaveGreatsword = false;

string enemyType;
int goblinHealth = 3;
int bugbearHealth = 7;
int orcHealth = 5;
int bossHealth = 15;

//USING A WEAPON
void UseAnItem(string myWeapon)
{
    if (myWeapon == "sword")
    {
        if (doesHaveSword == true)
        {
            Console.WriteLine("You use the Old Sword! It swings and wounds the enemy deeply.");
            if (enemyType == "orc")
            {
                orcHealth = orcHealth - 1;
            } 
            else if (enemyType == "goblin")
            {
                goblinHealth = goblinHealth - 1;
            }
            else if (enemyType == "bugbear")
            {
                bugbearHealth = bugbearHealth - 1;
            } 
            else if (enemyType == "boss")
            {
                bossHealth = bossHealth - 1;
            } 
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
            Console.WriteLine("You use the Greatsword! It cleaves through the enemy with a mighty blow! WHOOSH!");
            if (enemyType == "boss")
            {
                bossHealth = bossHealth - 3; 
            }
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

//fighting terms and conditions bool collection 
bool rollInitative = false; //are we in active combat

bool bugbearAppears = true; //bugbear appearance trigger
bool orcAppears = true; //orc appearance trigger
bool goblinAppears = true; //goblin appearance trigger
bool bossDefeated = false; //do you win the game?

//EVERYTHING FROM THIS POINT ON IS THE BODY OF THE GAME CODE

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
    
    if ((command == "use") && (rollInitative == false))
    {
        Console.WriteLine("You are not in active combat, Adventurer!");
        //may need to write something so enemy health doesn't freak out
    }
    if ((command == "move") && (coordinateStateX > 3) || (coordinateStateY > 3) || (coordinateStateX < -3) || (coordinateStateY < -3))
    {
        Console.WriteLine("You have stepped outside the bounds of the map.");
        Console.WriteLine("I fear you have seen too much of what I can do, Adventurer. My power is limitless.");
        break;
    }
    //game breaks if you try to step outside the map 

    if ((coordinateStateX == 0) && (coordinateStateY == 0))
    {
        Console.WriteLine(
            "You stand outside a great tavern. There is no light nor sound emanating from it, you feel that there is nothing to be found inside.");
        Console.WriteLine("To the south and east flows a great, roaring river.");
        Console.WriteLine("To the west grows a large, grassy plain.");
        Console.WriteLine("To the north lies a dense, dark forest.");
    }
    else if ((coordinateStateX == 1) && (coordinateStateY == 0))
    {
        Console.WriteLine("You approach the bank of the river. The running water is soothing to your ears.");
        Console.WriteLine("The forest continues to the south.");
        Console.WriteLine("To the east is an impenetrable thicket.");
        Console.WriteLine("To the west is the tavern.");
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
    else if ((coordinateStateX == 0) && (coordinateStateY == 1))
    {
        Console.WriteLine("You enter the forest. The mottled sunlight casts odd shadows as you walk");
        Console.WriteLine("The tavern can be seen to the south.");
        Console.WriteLine("To the east is more forest, and eerie whisperings.");
        Console.WriteLine("To the west lies more forest.");
        Console.WriteLine("To the north lies more forest and a low, snarling sound.");
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
        Console.WriteLine("To the west stands a grand mountaintop.");
        Console.WriteLine("To the north lie insurmountable  peaks.");
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
        Console.WriteLine("The plains can be seen to the south, and a ripple in the grass.");
        Console.WriteLine("To the east is a deep, dark forest.");
        Console.WriteLine("To the west lies a steep cliff.");
        Console.WriteLine("To the north lies a grand mountaintop.");
    }
    else if ((coordinateStateX == -2) && (coordinateStateY == -1))
    {
        Console.WriteLine("You step onto the beach. The wind carries a distinct note of salt.");
        Console.WriteLine("A deep ocean can be seen to the south and west.");
        Console.WriteLine("To the east sprawls more of the beach.");
        Console.WriteLine("To the north lies the expansive plains, and a ripple in the grass.");
    }
    else if ((coordinateStateX == 1) && (coordinateStateY == 2))
    {
        Console.WriteLine("You walk further into the dark forest.");
        Console.WriteLine("Insurmountable mountains can be seen to the north and east.");
        Console.WriteLine("To the west grows more forest and a deep, growling sound.");
        Console.WriteLine("To the south lies more forest, and a whispering sound.");
    } //may add an extra item to here
    else if ((coordinateStateX == 1) && (coordinateStateY == -1)) //may add extra item here 
    {
        Console.WriteLine("You trek into the deep forest.");
        Console.WriteLine("A rushing river can be seen to the north and west.");
        Console.WriteLine("To the east and south sprawls an impenetrable forest.");
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
             ((coordinateStateX == -2) && (coordinateStateY == 3)) ||
             ((coordinateStateX == 2) && (coordinateStateY == 2)) ||
             ((coordinateStateX == 2) && (coordinateStateY == 1)))
    {
        Console.WriteLine("The mountain peaks are steep and austere. You don't think you can climb this.");
    }
    else if (((coordinateStateX == 2) && (coordinateStateY == 0)) ||
             ((coordinateStateX == 2) && (coordinateStateY == -1)) ||
             ((coordinateStateX == 1) && (coordinateStateY == -2)))
    {
        Console.WriteLine(
            "Light cannot penetrate this part of the forest. You don't think you can continue through this.");
    }
    else if ((coordinateStateX == -2) && (coordinateStateY == 0))
    {
        if (orcAppears == true)
        {
            enemyType = "orc";
            Console.WriteLine("The rippling grass stills, waiting as you tread closer...");
            Console.WriteLine("...");
            Console.WriteLine("A massive orc leaps from the tall grass with a shout!");
            rollInitative = true;
            while (rollInitative == true)
            {
                Console.WriteLine("What will you do, adventurer?!");

                string fightInput; //stores whatever is from ReadLine
                string fightCommand; //the action taken from ReadLine
                string additionalFightInfo; //what it says on the tin; context for what the action will do

                fightInput = Console.ReadLine();
                fightInput = fightInput.ToLower();
                string[] splitFightInput = fightInput.Split(" ");
                fightCommand = splitFightInput[0];
                additionalFightInfo = splitFightInput[1];

                if ((fightCommand == "use") && rollInitative == true)
                {
                    UseAnItem(additionalFightInfo);
                    if (orcHealth > 0)
                    {
                        Console.WriteLine("You are locked in combat!");
                        Console.WriteLine("The enemy's remaining health is " + orcHealth + "!");
                    }
                    else if (orcHealth == 0)
                    {
                        Console.WriteLine("The orc falls with a sickening yell!");
                        Console.WriteLine("You have defeated the orc!");
                        orcAppears = false;
                        rollInitative = false;
                        break;
                    }
                }
            }
        }
        else if (orcAppears == false)
        {
            Console.WriteLine("There are no more monsters to fight here, Adventurer.");
            Console.WriteLine();
            Console.WriteLine("More of the forest can be seen to the south.");
            Console.WriteLine("To the east is more of the forest.");
            Console.WriteLine("To the west lies a majestic mountain range.");
            Console.WriteLine("To the north lies a dense, dark forest.");
        }
    }
    else if ((coordinateStateX == 0) && (coordinateStateY == 2))
    {
        if (bugbearAppears == true)
        {
            enemyType = "bugbear";
            Console.WriteLine("The snarling grows louder as you encroach on the sound...");
            Console.WriteLine("...");
            Console.WriteLine("A gigantic bugbear charges from the treeline with a great shout!");
            rollInitative = true;
            while (rollInitative == true)
            {
                Console.WriteLine("What will you do, adventurer?!");

                string fightInput; //stores whatever is from ReadLine
                string fightCommand; //the action taken from ReadLine
                string additionalFightInfo; //what it says on the tin; context for what the action will do

                fightInput = Console.ReadLine();
                fightInput = fightInput.ToLower();
                string[] splitFightInput = fightInput.Split(" ");
                fightCommand = splitFightInput[0];
                additionalFightInfo = splitFightInput[1];

                if ((fightCommand == "use") && rollInitative == true)
                {
                    UseAnItem(additionalFightInfo);
                    if (bugbearHealth > 0)
                    {
                        Console.WriteLine("You are locked in combat!");
                        Console.WriteLine("The enemy's remaining health is " + bugbearHealth);
                    }
                    else if (bugbearHealth == 0)
                    {
                        Console.WriteLine("The bugbear falls with a sickening yell!");
                        Console.WriteLine("You have defeated the bugbear!");
                        bugbearAppears = false;
                        rollInitative = false;
                        break;
                    }
                }
            }
        }
        if (bugbearAppears == false)
        {
            Console.WriteLine("There are no more monsters to fight here, Adventurer.");
            Console.WriteLine();
            Console.WriteLine("More of the forest can be seen to the south.");
            Console.WriteLine("To the east is more of the forest.");
            Console.WriteLine("To the west lies a majestic mountain range.");
            Console.WriteLine("To the north lies a dense, dark forest.");
        }
    }
    else if ((coordinateStateX == 1) && (coordinateStateY == 1))
    {
        if (goblinAppears == true)
        {
            enemyType = "goblin";
            Console.WriteLine("The whispers cease as you encroach on the thicket...");
            Console.WriteLine("...");
            Console.WriteLine("A shifty trio of goblins drops from the treetops with a screech!");
            rollInitative = true;
            while (rollInitative == true)
            {
                Console.WriteLine("What will you do, adventurer?!");

                string fightInput; //stores whatever is from ReadLine
                string fightCommand; //the action taken from ReadLine
                string additionalFightInfo; //what it says on the tin; context for what the action will do

                fightInput = Console.ReadLine();
                fightInput = fightInput.ToLower();
                string[] splitFightInput = fightInput.Split(" ");
                fightCommand = splitFightInput[0];
                additionalFightInfo = splitFightInput[1];

                if ((fightCommand == "use") && rollInitative == true)
                {
                    UseAnItem(additionalFightInfo);
                    if (goblinHealth > 0)
                    {
                        Console.WriteLine("You are locked in combat!");
                        Console.WriteLine("The enemy's remaining health is " + goblinHealth);
                    }
                    else if (goblinHealth == 0)
                    {
                        Console.WriteLine("The goblins screech as they fall, one by one!");
                        Console.WriteLine("You have defeated the goblins!");
                        rollInitative = false;
                        goblinAppears = false;
                        break;
                    }
                }
            }
        }
        else if (goblinAppears == false)
        {
            Console.WriteLine("There are no more monsters to fight here, Adventurer.");
            Console.WriteLine();
            Console.WriteLine("More of the forest can be seen to the south.");
            Console.WriteLine("To the east is more of the forest.");
            Console.WriteLine("To the west lies a majestic mountain range.");
            Console.WriteLine("To the north lies a dense, dark forest.");
        }
    }
    
    if ((goblinAppears == false) && (bugbearAppears == false) && (orcAppears == false)) //levelUp conditions 
    {
        Console.WriteLine("You feel an imposing sense of power as your blade swings true one last time.");
        Console.WriteLine("A bolt light descends from the heavens and engulfs you in its power!");
        Console.WriteLine("You now possess the Greatsword!");
        doesHaveGreatsword = true; 
        levelUp = true;
    }
    
    else if ((coordinateStateX == -2) && (coordinateStateY == 2))
    {
        if (levelUp == false)
        {
            Console.WriteLine(
                "You summit the grand mountain peak. You get the feeling that something exciting might happen here...");
            Console.WriteLine("Smaller mountains can be seen to the south and east.");
            Console.WriteLine("To the north and west lie insurmountable peaks.");
        } //if no level up, then do not active boss fight 
        else if (levelUp == true) //if yes level up, start the boss fight 
        {
            enemyType = "boss";
            Console.WriteLine("You ascend the grand mountain peak.");
            Console.WriteLine("As you reach the summit, the air grows humid, then hot. As you crest the peak, you see it.");
            Console.WriteLine("Sitting upon a large pile of gold, red scales shine in the dying sunlight.");
            Console.WriteLine("Before you can determine your next move, a deep, serpentine voice whispers, \"Interloper...\"");
            Console.WriteLine("The dragon has noticed you. Good luck.");
            rollInitative = true;
            while (rollInitative == true)
            {
                Console.WriteLine("What will you do, adventurer?!");

                string fightInput; //stores whatever is from ReadLine
                string fightCommand; //the action taken from ReadLine
                string additionalFightInfo; //what it says on the tin; context for what the action will do

                fightInput = Console.ReadLine();
                fightInput = fightInput.ToLower();
                string[] splitFightInput = fightInput.Split(" ");
                fightCommand = splitFightInput[0];
                additionalFightInfo = splitFightInput[1];

                if ((fightCommand == "use") && (rollInitative == true))
                {
                    UseAnItem(additionalFightInfo);
                    if (bossHealth > 0)
                    {
                        Console.WriteLine("The dragon thrashes as you trade blows!");
                    }
                    else if (bossHealth == 0)
                    {
                        Console.WriteLine("The dragon screams as The Greatsword plunges inside its chest, piercing its heart!");
                        Console.WriteLine("As you wrench the blade from its steaming corpse, the sun begins to rise over the mountain peaks.");
                        Console.WriteLine("The land of Zorp is safe once more! Thanks to you, Adventurer!");
                        bossDefeated = true;
                        rollInitative = false;
                        break;
                    }
                }
            }
        }
    }
    
    if ((rollInitative == false) && (bossDefeated == true))
    {
        Console.WriteLine("Thanks for playing!");
        break; 
    }
}


/*
if ((command == "move") && (rollInitative == true))
   {
       Console.WriteLine("As you try desperately to run from the terrifying creature, it pins you down with one giant claw and singes the meat off your very bones!");
       Console.WriteLine("You are dead.");
       break;
   } //kills you if you run from battle

*/