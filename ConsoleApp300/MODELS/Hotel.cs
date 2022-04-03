using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp300.MODELS
{
    class Hotel
    {
        public string Name { get; set; }

        private Room[] Rooms = new Room[0];

        public Hotel( string Name)
        {
            this.Name = Name;
        }

        public void AddRoom(Room room)
        {
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[Rooms.Length - 1] = room;
        }
        public void Reserve(int? roomID)
        {
            for (int i = 0; i < Rooms.Length; i++)
            {
                if (Rooms[i].ID == roomID)
                {
                    if (Rooms[i].IsAvailable)
                    {
                        Console.WriteLine($"{Rooms[i].Name} The room has been reserved!");
                        Rooms[i].IsAvailable = false;
                        break;
                    }
                    else throw new NotAvailableException();
                }
                else if (Rooms[i].ID != roomID && i == Rooms.Length - 1) { throw new NotFoundException(); }
            }
        }

        public Room this[int index]
        {
            get
            {
                return Rooms[index];
            }
            set
            {
                Rooms[index] = value;
            }
        }
    }
}
