using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Classroom
    {
        public String name;
        Person[] persons;

        public Classroom(string name, Person[] persons)
        {
            this.name = name;
            this.persons = persons;
        }

    }
}
