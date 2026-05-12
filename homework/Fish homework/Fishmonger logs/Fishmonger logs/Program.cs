//  /Users/lillybug/Desktop/sample_files/logs/1.txt = text one logs 
// /Users/lillybug/Desktop/sample_files/specials/1.txt = text one special


//string fileName = Console.ReadLine();
//StreamReader reader = new StreamReader(fileName); 

using System.Net.Mime;

string readLog = "";
string readSpecial = "";

int totalNumberOfFish = 0; 
int totalSpecialFish = 0; 

bool isLogFilePathValid = false;
while (isLogFilePathValid == false) //load in log file 
{
    Console.WriteLine("Hey, we need your log to see what fish you caught. Do we need to 86 our special tonight?");
    string filepath = Console.ReadLine();
    try
    {
        StreamReader reader = new StreamReader(filepath);
        isLogFilePathValid = true;
        
        readLog = reader.ReadToEnd();
        Console.WriteLine(readLog);

        reader.Close();
    }
    catch (Exception e)
    {
        Console.WriteLine("Something went wrong finding your log.");
    }
}

bool isSpecialFilePathValid = false;
while (isSpecialFilePathValid == false)
{
    Console.WriteLine("Alright, at least we've got that. Remind me what the special is tonight?");
    string filepath = Console.ReadLine();
    try
    {
        StreamReader reader = new StreamReader(filepath);
        isSpecialFilePathValid = true;
        
        readSpecial = reader.ReadToEnd();
        Console.WriteLine(readSpecial);

        reader.Close();
    }
    catch (Exception e)
    {
        Console.WriteLine("Something went wrong finding the special.");
    }

}

string[] arrayOfReadingLog = readLog.Split("\n");

foreach (string lineInLog in arrayOfReadingLog)
{
    string[] countingUpFish = lineInLog.Split(' ');
    int numberOfFishCaught = int.Parse(countingUpFish[0]);
    totalNumberOfFish = numberOfFishCaught + totalNumberOfFish;

    if ()
    {
        //int totalSpecialFish = 0; 
        string typeOfFishCaught = countingUpFish[1];   
    }
}



// ✅make a new array that is each word in the line (array of an array) 
//✅make a variable for the number of fish caught (entry 0 in array) 
    // ✅parse the variables in entry 0 
    // ✅add up variables for number of fish caught (add entry 0s together) 
//✅make a variable for the type of fish needed to find (entry 1 in array) 
    // make sure i have a variable for special 
    //make an if loop to cycle through (if entry 1 == special then add it to the others, if else then forget it) 








/*
using (StreamWriter writer = new StreamWriter("/Users/lillybug/Documents/GitHub/2026-Spring-GAME240-01/homework/Fish homework/Fishmonger logs/file.txt"))
{//this + code above opens a new file 
    writer.WriteLine();
    //this is what we write in the file 
}//close the file

using (StreamReader readingFile =
       new StreamReader(
           "/Users/lillybug/Documents/GitHub/2026-Spring-GAME240-01/homework/Fish homework/Fishmonger logs/file.txt"))
{//this opens up the file to be read 
    string savingSomething = readingFile.ReadToEnd();
   Console.WriteLine(savingSomething); 
   
}
*/

// writer.WriteLine("Hello!");
// Console.WriteLine("Howdy!!!");
// writer.Write("Hello!");
// writer.WriteLine("Hello!");
// writer.Close();

// /Users/lillybug/Documents/file.txt ---> This is an absolute path
// Leading forward slash is called Root Directory -> Means the directory is an absolute path
//we now have a new file under the name file.txt 
