using Ninja.Intefaces;
using Ninja.UI;

namespace Ninja.Model
{
    public class MasterNinja : Ninja, IMasterNinja
    {
        public MasterNinja(IOutput output) :base(output) { }

        public IMasterNinja DeadlyAttack()
        {
            Output.Dump(this.CurrentWeapon.DeadlyAttack());
            return this;
        }
    }
}
