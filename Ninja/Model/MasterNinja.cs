using Ninja.Intefaces;

namespace Ninja.Model
{
    public class MasterNinja : Ninja, IMasterNinja
    {
        public void DeadlyAttack()
        {
            this.CurrentWeapon.DeadlyAttack();
        }
    }
}
