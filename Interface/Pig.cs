using MPVInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVPInterface
{
    public class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
}
