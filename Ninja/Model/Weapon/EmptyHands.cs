using System;
using Ninja.Intefaces;

namespace Ninja.Model.Weapon
{
    public class EmptyHands : IWeapon
    {
        public string DeliberateAttack()
        {
            return "It is called null object.";
        }

        public string DeadlyAttack()
        {
            return "There goes a dynamite with my bare hands!";
        }

        public string SwiftAttack()
        {
            return "Google Null Object pattern.";
        }
    }
}