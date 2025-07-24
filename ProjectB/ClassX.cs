using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectA;

namespace ProjectB
{
    internal class X : ClassA
    {
        void DisplayClassMembers()
        {
            Console.WriteLine("Inside Class X (Derived):");
            Console.WriteLine(protectedVar);
            //ClassA ClassA = new ClassA A();
            //Console.WriteLine(ClassA.internalVar);
            Console.WriteLine(protectedInternalVar);

        }

    }
}
