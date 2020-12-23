using System;
using System.Collections.Generic;
using System.Text;

namespace github_mihmat
{
    class Person
    {
        public Person(string firstn, string lastn)
        {
            Firstname = firstn;
            Lastname = lastn;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

    }
}
