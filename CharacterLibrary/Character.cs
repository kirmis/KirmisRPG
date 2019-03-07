using System;
namespace CharacterLibrary
{
    public class Character
    {
        public string CharacterName { get; set; }
        private int _strength;
        public int Strength
        {
            get { return _strenth; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _strength = value;
                }
                else
                {
                    throw new Exception("Strength must be a value between 3 and 18");
                }
            }
        }
        private int _intelligence;
        public int Intelligence
        {
            get { return _intelligence; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _intelligence = value;
                }
                else
                {
                    throw new Exception("Intelligence must be a value between 3 and 18");
                }
            }
        }
        private int _wisdom;
        public int Wisdom
        {
            get { return _wisdom; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _wisdom = value;
                }
                else
                {
                    throw new Exception("Wisdom must be a value between 3 and 18");
                }
            }
        }
        private int _dexterity;
        public int Dexterity
        {
            get { return _dexterity; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _dexterity = value;
                }
                else
                {
                    throw new Exception("Dexterity must be a value between 3 and 18");
                }
            }
        }
        private int _constitution;
        public int Constitution
        {
            get { return _constitution; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _constitution = value;
                }
                else
                {
                    throw new Exception("Consitution must be a value between 3 and 18");
                }
            }
        }
        private int _charisma;
        public int Charisma
        {
            get { return _charisma; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _charisma = value;
                }
                else
                {
                    throw new Exception("Charisma must be a value between 3 and 18");
                }
            }
        }
        public int ExperiencePoints { get; set; }
        public int Level { 
            get { return int.Parse(Math.Floor(ExperiencePoints / 1000d).ToString()); } 
        }
        private Random RandomNumber = new Random();

        public Character()
        {
            _strength = 3;
            _intelligence = 3;
            _wisdom = 3;
            _dexterity = 3;
            _constitution = 3;
            _charisma = 3;
        }

        public Character(string name)
        {
            CharacterName = name;
        }

        public Character(string name, int strenth, int intelligence, int wisdom, int dexterity, int constitution, int charisma)
        {
            CharacterName = name;
            _strength = strenth;
            _intelligence = intelligence;
            _wisdom = wisdom;
            _dexterity = dexterity;
            _constitution = constitution;
            _charisma = charisma;
        }

        private int RollAttributeScore()
        {
            int score = RandomNumber.Next(3, 18);

            return score;
        }

        public void GenerateCharacter()
        {
            Strength = RollAttributeScore();
            Intelligence = RollAttributeScore();
            Wisdom = RollAttributeScore();
            Dexterity = RollAttributeScore();
            Constitution = RollAttributeScore();
            Charisma = RollAttributeScore();
        }
    }
}
