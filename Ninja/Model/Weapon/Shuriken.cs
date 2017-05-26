using System;
using Ninja.Intefaces;

namespace Ninja.Model.Weapon
{
    public class Shuriken : IWeapon
    {
        public string DeliberateAttack()
        {
            return "Carefully aiming... Bullseye!";
        }

        public string DeadlyAttack()
        {
            return "Fuck you! ... Rest in pieces!";
        }

        public string SwiftAttack()
        {
            return "Quick draw! ...And one missed";
        }
    }
}