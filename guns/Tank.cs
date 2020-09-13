using System;
using System.Collections.Generic;

namespace guns
{
    class Tank
    {

        public readonly List<IWeapon> weapons = new List<IWeapon>(); // why readonly in the example?
        public int activeWeapon;
        public Tank(IWeapon weapon)
        {
            this.AddWeapon(weapon);
            this.activeWeapon = 0;
        }
        public void Attack(string target)
        {
            this.weapons[activeWeapon].Hit(target);
        }
        public void AddWeapon(IWeapon weapon)
        {
            this.weapons.Add(weapon);
        }
        public void SwitchWeapon()
        {
            this.activeWeapon = this.activeWeapon < this.weapons.Count-1 ? this.activeWeapon+1 : 0;
        }
    }
}