using System.Linq;
using System.Collections.Generic;
using System.IO;
using System;
using NLog.Web;

namespace animals
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "animals.txt";
            List<ITalkable> zoo = ReadFile(fileName);
            foreach (var animal in zoo)
            {
                Console.WriteLine(animal.getName() + " says " + animal.talk());
            }
        }

        public static List<ITalkable> ReadFile(string fileName){
            List<ITalkable> zoo = new List<ITalkable>();
            if(File.Exists(fileName)){
                StreamReader sr = new StreamReader(fileName);
                while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] animal = line.Split(" | ");
                        switch(animal[1]){
                            case "Bark":
                            zoo.Add(new Dog(true, animal[0]));
                            break;

                            case "Meow":
                            zoo.Add(new Cat(0, animal[0]));
                            break;

                            default:
                            zoo.Add(new Teacher(30, animal[0]));
                            break;
                        }
                    }
                sr.Close();
            }
            return zoo;
        } 
    }
}
