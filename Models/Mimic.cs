using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    internal class Mimic : IEntity, IMimic
    {
        public string Name { get; set; }

        public void Attack(IEntity target)
        {
            Console.WriteLine($"Mimic's tongue lashes at {target.Name}");
        }

        public void Devour(IEntity target)
        {
            Console.WriteLine($"Mimic opens wide and devours {target.Name} whole");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} slithers forward.");
        }

        public void Slain(IEntity slayer)
        {
            Console.WriteLine($"{slayer.Name} defeats {Name} with a decisive strike.");
        }

        public void Touched(IEntity toucher)
        {
            Console.WriteLine($"{toucher.Name} attempts to open {Name}, which reveals itself to be a mimic by opening its giant maw and baring " +
                $"its razor sharp teeth.");
            Name = "Mimic";
        }

        void IMimic.Mimic()
        {
            Console.WriteLine($"{Name} sits temptingly in the corner.");
            Name = "Treasure Chest";
        }
    }
}
