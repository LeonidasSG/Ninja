using System;
using Ninja.Intefaces;

namespace Ninja.Model.Weapon
{
    public class Katana : IWeapon, ISuperWeapon
    {
        public void DeliberateAttack()
        {
            Console.WriteLine("He knew it was coming but he couldn't do anything about it.");
        }

        public void SuperAttack()
        {
            Console.WriteLine("Would you have a slice of your torso?");
        }

        public void SwiftAttack()
        {
            Console.WriteLine("There's no sign of suprise in his face as his head rolls on the floor.");
        }
    }
}