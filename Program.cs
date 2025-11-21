using System;
using System.Text;

public class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        //menu
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Increase your level";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 3.";
        
        //trainwizard
        const string InsertNamePrompt = "Enter your wizard's name: ";
        const string TrainingMsg = "Day {0} -> {1} has trained for a total of {2} hours and gained {3} power points.";
        const string TrainingCompleteMsg = "Training complete! {0} has achieved a total power of {1} points and earned the title '{2}'."; 
        const string MsgE = "Repeteixes a 2a convocatòria.";
        const string MsgD = "Encara confons la vareta amb una cullera.";
        const string MsgC = "Ets un Invocador de Brises Màgiques.";
        const string MsgB = "Uau! Pots invocar dracs sense cremar el laboratori!";
        const string MsgA = "Has assolit el rang de Mestre dels Arcans!";
        const string RankE = "Raoden el Elantrí";
        const string RankD = "Zyn el Buguejat";
        const string RankC = "Arka Nullpointer";
        const string RankB = "Elarion de les Brases";
        const string RankA = "ITB-Wizard el Gris";
        const int TotalDaysTraining = 5;
        const int MaxHoursPerDay = 25;
        const int MaxPowerPerDay = 11;
        const int MinHoursPerDay = 1;
        const int MinPowerPerDay = 1;

        int op, totalPower = 0, totalHours = 0; ;
        string? wizardName, wizardTitle;
        string finalMessage;
        Random rnd = new Random();

        //Increase LVL
        const string monsterSkeleton = "Wandering Skeleton", monsterGoblin = "Forest Goblin", 
            monsterSlime = "Green Slime", monsterWolf = "Ember Wolf", 
            monsterSpider = "Giant Spider", monsterGolem = "Iron Golem", 
            monsterNecromancer = "Lost Necromancer", monsterDragon = "Ancient Dragon";
        const string dice1 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n |       | |\r\n |   o   | /\r\n |       |/ \r\n '-------'\r\n";
        const string dice2 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o     | |\r\n |       | /\r\n |     o |/ \r\n '-------'\r\n";
        const string dice3 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o     | |\r\n |   o   | /\r\n |     o |/ \r\n '-------'\r\n";
        const string dice4 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o   o | |\r\n |       | /\r\n | o   o |/ \r\n '-------'\r\n";
        const string dice5 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o   o | |\r\n |   o   | /\r\n | o   o |/ \r\n '-------'\r\n";
        const string dice6 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o   o | |\r\n | o   o | /\r\n | o   o |/ \r\n '-------'\r\n";
        const string MonsterRevealed = "Your oponent is {0} and has a total HP of {1}";
        const string DiceRevealed = "You rolled the dice and got a {0}.";
        const string HpDecreased = "The HP decreased to {0}";
        const string noHp = "You have slained the monster!";
        const string lvlUp = "Congratulations! You levelep up! Now your lvl is: {0}";
        const string lvlFinal = "You have reached the final level.";


        int rndPositionArray;
        int rndDice;
        int monsterHp; 
        int levelMage = 0;
        int[] monsterHpArray = {3, 5, 10, 11, 18, 15, 20, 50};
        string[] monsterArray = {monsterSkeleton, monsterGoblin, monsterSlime, monsterWolf, 
            monsterSpider, monsterGolem, monsterNecromancer, monsterDragon};
        string[] diceArray = {dice1, dice2, dice3, dice4, dice5, dice6};

        //exit
        const string ExitMessage = "Exiting game. Goodbye!";


        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);

            try
            {
                op = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
                op = -1;
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
                op = -1;
            }
            Console.WriteLine();
            switch (op)
            {
                case 1: //Train your wizard
                    Console.Write(InsertNamePrompt);
                    wizardName = Console.ReadLine();

                    for (int day = 1; day <= TotalDaysTraining; day++)
                    {
                        totalHours += rnd.Next(MinHoursPerDay, MaxHoursPerDay);
                        totalPower += rnd.Next(MinPowerPerDay, MaxPowerPerDay);

                        Console.WriteLine(TrainingMsg, day, wizardName, totalHours, totalPower);
                    }

                    if (totalPower < 20)
                    {
                        finalMessage = MsgE;
                        wizardTitle = RankE;
                    }
                    else if (totalPower >= 20 && totalPower < 30)
                    {
                        finalMessage = MsgD;
                        wizardTitle = RankD;
                    }
                    else if (totalPower >= 30 && totalPower < 35)
                    {
                        finalMessage = MsgC;
                        wizardTitle = RankC;
                    }
                    else if (totalPower >= 35 && totalPower < 40)
                    {
                        finalMessage = MsgB;
                        wizardTitle = RankB;
                    }
                    else // totalPower >= 40
                    {
                        finalMessage = MsgA;
                        wizardTitle = RankA;
                    }

                    Console.WriteLine(finalMessage);
                    Console.WriteLine(TrainingCompleteMsg, wizardName, totalPower, wizardTitle);

                    break;

                case 2: //Increase your level

                    rndPositionArray = rnd.Next(0, 8);
                    monsterHp = monsterHpArray[rndPositionArray];
                    
                    if (levelMage == 5)
                    {
                        Console.WriteLine(lvlFinal);
                    }
                    else
                    {
                        Console.WriteLine(MonsterRevealed, monsterArray[rndPositionArray], monsterHp);

                        do
                        {
                            rndDice = rnd.Next(0, 6);

                            Console.WriteLine(diceArray[rndDice]);

                            monsterHp -= (rndDice + 1);
                            Console.WriteLine(DiceRevealed, (rndDice + 1));

                            if (monsterHp > 0)
                            {
                                Console.WriteLine(HpDecreased, monsterHp); 
                            }
                            else
                            {
                                Console.WriteLine(noHp);
                                levelMage++;
                                Console.WriteLine(lvlUp, levelMage);
                            }

                            if (levelMage == 5)
                            {
                                Console.WriteLine(lvlFinal);
                            }
                        } while (monsterHp > 0);
                    }

                    break;
                case 3: //Loot the mine
                    
                    break;
                case 0:
                    Console.WriteLine(ExitMessage);
                    break;
                default:
                    Console.WriteLine(InputErrorMessage);
                    break;
            }
        Console.WriteLine();
        } while (op != 0);
    }

}