using System;
using Ninja.Intefaces;

namespace Ninja.Model.Weapon
{
    public class Katana : IWeapon
    {
        public string DeliberateAttack()
        {
            return "He knew it was coming but he couldn't do anything about it.";
        }

        public string DeadlyAttack()
        {
            return "Would you have a slice of your torso?";
        }

        public string SwiftAttack()
        {
            return "There's no sign of suprise in his face as his head rolls on the floor.";
        }
    }
}