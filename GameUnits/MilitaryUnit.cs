namespace GameUnits
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }
        public override int Health { get {return base.Health + XP;}}
        public override float Cost { get {return AttackPower + XP;}}

        public MilitaryUnit(int movement, int health, int attackPower) : base(movement, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }
        public void Attack(Unit u)
        {
            this.XP++;
            u.Health -= this.AttackPower;
        }
    }
}
