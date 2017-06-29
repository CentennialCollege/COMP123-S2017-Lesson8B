using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017_Lesson8B
{
    /// <summary>
    /// This is the Student class
    /// </summary>
    public class Student : Person
    {
        // PRIVATE INSTANCE VARIABLES (FIELDS)
        private string _studentID;

        // PUBLIC PROPERTIES 
        public string StudentID
        {
            get
            {
                return this._studentID;
            }

            set
            {
                this._studentID = value;
            }
        }

        // CONSTRUCTORS ----------------------------

        /// <summary>
        /// This is the constructor for the Student class.
        /// This takes three arguments - name (string) - age (int) - studentID (string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public Student(string name, int age, string studentID) 
            :base(name, age)
        {
            this.StudentID = studentID;
        }

        // PUBLIC METHODS -------------------------------------

        /// <summary>
        /// This is the Studies method.
        /// Enables the Student to study.
        /// </summary>
        public void Studies()
        {
            Console.WriteLine(this.Name + " is studying!");
        }
    }
}
