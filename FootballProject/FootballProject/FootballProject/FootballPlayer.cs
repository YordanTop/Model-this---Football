using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballProject
{
    internal class FootballPlayer : Person
    {
        public int Number { get; private set; }

        public float Height { get; private set; }
        public FootballPlayer(string name, int age, int number, float height ) : base(name, age)
        {
            Number = number;
            Height = height;   
        }
    }
}
