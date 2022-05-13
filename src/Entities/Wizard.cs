namespace Jogo.src;

    public class Wizard : Hero
    {
        public Wizard(string Name, int level, string heroType) : base(Name, level, heroType)
        {

        }
        public override string Attack()
        {
            return this.Name + " Lançou Magia";
        }

        public string Attack(int Bonus){
            if (Bonus > 6)
            {
                return this.Name + " Lançou Magia super efetiva com bonus de " + Bonus;

            }
            else {
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
                
                
            return this.Name + " Lançou Magia com bonus de ataque de " + Bonus;
        }
    }

