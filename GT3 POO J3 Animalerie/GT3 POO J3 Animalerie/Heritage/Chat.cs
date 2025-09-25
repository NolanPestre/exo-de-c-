using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Chat : Animal
    {


        public Chat(string name) : base(name)
        {
            Shot = "Miaou (j'ai faim)";
            IsAlive = true;
            Paws = 4;

        }

        public override string Crier()
        {
            return this.Shot;
        }

    }
}
