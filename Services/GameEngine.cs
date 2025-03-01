using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly IEntity _character;
        private readonly IEntity _goblin;
        private readonly IEntity _ghost;
        private readonly IEntity _mimic;
        private readonly List<ICommand> _commands;

        public GameEngine(IEntity character, IEntity goblin, IEntity ghost, IEntity mimic)
        {
            _character = character;
            _goblin = goblin;
            _ghost = ghost;
            _mimic = mimic;
            _commands = new List<ICommand>();
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";
            _mimic.Name = "Treasure Chest";
                     

          

            
            _commands.Add(new MoveCommand(_ghost));
            _commands.Add(new MoveCommand(_goblin));

            if (_mimic is IMimic)
            {
                _commands.Add(new MimicCommand((IMimic)_mimic));
            }

            if (_mimic is IMimic)
            {
                _commands.Add(new MimicTouchedCommand((IMimic)_mimic, _goblin));
            }

            _commands.Add(new AttackCommand(_goblin, _mimic));

            if (_mimic is IMimic)
            {
                _commands.Add(new MimicDevourCommand((IMimic)_mimic, _goblin));
            }
          
            if (_ghost is IFlyable)
            {
                _commands.Add(new FlyCommand((IFlyable)_ghost));
            }

            if (_mimic is IMimic)
            {
                _commands.Add(new MimicCommand((IMimic)_mimic));
            }

            _commands.Add(new MoveCommand(_character));

            if (_mimic is IMimic)
            {
                _commands.Add(new MimicTouchedCommand((IMimic)_mimic, _goblin));
            }

            _commands.Add(new AttackCommand(_character, _mimic));
            _commands.Add(new AttackCommand(_mimic, _character));

            if (_mimic is IMimic)
            {
                _commands.Add(new MimicSlainCommand((IMimic)_mimic, _character));
            }
            

            if (_character is IEmote)
            {
                _commands.Add(new EmoteCommand((IEmote)_character));
            }

            foreach (var command in _commands)
            {
                command.Execute();
            }

        }
    }
}
