using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja.Intefaces
{
    interface ISuperNinja : INinja
    {
        void SuperAttack();

        void ChangeWeapon(ISuperWeapon weapon);

    }
}
