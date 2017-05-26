namespace Ninja.Intefaces
{
    public interface INinja
    {
        INinja ChangeWeapon(IWeapon weapon);
        INinja DeliberateAttack();
        INinja SwiftAttack();
    }
}