namespace animals
{
    public abstract class Person : ITalkable
    {
        private string name;

        public Person(string Name){name = Name;}

        public void setName(String Name){name = Name;}
        public string getName(){return name;}
        public virtual string talk(){return "";}
    }
}