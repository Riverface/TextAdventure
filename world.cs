using System;
using System.Collections.Generic;
using System.Numerics;
using TextAdventure.TALib;

namespace TextAdventure.MainGame
{

    public class mainworld
    {
        
        public static void eggmsg(int eggcount)
        {
            Console.WriteLine("You eat the egg.");
            Console.WriteLine("The egg begins to consume you.");
            Console.WriteLine("A voice rings out in your head.");
            switch (eggcount)
            {
                case 0:
                    Console.WriteLine("Some");
                    break;
                case 1:
                    Console.WriteLine("BODY Once told me");
                    break;
                case 2:
                    Console.WriteLine("The world was gonna roll me");
                    break;
                case 3:
                    Console.WriteLine("I ain't the sharpest tool in the shed");
                    break;
                case 4:
                    Console.WriteLine("She was lookin' kind of dumb with her finger and her thumb");
                    break;
                case 5:
                    Console.WriteLine("in the shape of an L");
                    break;
                case 6:
                    Console.WriteLine("On her forehead");
                    break;
                case 7:
                    Console.WriteLine("Well, the years start coming and they don't stop coming");
                    break;
                case 8:
                    Console.WriteLine("Fed to the rules and I hit the ground running");
                    break;
                case 9:
                    Console.WriteLine("Didn't make sense not to live for fun");
                    break;
                case 10:
                    Console.WriteLine("Your brain gets smart and your head gets dumb");
                    break;
                case 11:
                    Console.WriteLine("So much to do so much to see");
                    break;
                case 12:
                    Console.WriteLine("So what's wrong with taking the backstreets?");
                    break;
                case 13:
                    Console.WriteLine("Ya never know if ya don't go");
                    break;
                case 14:
                    Console.WriteLine("Ya never shine if ya don't glow");
                    break;
                case 15:
                    Console.WriteLine("Hey now, you're an allstar, get your game on, go play");
                    break;
                case 16:
                    Console.WriteLine("Hey now, you're a rockstar, get the show on, get paid");
                    break;
                case 17:
                    Console.WriteLine("and all that glitters is gooooold");
                    break;
                case 18:
                    Console.WriteLine("only shootin' stars break the mold");
                    break;
                case 19:
                    Console.WriteLine("It's a cool place, and they say it gets colder");
                    break;
                case 20:
                    Console.WriteLine("You're bundled up now wait 'till you get older");
                    break;
                case 21:
                    Console.WriteLine("but the meteor men beg to differ");
                    break;
                case 22:
                    Console.WriteLine("judging by the hole in the satelite picture");
                    break;
                case 23:
                    Console.WriteLine("The ice we skate is getting pretty thin");
                    break;
                case 24:
                    Console.WriteLine("The water's getting warm so you might as well swim");
                    break;
                case 25:
                    Console.WriteLine("My world's on fire, how bout yours?");
                    break;
                case 26:
                    Console.WriteLine("That's the way I like it and I never get bored.");
                    break;
                case 27:
                    Console.WriteLine("Hey now, you're an allstar, get your game on, go play");
                    break;
                case 28:
                    Console.WriteLine("Hey now, you're a rockstar, get the show on, get paid");
                    break;
                case 29:
                    Console.WriteLine("All that glitters is gold");
                    break;
                case 30:
                    Console.WriteLine("Only shooting stars break the mold");
                    break;
                case 31:
                    Console.WriteLine("Somebody once asked could I spare some change for gas?");
                    break;
                case 32:
                    Console.WriteLine("I need to get myself away from this place");
                    break;
                case 33:
                    Console.WriteLine("I said yep, what a concept, I could use a little fuel myself");
                    break;
                case 34:
                    Console.WriteLine("And we could all use a little change");
                    break;
                case 35:
                    Console.WriteLine("Well, the years start coming and they don't stop coming");
                    break;
                case 36:
                    Console.WriteLine("Fed to the rules and I hit the ground running");
                    break;
                case 37:
                    Console.WriteLine("Didn't make sense not to live for fun");
                    break;
                case 38:
                    Console.WriteLine("your brain gets smart but your head gets dumb");
                    break;
                case 39:
                    Console.WriteLine("So much to do, so much to see, so what's wrong with taking the backstreets?");
                    break;
                case 40:
                    Console.WriteLine("You never know if you don't go (GO!)");
                    break;
                case 41:
                    Console.WriteLine("Hey now, you're an allstar, get your game on, go play");
                    break;
                case 42:
                    Console.WriteLine("Hey now, you're a rockstar, get the show on, get paid");
                    break;
                case 43:
                    Console.WriteLine("All that glitters is gold");
                    break;
                case 44:
                    Console.WriteLine("Only shooting stars break the mold");
                    break;
                case 45:
                    Console.WriteLine("And all that glitters is gold");
                    break;
                case 46:
                    Console.WriteLine("Only shooting stars break the mold.");
                    Console.WriteLine("You vomit and collapse on the floor, bile leaking from every orifice. You have done it. You ate the eggs.");
                    Console.WriteLine("It's finally over. YOU are finally over.");
                    Console.WriteLine("Good end?");
                    break;

            }
        }
        public static void Main()
        {
            bool game = false;
            World theworld = new World();
            game = true;
            string input = "";
            initWorld(theworld);
            Console.WriteLine("Today is the day. You've been training for weeks, binging and purging and expanding your palate to finally support the endeavor that will follow. Your objective will be clear soon.");
            theworld.Look();
            
            while (game == true)
            {
                input = Console.ReadLine();
                switch (input.Split(' ')[0])
                {
                    case "use":
                        if (input.Split(' ').Length > 1)
                        {
                            if(theworld.readRoom(theworld.user.position).items.Contains(theworld.itemSearch(input.Split(' ')[1]))){
                            theworld.itemSearch(input.Split(" ")[1]).UseItem();
                            }
                            if(theworld.user.inventory.Contains(theworld.itemSearch(input.Split(' ')[1]))){
                            theworld.itemSearch(input.Split(" ")[1]).UseItem();
                            }
                        }
                        else
                        {
                            theworld.Look();
                        }
                        break;
                    case "look":

                        if (input == "look inventory")
                        {
                            foreach (Item thing in theworld.user.inventory)
                            {
                                Console.WriteLine(thing.name + " (" + thing.description + ")");
                            }
                        }

                        else
                        {
                            if (input.Split(' ').Length == 1)
                            {
                                theworld.Look();
                            }
                            else
                            {

                                theworld.Look(theworld.itemSearch(input.Split(' ')[1]));
                                foreach (Item thing in theworld.readRoom(theworld.user.position).items)
                                {
                                    Console.WriteLine(thing.name + " (" + thing.description + ")");
                                }
                            }
                        }



                        break;
                    case "go":
                        if (theworld.directions.ContainsKey(input.Split(' ')[1]))
                        {
                          
                            if (theworld.placegrid.ContainsKey(theworld.user.position + theworld.directions[input.Split(' ')[1]]))
                            {
                          
                                theworld.dirGo(input.Split(' ')[1], theworld.readRoom(theworld.user.position));
                                theworld.Look();
                            }
                            else
                            {
                                Console.WriteLine("No?");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No?");
                        }
                        break;
                    case "take":
                    Item thingtaken = new Item();
                        foreach (Item curitem in theworld.readRoom(theworld.user.position).items)
                        {
                            if (curitem.name == input.Split(' ')[1] || curitem.shorthand == input.Split(' ')[1])
                            {
                                Console.WriteLine("Took " + curitem.name);
                                
                                theworld.TakeItem(curitem);
                                thingtaken = curitem;
                                foreach(Item logitem in theworld.user.inventory){
                                    Console.WriteLine(logitem.name);
                                }
                            }

                        }
                        theworld.placegrid[theworld.user.position].items.Remove(thingtaken);
                        break;
                    default:
                        Console.WriteLine("What exactly does " + input + " Mean?");
                        break;
                }
            }
        }
        public void Destroy()
        {

        }


        public static void initWorld(World activeworld)
        {
            int eggcount = 0;

            gameAction eggeat = ()=>{
            eggmsg(eggcount);
            eggcount++;
            };
            Room bedroom = new Room("bedroom", "Your room.");
            bedroom.exits.Add("south", true);
            bedroom.exits.Add("west", false);
            bedroom.blockreasons.Add("south", "You locked yourself into your room in your...Training. The key is in this room somewhere.");
            Item bdrLock = new Item("Lock", "the lock to your bedroom door.", new Vector3(0, 0, 0), false);
            bedroom.items.Add(bdrLock);
            gameAction unlocker = () =>
            {
                if (activeworld.user.position == new Vector3(0, 0, 0))
                {
                    activeworld.readRoom(new Vector3(0, 0, 0)).exits["south"] = false;        
                    Console.WriteLine("you simply can't contain yourself any longer. You have to go through with it. You turn the key in the lock.");
                }
                else
                {
                    Console.WriteLine("Wrong room.");
                }
            };
            Item doorkey = new Item("Key", "The bedroom door key", new Vector3(-1, 0, 0), true);
            doorkey.actions.Add(unlocker);
            activeworld.addRoom(bedroom, new Vector3(0, 0, 0));
            Room hallway = new Room("Hallway", "Hall with a stairway leading downstairs. Long and dark.");
            hallway.exits.Add("down", false);
            activeworld.addRoom(hallway, new Vector3(0, -1, 0));

            Room bathroom = new Room("Bathroom", "The bathroom. A toilet, a sink, and a shower are here. In the toilet is your Bedroom Key covered in vomit.");
            bathroom.items.Add(doorkey);
            bathroom.exits.Add("east", false);
            activeworld.addRoom(bathroom, new Vector3(-1, 0, 0));
            Room livingroom = new Room("Living Room", "Your living room. In it is an ungodly large bowl of raw eggs. For the sake of the children, you must eat all of them. You have trained for this day.");
            activeworld.addRoom(livingroom, new Vector3(0, -1, -1));
            Item egg = new Item("egg", "E G G", new Vector3(0, -1, -1), false);
            gameAction removeEgg = () =>
            {
                activeworld.readRoom(activeworld.user.position).items.Remove(egg);
            };
            egg.actions.Add(eggeat);
            egg.actions.Add(removeEgg);
            for (int eggcount2 = 0; eggcount2 < 47; eggcount2++)
            {
                activeworld.readRoom(new Vector3(0, -1, -1)).items.Add(egg);
            }
            
        }
    }

}
