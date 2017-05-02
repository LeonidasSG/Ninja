using Ninja.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja.Model
{
    class SuperNinja : Ninja, ISuperWeapon, ISuperNinja
    {
        public ISuperWeapon SuperWeapon { get; private set; }
        public SuperNinja() : base () 
        {
            this.SuperWeapon = (ISuperWeapon)base.CurrentWeapon;
        }

        public void ChangeWeapon(ISuperWeapon weapon)
        {
            this.SuperWeapon = weapon;
        }

        public void SuperAttack()
        {
            this.SuperWeapon.SuperAttack();
        }
    }
}
