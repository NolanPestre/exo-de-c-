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
