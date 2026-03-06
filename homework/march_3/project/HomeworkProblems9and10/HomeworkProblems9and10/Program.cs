//write a loop counting 1-20 and state whether or not its even 

int index = 1;
bool isOdd = true; 

while (index <= 20);
{
    Console.WriteLine(index);
    index = index + 1;
    if (isOdd == true)
    {
        Console.WriteLine("It's Odd");
        isOdd = false;
    }
    else if (isOdd == false)
    {
        Console.WriteLine("It's Even");
        isOdd = true;
    }
}


//create an array of strings and a loop to write them all out 

(string name, string age, string gender)[] student;
student = new (string name, string age, string gender)[3];

student[0].name = "Saturn";
student[0].age = "16";
student[0].gender = "Who Knows?";
student[1].name = "Lillian";
student[1].age = "19";
student[1].gender = "Female";
student[2].name = "Bob";
student[2].age = "21";
student[2].gender = "Male";
student[3].name = "Cotton";
student[3].age = "Eyed";
student[3].gender = "Joe";

string answer3 = Console.ReadLine();

Console.WriteLine("Do you want the student roster?");
Console.ReadLine();
if (answer3 == "Yes")
{
    Console.WriteLine(student[0].name, student[0].age, student[0].gender);
    Console.WriteLine(student[1].name, student[1].age, student[1].gender);
    Console.WriteLine(student[2].name, student[2].age, student[2].gender);
    Console.WriteLine(student[3].name, student[3].age, student[3].gender);
}

if (answer3 == "No")
{
    Console.WriteLine("Okay then, I'll stop."); 
}