using System;

namespace guns
{
    public class MachineGun : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine($"'Machine gun' hit '{target}'");
        }
    }
}