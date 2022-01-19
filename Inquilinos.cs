using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeFixacao71
{
    class Inquilinos
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Inquilinos()
        {
        }

        public Inquilinos(string name, string email, int room)
        {
            Name = name;
            Email = email;
            Room = room;
        }
    }
}
