using System.Collections.Generic;
using System.Numerics;
using System;
namespace TextAdventure.TALib
{
    public delegate void gameAction();
    public class World
    {
        public Dictionary<Vector3, Room> placegrid;
        public static Dictionary<String, Vector3> cardinals = new Dictionary<string, Vector3>(){
            { "north", new Vector3 (0, 1, 0) },
            { "south", new Vector3 (0, -1, 0) },
            { "west", new Vector3 (-1, 0, 0) },
            { "east", new Vector3 (1, 0, 0) },
            { "up", new Vector3 (0, 0, 1) },
            { "down", new Vector3 (0, 0, -1) },
            { "northwest", new Vector3 (-1, 1, 0) },
            { "northeast", new Vector3 (1, 1, 0) },
            { "southwest", new Vector3 (-1, -1, 0) },
            { "southeast", new Vector3 (1, -1, 0) }
        };
        public Dictionary<String, Vector3> directions = cardinals;
        public Player user = new Player();
        public World()
        {
            placegrid = new Dictionary<Vector3, Room>();
            user.position = new Vector3(0, 0, 0);
        }
        public Room readRoom(Vector3 position)
        {
            return placegrid[position];
        }
        public Item itemSearch(string term){
        Item founditem = null;
        foreach(Item found in readRoom(user.position).items){
            if(term == found.name || term == found.shorthand){
                founditem = found;
            }

        }
        return founditem;
        }
        public void addRoom(Room tobeadded, Vector3 Position)
        {
            placegrid.Add(Position, tobeadded);
        }
        public void dirGo(string direction)
        {
            user.position += directions[direction];
        }
        public void Look()
        {
            Console.WriteLine(readRoom(user.position).description);
        }
        public void Look(Item lookedat)
        {
            if (lookedat.pos == user.position)
            {
                Console.WriteLine(lookedat.description);
            }
            else
            {
                Console.WriteLine("Sorry nothing");
            }
        }
        void Move(string moveExit)
        {
            user.position = user.position + directions[moveExit];
        }

    }
    public class Room
    {
        public string Name;
        public string description;
        public List<Item> items;
        public Room(string name, string desc)
        {
            description = desc;
            Name = name;
            items = new List<Item>();
        }
        public Room()
        {

        }
    }
    public class Item
    {

        public static List<gameAction> actions;
        public string description;
        public Vector3 pos;
        public bool inInventory;
        public bool canbetaken;
        public string shorthand;
        public string name;
        public Item(string Name, List<gameAction> Actions, string description, Vector3 initpos)
        {
            name = Name;            
            Vector3 pos = initpos;
            actions = Actions;
            shorthand = name.Split(' ').ToString();
        }
        public Item()
        {

        }

        public void UseItem()
        {
            Console.WriteLine(actions);
            foreach (gameAction action in actions)
            {
                action();
            }
        }
    }


    public class Player
    {
        public Vector3 position;
        public List<Item> inventory = new List<Item>();
        public Player()
        {
            position = new Vector3(0, 0, 0);
        }

        public void TakeItem(Item taken)
        {
            if (taken.pos == this.position)
            {

                if (taken.canbetaken)
                {
                    inventory.Add(taken);
                    taken = null;
                }
            }
        }
    }
}