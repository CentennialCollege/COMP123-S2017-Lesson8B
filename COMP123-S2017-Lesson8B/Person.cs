using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017_Lesson8B
{
    /// <summary>
    /// This is the Person class
    /// </summary>
    class Person
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private string _name;
        private int _age;

        // PUBLIC PROPERTIES --------------------------
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        public int Age
        {
            get
            {
                return this._age;
            }

            set
            {
                this._age = value;
            }
        }

        // CONSTRUCTORS ----------------------------------------------

        /// <summary>
        /// This is the constructor for the Person class.
        /// It takes two arguments - name (string) and age (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // PUBLIC METHODS ---------------------------------------------

        /// <summary>
        /// This method enables the Person object to Talk
        /// </summary>
        public void Talks()
        {
            Console.WriteLine(this.Name + " is talking");
        }
    }
}
