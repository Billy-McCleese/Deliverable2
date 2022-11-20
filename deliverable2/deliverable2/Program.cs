using System;

namespace deliverable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. Welcome to Billy's Buffet. All you can eat for $9.99! We only charge $2 extra for beer. How many people are in your group? Please, parties of 6 or lower. ");
            int NumberPeople = int.Parse(Console.ReadLine());

            if (NumberPeople > 6) {Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day. "); Environment.Exit(0); }
            else if (NumberPeople is 0) { Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day. "); Environment.Exit(0); }
            else { Console.WriteLine("A table for " + NumberPeople +  "! Please follow me and take a seat.\r\nLet's get everyone started with some drinks. We've got water or beer. ");  }

            int BeerTotal = 0;   
            int WaterTotal = 0;
            int PartyTotal = NumberPeople; 
            while (NumberPeople <= '6' && NumberPeople > 0)
            {
                Console.WriteLine("Alright, Guest # " + NumberPeople + " would you like water or beer");
                string Order = (Console.ReadLine());
                NumberPeople--;

                if (Order is "beer") { BeerTotal++; Console.WriteLine(Order + " Nice Choice!"); }
                else if (Order is "Beer") { BeerTotal++; Console.WriteLine(Order + " Nice Choice!"); }
                else if (Order is "water") { WaterTotal++; Console.WriteLine(Order + " Nice Choice!"); }
                else if (Order is "Water") { WaterTotal++; Console.WriteLine(Order + " Nice Choice!"); }
                else Console.WriteLine("Sorry, we don't have that. No drink for you!"); 

 
            }
            Console.WriteLine("Okay, so that's " + BeerTotal + " beers and " + WaterTotal + " Waters. I'll be right back. Feel free to grab your food");
            Decimal OrderTotal = (decimal)((BeerTotal * 2) + (PartyTotal * 9.99));

            Console.WriteLine("Here's your bill! Total Price: $" + OrderTotal + " . Please visit us again soon!");
                         
        }
    }
}
