using System;

namespace guns
{
    class Program
    {
        static void Main(string[] args)
        {
            fase1();
            fase2();
            fase3();
        }

        private static void title(string title)
        {
            Console.WriteLine($"\n\n---\n{title}:\n");
        }

        public static void fase1()
        {
            title("fase1");
            var soldier = new Soldier(new MachineGun());
            soldier.Attack("rebel");
        }

        public static void fase2()
        {
            title("fase2");
            var soldier = new Soldier(new MachineGun());
            soldier.Attack("rebel 1");
            soldier.AddWeapon(new HandGun());
            soldier.Attack("rebel 2");
            soldier.Attack("rebel 3");
            soldier.AddWeapon(new Rifle());
            soldier.Attack("rebel 4");
            soldier.AddWeapon(new MachineGun());
            soldier.Attack("rebel 5");
            soldier.Attack("rebel 6");
            soldier.AddWeapon(new HandGun());
            soldier.Attack("rebel 7");
        }

        public static void fase3()
        {
            title("fase3");
            var tank = new Tank(new MachineGun());
            tank.Attack("rebel 1");
            tank.AddWeapon(new HandGun());
            tank.Attack("rebel 2");
            tank.SwitchWeapon();
            tank.Attack("rebel 3");
            tank.AddWeapon(new Rifle());
            tank.SwitchWeapon();
            tank.Attack("rebel 4");
            tank.SwitchWeapon();
            tank.SwitchWeapon();
            tank.Attack("rebel 5");
        }
    }
}
