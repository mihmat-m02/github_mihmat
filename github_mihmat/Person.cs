using System;
using System.Collections.Generic;
using System.Text;

namespace github_mihmat
{
    class Person
    {
        public Person(string first, string last)
        {
            Firstname = first;
            Lastname = last;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

    }
}
