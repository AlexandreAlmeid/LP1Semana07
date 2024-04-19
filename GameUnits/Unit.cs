using System;

namespace GameUnits
{
    //Classe abstrata porque será uma classe a ser implementada pelas suas subclasses especializadas.
    public abstract class Unit
    {
        private int movement;

        public abstract float Cost { get;}
        //Parâmetro virtual porque pode ser sobreposto nas suas subclasses.
        public virtual int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            Console.WriteLine(this.movement);
        }
    }
}
