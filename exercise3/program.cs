using System;

class Pengar
{
    
    public static void Main(String [] args)
    {
        int ettHundra = 0;
        int femHundra = 0;
        int tjugo = 0;
        int fem = 0;
        int en = 0;
        int öring = 0;
       try
        {
        Console.WriteLine("Ange kostanden: ");
        decimal price = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Ange erhållet belopp: ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());

        if (price > 0 && amount > 0 && amount >= price)
        {
          decimal giveBack = amount - price;
          
                femHundra = (int)Math.Floor(giveBack / 500);
                decimal rest1  = Convert.ToDecimal(giveBack-(femHundra * 500)); 

                ettHundra = (int)Math.Floor(rest1 / 100);
                decimal rest2  = Convert.ToDecimal(rest1- (ettHundra * 100));

                tjugo = (int)Math.Floor(rest2 / 20) ;
                decimal rest3 = Convert.ToDecimal(rest2 - (tjugo * 20));

                fem = (int)Math.Floor(rest3 / 5) ;
                decimal rest4 = Convert.ToDecimal(rest3 - (fem * 5));

                en = (int)Math.Floor(rest4 / 1) ;
                decimal rest5 = Convert.ToDecimal(rest4 - (en * 1));

                öring = (int)Math.Floor(rest5 / 0.50m) ;
                decimal rest6 = Convert.ToDecimal(rest5 - (öring * 0.50m));
           
            }
        }
        catch(FormatException ex)
        {
                Console.WriteLine("Felaktig in matning: " + ex.Message);
        }
        
        Console.WriteLine("500-lappar: " + femHundra + " 100-lappar: " + ettHundra + " 20-lappar: " + tjugo +  " 5-kronor: " + fem 
        +  " en-kronor: " + en +  " 50-öring: " + öring);
    }
}