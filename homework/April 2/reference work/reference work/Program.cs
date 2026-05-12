// StreamReader reader = new StreamReader(); 
/*
using (StreamWriter writer = new StreamWriter("Users/lillian/Documents/file.txt"))
{//open the file (create it if it doesn't exist) 
    writer.WriteLine("Hello!"); 
}//close the file 


StreamWriter writer = new StreamWriter("Users/lillian/Documents/file.txt");
writer.WriteLine("Hello!");
Console.WriteLine("Howdy!!!");
writer.Write("Hello!");
writer.WriteLine("Hello!");
writer.Close();

// /Users/lillybug/Documents/file.txt ---> This is an absolute path
// Leading forward slash is called Root Directory -> Means the directory is an absolute path
//we now have a new file under the name file.txt 

*/
StreamReader reader = new StreamReader("file.txt");
string line;

while (true)
{
    line = reader.ReadLine();
    if (line == null)
    {
        Console.WriteLine("You're out of space, bucko.");
        break; 
    }
    Console.WriteLine(line);
}
reader.Close();

/*
string line; 
do 
{
    line = reader. ReadLine();
    Console.WriteLine(line); 
}
while (line != null);
reader.Close;
*/