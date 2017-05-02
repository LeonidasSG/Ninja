using System;
using Ninja.Intefaces;

namespace Ninja.Model.Weapon
{
    public class EmptyHands : IWeapon, ISuperWeapon
    {
        public void DeliberateAttack()
        {
            Console.WriteLine("It is called null object.");
        }

        public void SuperAttack()
        {
            Console.WriteLine("There goes a dynamite with my bare hands!");
        }

        public void SwiftAttack()
        {
            Console.WriteLine("Google Null Object pattern.");
        }
    }
}