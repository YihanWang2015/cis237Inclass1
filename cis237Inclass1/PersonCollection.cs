using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class PersonCollection
    {
        Person[] personArray;
        int lengthOfAarray;

        public PersonCollection()
        {
            personArray = new Person[4];
            lengthOfAarray = 0;
        }

        public void addPerson(Person person)
        {
            personArray[lengthOfAarray] = person;
            lengthOfAarray++;
        }

        public string getPersonCollectionToString()
        {
            string fullOutput = "";
            foreach (Person person in personArray)
            {

                if (person != null)
                {
                    fullOutput += person.ToString() + Environment.NewLine;
                }
                                              
              
            }

            return fullOutput;
        }

    }
}
