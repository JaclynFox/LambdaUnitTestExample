using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaUnitTestExample
{
    public enum Condition : int
    {
        LEMON = 0,
        BAD = 1,
        FAIR = 2,
        GOOD = 3,
        EXCELLENT = 4
    }
    public class Car
    {
        private Condition _condition;
        private int _speed;
        private string _make;
        public Condition Condition { get => _condition; set => _condition = value; }
        public int Speed { get => _speed; set => _speed = SetSpeed(value); }
        public string Make { get => _make; set => _make = value; }
        public Car(string m, Condition c)
        {
            Make = m;
            Condition = c;
            Speed = 0;
        }
        public int SetSpeed(int s)
        {
            int r = s % 5;
            return s - r;
        }
    }
}
