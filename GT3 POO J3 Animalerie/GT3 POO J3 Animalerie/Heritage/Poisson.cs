using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Poisson : Animal
    {

        string suffixe = "le poisson";
        public Poisson(string name) : base(name)
        {
            Name = name + " " + suffixe;
            IsAlive = true;
            Paws = 0;

        }
    }
}
