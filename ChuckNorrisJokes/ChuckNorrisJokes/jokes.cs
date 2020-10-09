using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisJokes
{
    class jokes
    {
        public class AllJokes
        {
            public List<ResultObject> results { get; set; }
        }

        public class ResultObject
        {
            public string catagories { get; set; }

            public string url { get; set; }

            public override string ToString()
            {
                return catagories;
            }
        }

        public class RandomJoke
        {
            public string value { get; set; }

            public override string ToString()
            {
                string joke = $"{value}";
                return joke;
            }
        }



    }
}
