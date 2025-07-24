using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    internal class ClassC
    {
        public void DisplayClassCMembers()
        {
            Console.WriteLine("Inside ClassC (Non-Derived):");
            
            // Console.WriteLine(privateVar);
            ClassA ClassA = new ClassA();
           
            // Console.WriteLine(protectedVar);
            Console.WriteLine( ClassA.internalVar);
            //Console.WriteLine(protectedInternalVar);




        }

    }
}
