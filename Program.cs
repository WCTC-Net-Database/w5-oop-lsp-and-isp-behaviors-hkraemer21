using Microsoft.Extensions.DependencyInjection;
using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;
using W5_assignment_template.Services;

namespace W5_assignment_template
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = new Character();
            var goblin = new Goblin();
            var ghost = new Ghost();
            var mimic = new Mimic();

            var gameEngine = new GameEngine(character, goblin, ghost, mimic);
            gameEngine?.Run();
        }

    }
}
