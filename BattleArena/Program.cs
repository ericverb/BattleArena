// See https://aka.ms/new-console-template for more information

Console.WriteLine($"Welcome to Battle Arena!{Environment.NewLine}");
Console.WriteLine("Rules of the game are as follows!");
Console.WriteLine(
    "In the dream, you find yourself trapped in a battle arena. You have two stats that determine their survival");
Console.WriteLine("Stamina – starts at 10. If it reaches 0, the user dies");
Console.WriteLine("Panic Level – starts at 10. If it reaches 20, the user dies");
Console.WriteLine(
    $"In the arena, you must battle enemies. The enemy starts with 10 hit points and dies when that reaches 0.{Environment.NewLine}");
Console.WriteLine("You do battle by rolling the dice each turn. Each roll will return 1-6.");
Console.WriteLine("1 – The user gets hit, and their panic level increases by 2");
Console.WriteLine("2 – The user dodges the attack, but their stamina is reduced by 1");
Console.WriteLine("3 – The user deflects the attack. There is no stat change");
Console.WriteLine("4 – The enemy backs away; the user’s stamina increases by 1");
Console.WriteLine(
    "5 – The enemy dodges, but the user strikes a glancing blow. The user’s panic is reduced by 1. The enemy loses 3 hit points. ");
Console.WriteLine(
    "6 – The enemy takes significant damage. The user’s panic is reduced by 3. Your stamina is increased by 2. The enemy loses 5 hit points. ");
Console.WriteLine($"The user has 10 rolls of the die to defeat the enemy.{Environment.NewLine}");

bool playAgain = true;

while (playAgain == true)
{
    Console.WriteLine("Would you like to play Battle Arena? Type Yes or No!");
    string playGame = Console.ReadLine();
    playGame.ToLower();

    if (playGame == "yes")
    {
        int stamina = 10;
        int panicLevel = 10;
        int enemieHitPoints = 10;
        int numberOfRolls = 0;
        string[] enemyArray =
            {"Venom", "Rampage", "The Blob", "Dr. Evil", "Frickin Sharks", "PennyWise", "Freddy Kruger"};
        int enemyNumber = new Random().Next(0, 6);
        string enemy = enemyArray.ElementAt(enemyNumber);
        Console.WriteLine("What is your Warrior's Name!");
        string warriorName = Console.ReadLine();
        Console.WriteLine($"You will be battling {enemy}{Environment.NewLine}!");

        while (numberOfRolls <= 10)
        {
            Console.WriteLine($"{warriorName} Please type R to roll the dice!");
            string dice = Console.ReadLine();
            dice.ToLower();

            if (dice == "r")
            {
                int diceRoll = new Random().Next(1, 7);
                Console.WriteLine($"You have rolled a {diceRoll}!");
                if (diceRoll == 1)
                {
                    numberOfRolls++;
                    panicLevel += 2;
                    if (panicLevel == 20)
                    {
                        Console.WriteLine($"{warriorName} your panic level is at {panicLevel} and you have died!");
                    }
                    else
                    {
                        Console.WriteLine(
                            $"{warriorName} gets hit, and your panic level increases by 2 to {panicLevel}");
                        panicLevel += 1;
                        stamina += -1;
                        Console.WriteLine(
                            $"Enemy has not died, {warriorName} panic increases by 1 to {panicLevel}. Their stamina is reduced by 1 to {stamina}.{Environment.NewLine}");

                        if (panicLevel == 20)
                        {
                            Console.WriteLine("Panic level now at 20 and you have died! ");
                            numberOfRolls = 10;
                        }

                        if (stamina == 0)
                        {
                            Console.WriteLine("Panic level now at 20 and you have died!");
                            numberOfRolls = 10;
                        }
                    }
                }
                else if (diceRoll == 2)
                {
                    numberOfRolls++;
                    stamina += -1;
                    Console.WriteLine(
                        $"{warriorName} dodges the attack, but your stamina is reduced by 1 to {stamina}");
                    panicLevel += 1;
                    stamina += -1;
                    Console.WriteLine(
                        $"Enemy has not died, {warriorName} panic increases by 1 to {panicLevel}. Their stamina is reduced by 1 to {stamina}.{Environment.NewLine}");

                    if (panicLevel == 20)
                    {
                        Console.WriteLine("Panic level now at 20 and you have died! ");
                        numberOfRolls = 10;
                    }

                    if (stamina == 0)
                    {
                        Console.WriteLine("Panic level now at 20 and you have died!");
                        numberOfRolls = 10;
                    }
                }
                else if (diceRoll == 3)
                {
                    numberOfRolls++;
                    Console.WriteLine($"{warriorName} deflects the attack. There is no stat change");
                    panicLevel += 1;
                    stamina += -1;
                    Console.WriteLine(
                        $"Enemy has not died, {warriorName} panic increases by 1 to {panicLevel}. Their stamina is reduced by 1 to {stamina}. {Environment.NewLine}");

                    if (panicLevel == 20)
                    {
                        Console.WriteLine("Panic level now at 20 and you have died! ");
                        numberOfRolls = 10;
                    }

                    if (stamina == 0)
                    {
                        Console.WriteLine("Panic level now at 20 and you have died!");
                        numberOfRolls = 10;
                    }
                }
                else if (diceRoll == 4)
                {
                    numberOfRolls++;
                    stamina += 1;
                    Console.WriteLine($"Enemy backs away; {warriorName}your stamina increases by 1 to {stamina}");
                    panicLevel += 1;
                    stamina += -1;
                    Console.WriteLine(
                        $"Enemy has not died, {warriorName} panic increases by 1 to {panicLevel}. Their stamina is reduced by 1 to {stamina}.{Environment.NewLine}");

                    if (panicLevel == 20)
                    {
                        Console.WriteLine("Panic level now at 20 and you have died! ");
                        numberOfRolls = 10;
                    }

                    if (stamina == 0)
                    {
                        Console.WriteLine("Panic level now at 20 and you have died!");
                        numberOfRolls = 10;
                    }
                }
                else if (diceRoll == 5)
                {
                    numberOfRolls++;
                    enemieHitPoints += -3;
                    panicLevel += -1;
                    Console.WriteLine(
                        $"Enemy dodges, but the {warriorName} strikes a glancing blow. Your panic is reduced by 1 to {panicLevel}. {enemy} loses 3 hit points and is now at {enemieHitPoints}.");
                    if (enemieHitPoints == 0)
                    {
                        Console.WriteLine($"Your {enemy} has died!");
                        enemyNumber = new Random().Next(0, 6);
                        enemy = enemyArray.ElementAt(enemyNumber);
                        Console.WriteLine($"You will now be facing {enemy}!");
                        enemieHitPoints = 10;
                    }
                    else
                    {
                        panicLevel += 1;
                        stamina += -1;
                        Console.WriteLine(
                            $"Enemy has not died, {warriorName} panic increases by 1 to {panicLevel}. Their stamina is reduced by 1 to {stamina}. ");
                    }
                }
                else if (diceRoll == 6)
                {
                    numberOfRolls++;
                    enemieHitPoints += -5;
                    stamina += 2;
                    panicLevel = -3;
                    Console.WriteLine(
                        $"{enemy} takes significant damage. {warriorName} panic is reduced by 3 to {panicLevel}. Their stamina is increased by 2 to {stamina}. {enemy} loses 5 hit points and is now at {enemieHitPoints}.");
                    if (enemieHitPoints == 0)
                    {
                        Console.WriteLine($"Your {enemy} has died!");
                        enemyNumber = new Random().Next(0, 5);
                        enemy = enemyArray.ElementAt(enemyNumber);
                        Console.WriteLine($"You will no be facing {enemy}!");
                        enemieHitPoints = 10;
                    }
                    else
                    {
                        panicLevel += 1;
                        stamina += -1;
                        Console.WriteLine(
                            $"Enemy has not died, {warriorName} panic increases by 1 to {panicLevel}. Their stamina is reduced by 1 to {stamina}. ");
                    }
                }
            }
            else
            {
                Console.WriteLine(
                    $"You did not enter R to roll. Thanks for trying to play and failing to follow the simple instruction listed above!{Environment.NewLine}");
            }

        }

        Console.WriteLine(
            $"{warriorName} you have reached your maximum amount of rolls, and your panic level has reached 20. You have not defeated {enemy}!{Environment.NewLine}");
        Console.WriteLine("Your Battle Arena Dream has started all over again...Prepare to fight!");
    }
    else
    {
        Console.WriteLine("Sorry you did not want to play Battle Arena....There must be something wrong with you!");
        playAgain = false;
    }
}