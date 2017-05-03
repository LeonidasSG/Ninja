using Ninja.Intefaces;
using Ninja.Model;
using Ninja.Model.Weapon;

namespace Ninja
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            INinja ninja = new Model.Ninja();

            ninja.ChangeWeapon(new Katana());
            ninja.DeliberateAttack();
            ninja.SwiftAttack();

            ninja.ChangeWeapon(new Shuriken());
            ninja.DeliberateAttack();
            ninja.SwiftAttack();

            IMasterNinja masterNinja = new MasterNinja();
            masterNinja.DeadlyAttack();

            masterNinja.ChangeWeapon(new Katana());
            masterNinja.DeadlyAttack();

            masterNinja.ChangeWeapon(new Shuriken());
            masterNinja.DeadlyAttack();

        }
    }
}