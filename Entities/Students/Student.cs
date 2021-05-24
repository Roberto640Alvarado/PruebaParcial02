using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo07.Entities.Students
{
    class Student
    {
        public int Id { get; set; }
        public string Carnet { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string  Career{ get; set; }
        public virtual string FullName => $"{Name} {LastName}";
    }
}
