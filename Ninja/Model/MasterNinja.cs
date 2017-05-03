using Ninja.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja.Model
{
    class MasterNinja : Ninja, ISuperNinja
    {
        public MasterNinja() : base () 
        {

        }


        public void DeadlyAttack()
        {
            this.CurrentWeapon.DeadlyAttack();
        }
    }
}
