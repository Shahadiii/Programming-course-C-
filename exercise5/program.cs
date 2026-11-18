using System.IO;
//uppgift 1.4 
String line;
try{
StreamReader reader = new StreamReader("C:\\Users\\ponpo\\Downloads\\matdata_uppgift14.txt");

line = reader.ReadLine();
    while(line != null)
    {
        Console.WriteLine(line);
        line= reader.ReadLine();
    }
    reader.Close();
    Console.ReadLine();

}
catch(Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally 
{
    Console.WriteLine("Executing finally block.");
}