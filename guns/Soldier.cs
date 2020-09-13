using System;
using System.Collections.Generic;

namespace guns
{
    class Soldier
    {

        public IWeapon weapon; // why readonly in the example?
        public Soldier(IWeapon weapon)
        {
            this.weapon = weapon;
            this.AddWeapon(weapon);
        }
        public void Attack(string target)
        {
            this.weapon.Hit(target);
        }
        public void AddWeapon(IWeapon weapon)
        {
            this.weapon = weapon;
        }
    }
}