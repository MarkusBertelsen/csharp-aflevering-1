using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Aflevering
{
    class User
    {
        public int id { get; }
        public string name { get; }
        public int age { get; }
        public int score { get; }

        public User(int id, string name, int age, int score)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.score = score;
        }

        public override string ToString()
        {
            return name + ", id: " + id;
        }
    }
}
