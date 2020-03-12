using System;

namespace myClass_lib
{
    public class Tank
    {
        private string Name;
        private int Level_amunition;
        private int Level_armor;
        private int Level_maneuverability;
        public Tank(string name) {
            try
            {
                Random rand = new Random();
                this.Name = name;
                this.Level_amunition = rand.Next(0, 100);
                this.Level_armor = rand.Next(0, 100);
                this.Level_maneuverability = rand.Next(0, 100);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
        public override string ToString() {
            return "Name "+this.Name +" Level amunition "+ this.Level_amunition +" Level armor "+ Level_armor + " Level maneuverability "+this.Level_maneuverability;
        }
        static public string operator ^(Tank a, Tank b) {
            try
            {
                if ((a.Level_amunition > b.Level_amunition && a.Level_armor > b.Level_armor) || (a.Level_armor > b.Level_armor && a.Level_maneuverability > b.Level_maneuverability) || (a.Level_amunition > b.Level_amunition && a.Level_maneuverability > b.Level_maneuverability))
            {
                return a.ToString();
            }
            else if ((a.Level_amunition < b.Level_amunition && a.Level_armor < b.Level_armor) || (a.Level_armor < b.Level_armor && a.Level_maneuverability < b.Level_maneuverability) || (a.Level_amunition < b.Level_amunition && a.Level_maneuverability < b.Level_maneuverability)) {
                return b.ToString();
            }
            else {
                return "drow";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
