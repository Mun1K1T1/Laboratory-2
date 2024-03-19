using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_2.Models
{
    internal class Person
    {
        public string _id;
        public string _firstName;
        public string _secondName;

        public virtual string Id { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string SecondName { get; set; }

       public Person(string id, string firstName,  string secondName)
        {
            _id = id;
            _firstName = firstName;
            _secondName = secondName;
        }
    }
}
