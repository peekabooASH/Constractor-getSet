using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Person
    {
        //private string name;
        //public string Name
        //{
        //    get { return str; }
        //    set { str = value; }
        //}

        //private int myInt;
        //public int MyInt
        //{
        //    get { return myInt; }
        //    set { myInt = value; }
        //}
        private string firstName;
        private string middleName;
        private string lastName;

        public string FirstName {private get; set; }
        public string MiddleName{private get;set;}
        public string LastName { private get; set; }

        public Person(string firstName, string middleName,string lastName):this(firstName , lastName)
        {
           
            MiddleName=middleName;
        }
        public Person(string firstName, string lastName):this(firstName)
        {
            
            LastName  =lastName;
           
        }
        public Person(string firstName): this()
        {
            FirstName = firstName;
         }
        public Person()
        {
        }
        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }

        public string GetFullReverseName()
        {
            string fullName = GetFullName();
            char[] cArray = fullName.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;            
        }
    }
}
