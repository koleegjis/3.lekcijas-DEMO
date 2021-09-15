using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.lekcijas_DEMO
{
    public class Person
    {
        public string Name { get; set; }

        private int _age;
        public int Age
        {
            get 
            {
                return _age;
            }
            set 
            {
                _age = Math.Abs(value);
            }
        }

        public double Money { get; set; }

        public bool IsMale { get; set; }

        public char Initial { get; set; }

        public string GetGreeting()
        {
            string greeting = "Hello, my name is " + Name + "and I am " + Age + "years old";
        
            return greeting;

        }


    }
}
