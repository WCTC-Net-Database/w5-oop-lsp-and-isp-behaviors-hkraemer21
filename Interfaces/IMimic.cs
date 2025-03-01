using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_assignment_template.Interfaces
{
    public interface IMimic
    {
        public void Devour(IEntity target);

        public void Mimic();

        public void Touched(IEntity toucher);

        public void Slain(IEntity slayer);
    }
}
