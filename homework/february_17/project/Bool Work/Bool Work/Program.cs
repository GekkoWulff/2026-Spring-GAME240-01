int[] weather;
weather = new int[] {80, -23, 45, 67, 90, 76, 89};

int i;
i = 0;
while (i < weather.Length)
{
    if (weather[i] == 90)
    {
        Console.WriteLine("Hey! We found it!");
        Console.WriteLine("Day #" + i + " is 90 degrees");
        
    }

    i = i + 1;
}



struct Student
{
    string name;
    string letterGrade;
    double percentage;
}