using Ninja.Intefaces;
using Ninja.Model.Weapon;

namespace Ninja.Model
{
    public class Ninja : INinja
    {
        public IWeapon CurrentWeapon { get; private set; }

        public Ninja()
        {
            //Better. Might add some validation logic latter, like weight limits...
            ChangeWeapon(new EmptyHands());
        }

        public void ChangeWeapon(IWeapon weapon)
        {   
            CurrentWeapon = weapon;
        }

        public void DeliberateAttack()
        {
            CurrentWeapon.DeliberateAttack();
        }

        public void SwiftAttack()
        {
            CurrentWeapon.SwiftAttack();
        }
    }
}