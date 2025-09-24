class Program
{ 
    public static void Main(string[] args)
    {

        bool play = true;
        int sticks = 0;
        int player = 0;

        while (play)
        {
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine("     Game of Sticks      ");
            Console.WriteLine("-------------------------\n");

            Console.WriteLine("Players will take turns removing between 1 and 3 of the remaining sticks.  \r\nThe player that removes the last stick loses.");

            SticksSet(ref sticks, 20);
            PlayerSet(ref player, 1);

            int stickMin = 1;
            int stickMax = 3;

            do
            {
                if (sticks < stickMax)
                {
                    stickMax = sticks;
                }

                Console.SetCursorPosition(0, 9);
                Console.Write("                                                         ");

                Console.SetCursorPosition(0, 9);
                Console.Write($"How many sticks do you take ({stickMin} - {stickMax})? ");
                int take = Convert.ToInt32(Console.ReadLine());

                while (take < stickMin || take > stickMax)
                {
                    ClearLine(9);
                    Console.SetCursorPosition(0, 9);
                    Console.Write($"Must be number between {stickMin} and {stickMax}: ");
                    take = Convert.ToInt32(Console.ReadLine());
                }

                if (player == 1)
                {
                    player = 2;
                }
                else
                {
                    player = 1;
                }

                ClearLine(7);
                SticksSet(ref sticks, sticks - take);
                PlayerSet(ref player, player);
            }
            while (sticks > 0);
            
            Console.SetCursorPosition(0, 11);
            Console.WriteLine($"Player {player} won!");

            string again = "";

            do
            {
                Console.Write("Play Again (Y/N)? ");
                again = Console.ReadLine().ToUpper();
            }
            while (again != "N" && again != "Y");

            if (again == "N")
            {
                play = false;
            }
        }
    }
    public static void SticksSet(ref int Sticks, int value)
    {
        Sticks = value;
        Console.SetCursorPosition(0, 7);
        Console.WriteLine("Sticks Left: " + GetSticksString(Sticks));
    }

    public static void PlayerSet(ref int player, int value)
    {
        player = value;
        Console.SetCursorPosition(40, 7);
        Console.WriteLine($"Player: {player}");
    }
    public static string GetSticksString(int sticks)
    {
        string stickString = "";

        for (var i = 0; i < sticks; i++)
        {
            stickString += "|";
        }

        return stickString;
    }

    public static void ClearLine(int line)
    {
        Console.SetCursorPosition(0, line);
        Console.Write("                                                         ");
    }
}


