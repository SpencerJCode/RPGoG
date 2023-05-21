Console.Clear();
bool NewChar = false;
Console.WriteLine("Hello and welcome to The Role Playing Game of Games!");
Console.WriteLine("Are you ready to get started?");
string Response = Console.ReadLine();
if (Response.Contains("es") || Response.Contains("ure"))
{
    NewChar = true;
}

Race Human = new Race("Human", 2, 0, 0, 0, 0, 0);
Race Elf = new Race("Elf", 0, 2, -2, 0, 2, 0);
Race Dwarf = new Race("Dwarf", 2, 0, 2, 0, 0, -2);
if (NewChar)
{
    Console.Clear();
    Console.WriteLine("What is your name, Hero?");
    string? Input = Console.ReadLine();
    string newName = "";
    if (Input == null) { newName = "Hero"; } else { newName = Input; }
    Player Player = new Player(newName);
    Console.Clear();
    Console.WriteLine($"Welcome, {Player.Name}!");
    Console.WriteLine("These are desperate times. The lands are swarming with evil creatures and villains, and our best soldiers and warriors are off fighting the war against Keldera.");
    Console.WriteLine("We need a new warrior to stand for the people and protect the innocent from the threats they face every day.");
    Console.WriteLine("I can tell just by looking at you that you are just the type of hero the people need.");
    Console.WriteLine("");
    Console.WriteLine("--press enter to continue--");
    Input = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Take off your hood, Hero, so I can see what race you are!");
    Console.WriteLine("");
    Console.WriteLine("--remove hood--");
    Input = Console.ReadLine();
    Console.Clear();

    //Select a Race and modify character stats based on race
    bool ChooseRace = true;
    while (ChooseRace)
    {
        Console.WriteLine("Oh, I see, you're a...");
        Console.WriteLine("");
        Console.WriteLine("Choose from the below options:");
        Console.WriteLine("1: Human");
        Console.WriteLine("2: Elf");
        Console.WriteLine("3: Dwarf");
        Input = Console.ReadLine();
        Console.Clear();
        if (Input == "1" || Input == "Human")
        {
            Console.WriteLine("Humans receive a +2 bonus to their strength score, and have no stat penalties.");
            Console.WriteLine("Are you sure you want to be a human?");
            Console.WriteLine("");
            Console.WriteLine("--yes or no--");
            Input = Console.ReadLine();
            if (Input.Contains("es")) { Player.AssignRace(Human); ChooseRace = false; }
            else { Input = "4"; Console.Clear(); }

        }
        else if (Input == "2" || Input == "Elf")
        {
            Console.WriteLine("Elves receive a +2 bonus to their dexterity and wisdom scores, but have a -2 penalty to their constitution.");
            Console.WriteLine("Are you sure you want to be an Elf?");
            Console.WriteLine("");
            Console.WriteLine("--yes or no--");
            Input = Console.ReadLine();
            if (Input.Contains("es")) { Player.AssignRace(Elf); ChooseRace = false; }
            else { Input = "4"; Console.Clear(); }
        }
        else if (Input == "3" || Input == "Dwarf")
        {
            Console.WriteLine("Dwarves receive a +2 bonus to their strength and constitution scores, but have a -2 penalty to their charisma.");
            Console.WriteLine("Are you sure you want to be a dwarf?");
            Console.WriteLine("");
            Console.WriteLine("--yes or no--");
            Input = Console.ReadLine();
            if (Input.Contains("es")) { Player.AssignRace(Dwarf); ChooseRace = false; }
            else { Input = "4"; Console.Clear(); }
        }
        else
        {
            Console.WriteLine("Huh, my eyes are playing tricks on me. Step a little further into the light.");
        }
    }
    Console.Clear();
    Console.WriteLine($"Ah, I thought you must be a {Player.Race.Name} based on your build!");
    Console.WriteLine("");
    Console.WriteLine("--press enter--");
    Input = Console.ReadLine();
    Console.Clear();

    //Select a class and instantiate base gear. All other gear will be instantiated later.
    bool ChooseClass = true;
    Weapon Dagger = new Weapon("Dagger", 4, false, 18, 6);
    Weapon LongSword = new Weapon("Long Sword", 8, false, 19, 16);
    Weapon QuarterStaff = new Weapon("Quarter Staff", 6, true, 19, 4);
    Armor Buckler = new Armor("Buckler", 1, true, 5);
    while (ChooseClass)
    {
        CharacterClass Warrior = new CharacterClass("Warrior", 10, 1, 20, false);
        CharacterClass Rogue = new CharacterClass("Rogue", 6, .75, 20, false);
        CharacterClass Monk = new CharacterClass("Monk", 8, .75, 20, true);
        Console.WriteLine("What kind of training do you have, Hero?");
        Console.WriteLine("");
        Console.WriteLine("1: Warrior");
        Console.WriteLine("2: Rogue");
        Console.WriteLine("3: Monk");
        Input = Console.ReadLine();
        if (Input == "1")
        {
            Console.WriteLine("Warriors receive major bonuses in both physical combat and HP.");
            Console.WriteLine("Are you sure you want to be a warrior?");
            Console.WriteLine("");
            Console.WriteLine("--yes or no--");
            Input = Console.ReadLine();
            if (Input.Contains("es"))
            {
                Console.Clear();
                Player.AssignClass(Warrior);
                ChooseClass = false;
                Player.EquipWeapon(LongSword);
                Player.EquipShield(Buckler);
            }
            else { Input = "4"; Console.Clear(); }
        }
        else if (Input == "2")
        {
            Console.WriteLine("Rogues receive major bonuses in both accuracy and evasion.");
            Console.WriteLine("Are you sure you want to be a rogue?");
            Console.WriteLine("");
            Console.WriteLine("--yes or no--");
            Input = Console.ReadLine();
            if (Input.Contains("es"))
            {
                Console.Clear();
                Player.AssignClass(Rogue);
                ChooseClass = false;
                Player.EquipWeapon(Dagger);
                Player.EquipShield(Buckler);
            }
            else { Input = "4"; Console.Clear(); }
        }
        else if (Input == "3")
        {
            Console.WriteLine("Monks receive major bonuses in both physical combat and evasion, but can't use armor.");
            Console.WriteLine("Are you sure you want to be a monk?");
            Console.WriteLine("");
            Console.WriteLine("--yes or no--");
            Input = Console.ReadLine();
            if (Input.Contains("es"))
            {
                Console.Clear();
                Player.AssignClass(Monk);
                ChooseClass = false;
                Player.EquipWeapon(QuarterStaff);
            }
            else { Input = "4"; Console.Clear(); }
        }
        else { Console.Clear(); }
    }
    ChooseClass = false;
    int NewStatPoints = 8;
    while(NewStatPoints >0)
    {
        Console.WriteLine($"As a new player, you have {NewStatPoints} points to apply to your character wherever you'd like. Use the guide below to help you decide.");
        Console.WriteLine("");
        Console.WriteLine("1: Strength increases your chance to penetrate armor and the damage you deal.");
        Console.WriteLine("2: Dexterity increases your chance to strike your oponent and how easily you avoid attacks.");
        Console.WriteLine("3: Constitution increases your maximum HP.");
        Console.WriteLine("4: Intelligence increases your spell power and the number of spells you can cast.");
        Console.WriteLine("5: Wisdom increases your XP earned. If you are a Monk, wisdom also increases your chance to avoid attacks and strike your opponent.");
        Console.WriteLine("6: Charisma has situational benefits, as well as giving you special rates at merchants.");
        Console.WriteLine("");
        Console.WriteLine("Which stat would you like to increase? Choose carefully, stat points are lost when used.");
        Input = Console.ReadLine();
        if (Input == "1") { NewStatPoints -= 1; Player.Strength +=1;}
        if (Input == "2") { NewStatPoints -= 1; Player.Dexterity +=1;}
        if (Input == "3") { NewStatPoints -= 1; Player.Constitution +=1; if(Player.Constitution%2==0){Player.HP += 1;}}
        if (Input == "4") { NewStatPoints -= 1; Player.Intelligence +=1;}
        if (Input == "5") { NewStatPoints -= 1; Player.Wisdom +=1;}
        if (Input == "6") { NewStatPoints -= 1; Player.Charisma +=1;}
        Console.Clear();
    }
    Player.ShowStats();
    Console.WriteLine("End Demo!");
}

