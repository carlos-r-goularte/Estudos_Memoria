using System;


namespace Exercicio_Vetores
{
    class Rooms
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Rooms(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return
                 "Name: " + Name + " || E-mail: " + Email;
        }
    }
}
