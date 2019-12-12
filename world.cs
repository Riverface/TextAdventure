using System;
using System.Collections.Generic;
using System.Numerics;

using TextAdventure.TALib;

namespace TextAdventure.MainGame
{

    public class mainworld
    {
        public static void Eategg()
        {
            
            Console.WriteLine("You eat the egg.");
            Console.WriteLine("The egg begins to consume you.");   
        }
        public static void Main()
        {
            bool game = false;
            World theworld = new World();
            game = true;
            string input = "";
            initWorld(theworld);
            Console.WriteLine("Butt");
            theworld.Look();
            while (game == true)
            {
                input = Console.ReadLine();
                switch (input.Split(' ')[0])
                {
                    case "use":
                       if (input.Split(' ').Length > 1)
                        {
                            theworld.itemSearch(input.Split(" ")[1]).UseItem();
                        }
                        else
                        {
                            theworld.Look();
                        }
                        break;
                    case "look":
                        if (input.Split(' ').Length > 1)
                        {
                            theworld.Look(theworld.itemSearch(input.Split(" ")[1]));
                        }
                        else
                        {
                            theworld.Look();
                        }
                        break;
                    case "go":
                        if (theworld.readRoom(theworld.directions[input.Split(' ')[1]] + theworld.user.position) == null)
                        {
                            Console.WriteLine("No?");
                        }
                        theworld.dirGo(input.Split(' ')[1]);
                        theworld.Look();
                        break;
                    default:
                        Console.WriteLine("What exactly does " + input + " Mean?");
                        break;
                }
            }
        }
        public static void initWorld(World activeworld)
        {
            gameAction eggeat = Eategg;
            activeworld.addRoom(new Room("Bedroom", "Your room. To your SOUTH is the door to the hallway."), new Vector3(0, 0, 0));
            Item egg = new Item("egg", new List<gameAction>() { eggeat}, "E G G", new Vector3(0, 0, 0));
            activeworld.addRoom(new Room("Hallway", "Hall leading to bathroom and downstairs"), new Vector3(0, -1, 0));

            for (int eggcount = 0; eggcount < 45; eggcount++)
            {
                switch (eggcount)
                {
                    case 0:
                        egg.description = "Some";
                        break;
                    case 1:
                        egg.description = "BODY Once told me";
                        break;
                    case 2:
                        egg.description = "The world was gonna roll me";
                        break;
                    case 3:
                        egg.description = "I ain't the sharpest tool in the shed";
                        break;
                    case 4:
                        egg.description = "She was lookin' kind of dumb with her finger and her thumb";
                        break;
                    case 5:
                        egg.description = "in the shape of an L";
                        break;
                    case 6:
                        egg.description = "On her forehead";
                        break;
                    case 7:
                        egg.description = "Well, the years start coming and they don't stop coming";
                        break;
                    case 8:
                        egg.description = "Fed to the rules and I hit the ground running";
                        break;
                    case 9:
                        egg.description = "Didn't make sense not to live for fun";
                        break;
                    case 10:
                        egg.description = "Your brain gets smart and your head gets dumb";
                        break;
                    case 11:
                        egg.description = "So much to do so much to see";
                        break;
                    case 12:
                        egg.description = "So what's wrong with taking the backstreets?";
                        break;
                    case 13:
                        egg.description = "Ya never know if ya don't go";
                        break;
                    case 14:
                        egg.description = "Ya never shine if ya don't glow";
                        break;
                    case 15:
                        egg.description = "Hey now, you're an allstar, get your game on, go play";
                        break;
                    case 16:
                        egg.description = "Hey now, you're a rockstar, get the show on, get paid";
                        break;
                    case 17:
                        egg.description = "and all that glitters is gooooold";
                        break;
                    case 18:
                        egg.description = "only shootin' stars break the mold";
                        break;
                    case 19:
                        egg.description = "It's a cool place, and they say it gets colder";
                        break;
                    case 20:
                        egg.description = "You're bundled up now wait 'till you get older";
                        break;
                    case 21:
                        egg.description = "but the meteor men beg to differ";
                        break;
                    case 22:
                        egg.description = "judging by the hole in the satelite picture";
                        break;
                    case 23:
                        egg.description = "The ice we skate is getting pretty thin";
                        break;
                    case 24:
                        egg.description = "The water's getting warm so you might as well swim";
                        break;
                    case 25:
                        egg.description = "My world's on fire, how bout yours?";
                        break;
                    case 26:
                        egg.description = "That's the way I like it and I never get bored.";
                        break;
                    case 27:
                        egg.description = "Hey now, you're an allstar, get your game on, go play";
                        break;
                    case 28:
                        egg.description = "Hey now, you're a rockstar, get the show on, get paid";
                        break;
                    case 29:
                        egg.description = "All that glitters is gold";
                        break;
                    case 30:
                        egg.description = "Only shooting stars break the mold";
                        break;
                    case 31:
                        egg.description = "Somebody once asked could I spare some change for gas?";
                        break;
                    case 32:
                        egg.description = "I need to get myself away from this place";
                        break;
                    case 33:
                        egg.description = "I said yep, what a concept, I could use a little fuel myself";
                        break;
                    case 34:
                        egg.description = "And we could all use a little change";
                        break;
                    case 35:
                        egg.description = "Well, the years start coming and they don't stop coming";
                        break;
                    case 36:
                        egg.description = "Fed to the rules and I hit the ground running";
                        break;
                    case 37:
                        egg.description = "Didn't make sense not to live for fun";
                        break;
                    case 38:
                        egg.description = "your brain gets smart but your head gets dumb";
                        break;
                    case 39:
                        egg.description = "So much to do, so much to see, so what's wrong with taking the backstreets?";
                        break;
                    case 40:
                        egg.description = "You never know if you don't go (GO!)";
                        break;
                    case 41:
                        egg.description = "Hey now, you're an allstar, get your game on, go play";
                        break;
                    case 42:
                        egg.description = "Hey now, you're a rockstar, get the show on, get paid";
                        break;
                    case 43:
                        egg.description = "All that glitters is gold";
                        break;
                    case 44:
                        egg.description = "Only shooting stars break the mold";
                        break;
                    case 45:
                        egg.description = "And all that glitters is gold";
                        break;
                    case 46:
                        egg.description = "Only shooting stars break the mold.";
                        break;
                }
                activeworld.readRoom(new Vector3(0, 0, 0)).items.Add(egg);
            }
        }
 
    }
}