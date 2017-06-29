using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2017_Lesson8B
{
    public class DomesticStudent : Student
    {
        // PUBLIC PROPERTIES -----------------------------
        public string DomesticAddress { get; private set; } // READ ONLY

        // CONSTRUCTORS -----------------------------------

        /// <summary>
        /// This is the Constructor - takes three arguments - name (string) - age (int) - studentID (string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public DomesticStudent(string name, int age, string studentID) :
            base(name, age, studentID)
        {
           
        }

        // PUBLIC METHODS --------------------------------------------------------

        /// <summary>
        /// This method sets the Domestic Address Property
        /// </summary>
        /// <param name="address"></param>
        public void SetDomesticAddress(string address)
        {
            this.DomesticAddress = address;
        }


    }
}