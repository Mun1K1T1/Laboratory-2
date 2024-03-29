using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_2.Models
{
    public abstract class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }


        public Person(string id, string firstName,  string secondName)
        {
            Id = id;
            FirstName = firstName;
            SecondName = secondName;
        }
    }
}
