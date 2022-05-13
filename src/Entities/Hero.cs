namespace Jogo.src;

    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType) //Construtor
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {   //Método ToString da classe pai Object que vai ser sobrescrita. 
            return this.Name + " " + this.Level + " " + this.HeroType;

        }
        //Método virtual, significa que qualquer filho da classe, altere o comportamente.
        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua espada";
        }
    }
