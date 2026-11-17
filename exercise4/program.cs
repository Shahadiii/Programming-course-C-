// See https://aka.ms/new-console-template for more information

using System;

//Uppgift 1.3 Effektiv vindavkylning.

class Program
{
    public static void Main(String [] args)
    {
        Console.WriteLine("  :                                         Temprature <°C>                                               ");
        String[] letters = {"  :", "  :", "W :", "I :", "N :", "D :", "k :", "m :", "/ :", "s :", "  :", "  :", "  :"};
        
        int [] v = {2,4,6,8,10,12,14,16,18,20,22,24,26};
        int [] temp = {10,8,6,4,2,0,-2,-4,-6,-8,-10,-12,-14,-16,-18,-20,-22,-24,-26,-28,-30}; 

        Console.Write("  :         ");
        for(int t= 0; t< temp.Length; t++)
        {
            Console.Write(temp[t].ToString().PadLeft(3).PadRight(6));
        }

        Console.WriteLine();
        Console.WriteLine(new string ('-',9 + temp.Length * 7));
        
        for(int j= 0; j< v.Length; j++)
        {
            Console.Write($"{letters[j], -4}");
            Console.Write($"{v[j],4}:");

                for(int w= 0; w< temp.Length; w++)
                {
                    

                    double T = 13.12667 + 0.6215 * temp[w] - 13.924748 * Math.Pow(v[j], 0.16) + 0.4875195 * temp[w] * Math.Pow(v[j], 0.16);  //upplevd temp  
                    if(Math.Round(T) <= -28)
                    {
                        Console.ForegroundColor= ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.Gray;
                        
                    }
                    
                    Console.Write($"{T, 6:F0}"); 
                    Console.ResetColor();
                
                }
                    Console.WriteLine();
                    
        }
        
    }
}