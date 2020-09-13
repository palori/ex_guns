using System;

namespace guns
{
    public class Rifle : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine($"'Rifle' hit '{target}'");
        }
    }
}