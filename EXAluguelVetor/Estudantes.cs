using System;
using System.Collections.Generic;
using System.Text;

namespace EXAluguelVetor
{
    class Estudantes
    {
        private string Name { get; set; }
        private string Email { get; set; }

        public Estudantes (string name, string email)
        {
            Name = name;
            Email = email;
        }
        public override string ToString()
        {
            return Name + "," + Email;
        }
    }
}
