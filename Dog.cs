namespace animals
{
    class Dog : Pet
    {
        private bool friendly;

        public Dog(bool Friendly, string Name) : base(Name){
            friendly = Friendly;
        }

        public bool isFriendly(){
            return friendly;
        }

        public override string talk()
        {
            return "Bark";
        }

        public override string ToString()
        {
            return "Dog: " + "name=" + name + " friendly=" + friendly;
        }
    }
}