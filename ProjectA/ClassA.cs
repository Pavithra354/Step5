using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class ClassA
    {
        private string privateVar = "Private: Only accessible within the class.";
        protected string protectedVar = "protected: Accessible in derived classes.";
        internal string internalVar = "Internal: Accessible within the same assembly."; 
        protected string protectedInternalVar ="protected Internal:Accessible in same assembly or derived class of another class.";

        void DisplayBaseClassMembers()
        {
            Console.WriteLine("Inside Class A:");
            Console.WriteLine(privateVar);
            Console.WriteLine(protectedVar);
            Console.WriteLine(internalVar);
            Console.WriteLine(protectedInternalVar);




        }
    }
}
