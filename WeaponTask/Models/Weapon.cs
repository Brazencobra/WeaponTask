using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponTask.Models
{
    internal class Weapon
    {
        int _capacity;
        int _bulletnumber;
        int _endsecond;
        string _shootmodd;
        public int Capacity 
        {
            get => _capacity;
            set
            {
                if (value > 0)
                {
                    _capacity= value;
                };
            } 
        }
        public int BulletNumber 
        {
            get => _bulletnumber;
            set
            {
                if (value > 0 && value < Capacity)
                {
                    _bulletnumber = value;
                }
            }
             
        }
        public int EndSecond { get; set; }
        public string ShootMood { get; set; }

        public Weapon(int capacity,int bulletnumber,int endsecond,string shootmood)
        {
            Capacity= capacity;
            BulletNumber= bulletnumber;
            EndSecond= endsecond;
            ShootMood= shootmood;
        }
        public int Shoot()
        {
            if (BulletNumber > 0)
            {
                
                int shoot = BulletNumber - 1;
                BulletNumber--;
                return shoot;
            }
            else
            {
                return 0;
            }

        }
        public int Fire()
        {
            if (ShootMood == "avtomatik")
            {
                int a = BulletNumber / 5;
                return a;
            }
            else
            {

                return 0;
            }
        }
        public int GetRemainBulletCount()
        {
            return Capacity - BulletNumber;
        }
        public void ChangeFireMethod()
        {
            if (ShootMood == "tek")
            {
                ShootMood = "avtomatik";
                Console.WriteLine("Atis modunuz tekliden avtomatike cevrildi");
            }
            else if (ShootMood == "avtomatik")
            {
                ShootMood = "tek";
                Console.WriteLine("Atis modunuz avtomatikden tek moda cevrildi");
            }
        }
        public void Reload()
        {
            if (Capacity == BulletNumber)
            {
                Console.WriteLine("Sizin daraginiz tamamile doludur.Ona gore de yeniden doldurulmadi");
            }
            else
            {
                int AddBullet = Capacity- BulletNumber;
                Console.WriteLine("Sizin daraga " + AddBullet + " gulle elave edilerek " + Capacity + " oldu" );
                BulletNumber = Capacity;
            }
        }



    }
}
