using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    class Enemy
    {
        public string Color;
        public float Speed;
        public float TurningSpeed;
        private string Name;
        public Enemy(string name, string color, float speed,float turningspeed)
        {
            Color = color;
            Speed = speed;
            TurningSpeed = turningspeed;
            Name = name;
        }
    }

    
}
