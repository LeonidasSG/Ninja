using Ninja.Intefaces;
using Ninja.Model;
using Ninja.Model.Weapon;
using Ninja.UI;

namespace Ninja
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            INinja ninja = new Model.Ninja(new Output());

            ninja.ChangeWeapon(new Katana())
                .DeliberateAttack()
                .SwiftAttack()
                .ChangeWeapon(new Shuriken())
                .DeliberateAttack()
                .SwiftAttack();

            IMasterNinja masterNinja = new MasterNinja(new Output());
            masterNinja.DeadlyAttack();

            masterNinja.ChangeWeapon(new Katana());
            masterNinja.DeadlyAttack();

            masterNinja.ChangeWeapon(new Shuriken());
            masterNinja.DeadlyAttack();

        }
    }
}