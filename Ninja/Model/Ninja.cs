using Ninja.Intefaces;
using Ninja.Model.Weapon;

namespace Ninja.Model
{
    public class Ninja : INinja
    {
        protected IWeapon CurrentWeapon { get; private set; }
        protected IOutput Output { get; private set; }

        public Ninja(IOutput output)
        {
            Output = output;

            //Better. Might add some validation logic latter, like weight limits...
            ChangeWeapon(new EmptyHands());
        }

        public INinja ChangeWeapon(IWeapon weapon)
        {   
            CurrentWeapon = weapon;
            Output.Dump($"Ninja switched to the weapon {weapon.GetType().Name}");
            return this;
        }

        public INinja DeliberateAttack()
        {
            Output.Dump(CurrentWeapon.DeliberateAttack());
            return  this;
        }

        public INinja SwiftAttack()
        {
            Output.Dump(CurrentWeapon.SwiftAttack());
            return  this;
        }
    }
}