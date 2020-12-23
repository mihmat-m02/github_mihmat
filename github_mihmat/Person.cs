using System;
using System.Collections.Generic;
using System.Text;

namespace github_mihmat
{
    class Person
    {
        public Person(string fn, string ln)
        {
            Firstname = fn;
            Lastname = ln;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

    }
}
