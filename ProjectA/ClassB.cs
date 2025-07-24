using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA;

internal class ClassB : ClassA
{
    void DisplayDerivedClassMembers()
    {
        Console.WriteLine("Inside Class B (Derived):");
        Console.WriteLine(protectedVar);
        Console.WriteLine(internalVar);
        { 
            Console.WriteLine(protectedInternalVar);


        }
    }
}
