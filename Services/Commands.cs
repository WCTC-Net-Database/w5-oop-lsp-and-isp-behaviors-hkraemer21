using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Services
{
    public class FlyCommand : ICommand
    {
        private readonly IFlyable _flyable;
        public FlyCommand(IFlyable flyable)
        {
            _flyable = flyable;
        }
        public void Execute()
        {
            _flyable.Fly();
        }
    }

    public class AttackCommand : ICommand
    {
        private readonly IEntity _attacker;
        private readonly IEntity _target;
        public AttackCommand(IEntity attacker, IEntity target)
        {
            _attacker = attacker;
            _target = target;
        }
        public void Execute()
        {
            _attacker.Attack(_target);
        }
    }

    public class MoveCommand : ICommand
    {
        private readonly IEntity _entity;
        public MoveCommand(IEntity entity)
        {
            _entity = entity;
        }
        public void Execute()
        {
            _entity.Move();
        }
    }

    public class MimicCommand : ICommand
    {
        private readonly IMimic _mimic;
        public MimicCommand(IMimic mimic)
        {
            _mimic = mimic;
        }
        public void Execute()
        {
            _mimic.Mimic();
        }
    }

    public class MimicDevourCommand : ICommand
    {
        private readonly IMimic _mimic;
        private readonly IEntity _target;
        public MimicDevourCommand(IMimic mimic, IEntity target)
        {
            _mimic = mimic;
            _target = target;
        }
        public void Execute()
        {
            _mimic.Devour(_target);
        }
    }

    public class MimicTouchedCommand : ICommand
    {
        private readonly IMimic _mimic;
        private readonly IEntity _toucher;
        public MimicTouchedCommand(IMimic mimic, IEntity toucher)
        {
            _mimic = mimic;
            _toucher = toucher;
        }
        public void Execute()
        {
            _mimic.Touched(_toucher);
        }
    }

    public class MimicSlainCommand : ICommand
    {
        private readonly IMimic _mimic;
        private readonly IEntity _slayer;
        public MimicSlainCommand(IMimic mimic, IEntity slayer)
        {
            _mimic = mimic;
            _slayer = slayer;
        }
        public void Execute()
        {
            _mimic.Slain(_slayer);
        }
    }

    public class  EmoteCommand : ICommand
    {
        private readonly IEmote _character;

        public EmoteCommand(IEmote character)
        {
            _character = character;
        }

        public void Execute()
        {
            _character.Emote();
        }
    }
}
