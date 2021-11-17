using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Player:Team
    {
        int id;
        string name;

        int age;

        string battingStyle;

        string bowlingStyle;

        public Player(string teamName, string country, int id, string name, int age, string battingStyle, string bowlingStyle) : base(teamName, country)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.BattingStyle = battingStyle;
            this.BowlingStyle = bowlingStyle;
        }

        public Player(int id, string name, int age, string battingStyle, string bowlingStyle)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.BattingStyle = battingStyle;
            this.BowlingStyle = bowlingStyle;
        }

        public Player()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string BattingStyle { get => battingStyle; set => battingStyle = value; }
        public string BowlingStyle { get => bowlingStyle; set => bowlingStyle = value; }


        public override bool Equals(object obj)
        {

            Player obj_playe = (Player)obj;
            return this.Name.Equals(obj_playe.Name) || this.BattingStyle.Equals(obj_playe.BattingStyle);

        }
        public override string ToString() => string.Format("{0,15}  {1,15} {2,15} {3,15} {4,15} ", Id, Name, Age, BattingStyle, BowlingStyle);
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
