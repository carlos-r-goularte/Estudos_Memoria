using System;

namespace Exercicio_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many rooms will be rented? ");
            Console.Write(">");
            int rentedRooms = int.Parse(Console.ReadLine());

            Rooms[] rooms = new Rooms[10];

            for (int i = 0; i < rentedRooms; i++)
            {
                Console.WriteLine("Register Room " + (i + 1));
                Console.WriteLine();

                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter your e-mail: ");
                string email = Console.ReadLine();
                Console.WriteLine();

            selectRoom:
                Console.Write("Enter the room number you wish to register: ");
                int room = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (rooms[room] == null)
                {
                    rooms[room] = new Rooms(name, email);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Room already occupied");
                    Console.WriteLine();
                    goto selectRoom;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Registration completed successfully");
            Console.WriteLine();

            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine("Quarto: #" + i + " || " + rooms[i]);
                }
            }
        }
    }
}
