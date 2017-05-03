using Ninja.Intefaces;
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

            ISuperNinja superNinja = new Model.MasterNinja();
            superNinja.DeadlyAttack();

            superNinja.ChangeWeapon(new Katana());
            superNinja.DeadlyAttack();

            superNinja.ChangeWeapon(new Shuriken());
            superNinja.DeadlyAttack();

        }
    }
}