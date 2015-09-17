using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("David", "Barnes", 25);

            Person person2 = new Person("Joe", "Somebody", 85);

            person.PrintFullName();
            person2.PrintFullName();
            person.PrintFullName();

            PersonCollection personCollection = new PersonCollection();

            personCollection.addPerson(person);

            personCollection.addPerson(new Person("Not", "Declared First", 34));

            Console.WriteLine(personCollection.getPersonCollectionToString());


            Console.WriteLine("Demo to show how branching works");
            Console.WriteLine("Here is another line");


            Console.WriteLine();
            Console.WriteLine("Different stuff");
            Console.WriteLine("Moar. All the different stuff");

        

        }
    }
}
