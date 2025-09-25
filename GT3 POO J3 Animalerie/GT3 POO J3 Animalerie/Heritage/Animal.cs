using System.Windows.Markup;
using System.Xml.Linq;

namespace TU_Challenge.Heritage
{

    public class Animal
    {
        public Animal(string name)
        {
            this.name = name;
        }
        bool isAlive;

        int paws;

        string name;

        string shot = "";




        public int Paws {  get { return paws; } set { paws = value; } }

        public bool IsAlive { get { return isAlive; } set { isAlive = value; } }

        public string Name
        {
            get { return name; }
        }

        public string Shot
        {
            set { shot = value; }
            get { return shot; }
        }



        public virtual string Crier() { return ""; }

        public event Action? OnDie;


        public void Die() 
        {

            IsAlive = false;
            OnDie?.Invoke();
        }

    }
}
