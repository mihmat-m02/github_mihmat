﻿using System;
using System.Collections.Generic;
using System.Text;

namespace github_mihmat
{
    class Person
    {
        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

    }
}
