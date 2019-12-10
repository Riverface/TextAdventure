    using System;
    using System.Collections.Generic;
    namespace TextAdventure.TALib {
        public delegate void gameAction(); 
        public class World {
            public static Room[] places = new Room[255];
        }
        public class Room {
            static string Name;
            static string description;
            public Room (string Name, string desc, int id) {
                
            }
            public Room () {

            }
        }
        public class Item {
              
            public static List<gameAction> actions = new List<gameAction>();
            public string description;
            public Item (string name, List<gameAction> actions, string description) {

            }
            public Item () {

            }

            void UseItem () {
                foreach (gameAction action in actions) {

                }
            }
        }
            public class Exit {
                public bool blocked;
                public string blockreason;
                public Room toRoom;
                public Exit () {

                }
                public Exit (string name, string description, Room toRoom) {

                }
            }

            public class Player {
                public Room position;
                public List<Item> inventory = new List<Item>();
                Player () {

                }
                void RoomGo (Exit going) {
                    if (!going.blocked) {
                        this.position = going.toRoom;
                    } else {
                        Console.WriteLine (going.blockreason);
                    }
                }
                public Room pos(){
                
                }
                public void TakeItem (Item taken) {
                    if(taken.canbetaken){
                    this.inventory.Add(taken);
                    this.pos().inventory.Remove(taken);
                    }
                }
            }
    }