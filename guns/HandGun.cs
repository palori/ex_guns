using System;

namespace guns
{
    public class HandGun : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine($"'Hand gun' hit '{target}'");
        }
    }
}