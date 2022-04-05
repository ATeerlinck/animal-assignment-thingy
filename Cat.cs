namespace animals
{
    class Cat : Pet
    {
        private int mousesKilled;

        public Cat(int MousesKilled, string name) : base(name){
            mousesKilled = MousesKilled;
        }

        public void addMouse(){this.mousesKilled++;}

        public override string talk()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return "Cat: " + "name=" + name + " mousesKilled=" + mousesKilled;;
        }
    }
}