namespace animals
{
    public abstract class Pet : ITalkable
    {
        protected string name;

        public Pet(string Name){name = Name;}

        public string getName(){return name;}
        public virtual string talk(){return "";}
    }
}
    