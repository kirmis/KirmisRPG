using System;
using CharacterLibrary;

namespace CharacterCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = new Character("Kirmis");
            character.GenerateCharacter();
        }
    }
}
