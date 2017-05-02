using System;
using Ninja.Intefaces;

namespace Ninja.Model.Weapon
{
    public class Shuriken : IWeapon, ISuperWeapon
    {
        public void DeliberateAttack()
        {
            Console.WriteLine("Carefully aiming... Bullseye!");
        }

        public void SuperAttack()
        {
            Console.WriteLine("Fuck you! ... Rest in pieces!");
        }

        public void SwiftAttack()
        {
            Console.WriteLine("Quick draw! ...And one missed");
        }
    }
}