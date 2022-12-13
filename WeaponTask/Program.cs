using WeaponTask.Models;

namespace WeaponTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Silahinizin daraginin tuta bileceyi maximum gulle sayini daxil edin : ");
            int capacity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Silahinizin daraginda olan gullelerin sayini daxil edin : ");
            int bulletnum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Silahinizin daraginin bosalma saniyesini daxil edin : ");
            int endsec = Convert.ToInt32(Console.ReadLine());
            Console.Write("Silahinizin moodunu daxil edin (tek || avtomatik) : ");
            string mood = Convert.ToString(Console.ReadLine());
            Weapon weapon = new Weapon(capacity, bulletnum, endsec, mood);


            bool repeat = true;
            do
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Informasiya almaq ucun 0 daxil edin ");
                byte input1 = Convert.ToByte(Console.ReadLine());
                if (input1 == 0)
                {
                    Console.WriteLine("1 - Shoot metodu ucun \n2 - Fire metodu ucun\n3 - GetRemainBulletCount metodu ucun\n4 - Reload metodu ucun\n" +
                    "5 - ChangeFireMode metodu ucun\n6 - Proqramdan dayandırmaq ucun");
                    byte input = Convert.ToByte(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            if (weapon.Capacity > 0)
                            {
                                Console.WriteLine("Silahinizdan 1 el ates olundu geride qalan gulle sayiniz : " + weapon.Shoot() );
                            }
                            else
                            {
                                Console.WriteLine("Daragda gulle olmadigi ucun ates acilmadi,Reload edin\"");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Silahinizin butun gulleleri atesleme muddeti " + weapon.Fire());
                            break;
                        case 3:
                            Console.WriteLine("Silahinizin daraginda " + weapon.BulletNumber + " gulle var ve tam dolmasi ucun " + weapon.GetRemainBulletCount() + " gulle lazimdir");
                            break;
                        case 4:
                            weapon.Reload();
                            break;
                        case 5:
                            weapon.ChangeFireMethod();
                            break;
                        case 6:
                            repeat = false ;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("0 daxil etmeyiniz xahis olunur");
                }

            } while (repeat);

        
            


        }
    }
}