using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Pokemon
{
    class Characters
    {
        public Info info { get; set; }
        public List<Character> results { get; set; }
    }
    public class Character
    {
        public int id { get; set; }
        public string name { get; set; }
        public double weight { get; set; }
        public double height { get; set; }
        public string front_default { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class Info
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public string prev { get; set; }
    }

}
