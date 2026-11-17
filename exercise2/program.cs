using System; 

class Program
{
    static void Main(string [] args)
    {
        int [] result = new int [10000]; 
        int twos= 0;
        int fives= 0;

        Random random = new Random();
        
    
        for(int i= 0; i< 10000; i++)
        {
            int rnd = random.Next(1, 7);
            result[i] = rnd;

                if(result[i] == 2)
                {
                    twos++;
                }
                else if (result[i] == 5)
                {
                    fives++;
                }
        }
        Console.WriteLine(" Antalet tvåor: " + twos + " Antalet femmor: " + fives);
    }
}