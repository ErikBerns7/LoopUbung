
//Loop um die Nummer zwischen 0 und 100 zu halten
using System.Runtime.InteropServices;

while (true) {
    
    //Fragt den ersten Nutzer nach einer Nummer
    Console.WriteLine("Pilot, enter a number between 0 and 100");
    string pilotNumberText = Console.ReadLine();
    int pilotNumber = Convert.ToInt32(pilotNumberText);

    if (pilotNumber > 100)
    {
        Console.WriteLine("Too high, enter a new number");
        continue;
    }

    else if (pilotNumber < 0)
    {
        Console.WriteLine("Too low, enter a new number");
        continue;
    }


    else
    {   //Loop indem der zweite Nutzer die nummer errät
        Console.Clear();
        while (true)
        {

            Console.WriteLine("Hunter, enter a number between 0 and 100");
            string hunterNumberText = Console.ReadLine();
            int hunterNumber = Convert.ToInt32(hunterNumberText);

            if (hunterNumber > pilotNumber)
            {
                Console.WriteLine("Too high, try again");
                continue;
            }
            else if (hunterNumber < pilotNumber)
            {
                Console.WriteLine("Too low, try again");
                continue;
            }
            else
            {
                Console.WriteLine("You guessed right!");
                break;
            }
        }
    }
    Environment.Exit(0);
}



