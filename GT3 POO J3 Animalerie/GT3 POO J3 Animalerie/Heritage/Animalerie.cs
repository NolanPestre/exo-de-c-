using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Animalerie
    {

        public Action<Animal>? OnAddAnimal;



        List<Animal> animals = new();

       public void AddAnimal(Animal a)
        {
            animals.Add(a);

            OnAddAnimal?.Invoke(a);

            if (a is Chat && a is not ChatQuiBoite)
            {
                for (int i = 0; i < animals.Count; i++)
                {
                    if (animals[i] is Poisson)
                    {
                        animals[i].IsAlive = false;
                        a.Shot = "Miaou (Le poisson etait bon)";
                    }
                }
            }
            if (a is Poisson)
            {
                for (int i = 0; i < animals.Count; i++)
                {
                    if (animals[i] is Chat)
                    {
                        if (animals[i] is not ChatQuiBoite)
                        {
                            a.IsAlive = false;
                            animals[i].Shot = "Miaou (Le poisson etait bon)";
                        }
                    }
                }
            }

        }

        public bool Contains(Animal c) 
        {
            if (animals.Contains(c)) return true;
            return false; 
        
        }

        public Animal GetAnimal(int a)
        {
            if (a < animals.Count) return animals[a];
            throw new IndexOutOfRangeException();
        }

        public void FeedAll()
        {
            foreach (Animal a in animals) {
                if (a is Chat)
                {
                    a.Shot = "Miaou (c'est bon laisse moi tranquille humain)";
                }

                if (a is Chien)
                {
                    a.Shot = "Ouaf (viens on joue ?)";
                }

            }
        }



    }
}
