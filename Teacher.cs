using System;

namespace animals
{
    public class Teacher : Person
    {
        private int age {get; set;}

        public Teacher(int Age, string Name): base(Name){
            age = Age;
        }

        public override string talk(){return "Don't forget to do the assigned reading!";}
    }
}