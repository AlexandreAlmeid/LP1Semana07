using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnit soldier = new MilitaryUnit(10, 100, 20);
            SettlerUnit settler = new SettlerUnit();

            soldier.Move();
            settler.Move();

            Console.WriteLine($"soldier stats: {soldier.Health} {soldier.Cost}");
            Console.WriteLine($"settler stats: {settler.Health} {settler.Cost}");
        }
    }
}
