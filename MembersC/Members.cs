using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersC
{
    internal class Members
    {
        //Member private Field
        private string memberName;
        private string jobTitle;
        private int salary;
        //Member public field
        public int age;
       
        // member - Property - Exposes jobTitle safely -
        // properties start with capital letter!!!
       /* public string JobTitle {
            get 
            {
                return jobTitle; 
            }
            set 
            {
                jobTitle = value;
            }
        }
       */

        //putblic member method - can be
        //called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Name is {0} , job title is {1} and im {2} years old",memberName,jobTitle,age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0} ",salary);
        }

        // member constructor

        public Members()
        {
            age = 30;
            memberName = "luci";
            salary = 2000;
            jobTitle = "dev";

            Console.WriteLine("Object Created");
        }

        //member - finilizer - destructor ( If neccessary - Should not be emty)
        ~Members()
        {
            // there for clean up statements
            Console.WriteLine("Destruction of members Object");
        }
    }

}
