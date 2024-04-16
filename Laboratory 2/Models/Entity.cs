using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_2.Models
{
    internal class Entity
    {
        public int Id { get; set; }
        virtual public string Path { get; set; }

        public Entity(int id, string path)
        {
            Id = id;
            Path = path;
        }
    }
}
