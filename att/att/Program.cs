using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace att
{
    

    // Create some custom attributes:
    [AttributeUsage(System.AttributeTargets.Class, Inherited = false)]
    class A1 : System.Attribute { }

    [AttributeUsage(System.AttributeTargets.Class)]
    class A2 : System.Attribute { }

    [AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    class A3 : System.Attribute { }

    // Apply custom attributes to classes:
    [A1, A2]
    class BaseClass { }

    [A3, A3]
    class DerivedClass : BaseClass { }

    public class TestAttributeUsage
    {
        static void Main()
        {
            BaseClass b = new BaseClass();
            DerivedClass d = new DerivedClass();

            // Display custom attributes for each class.
            Console.WriteLine("Attributes on Base Class:");
            object[] attrs = b.GetType().GetCustomAttributes(true);
            foreach (Attribute attr in attrs)
            {
                Console.WriteLine(attr);
            }

            Console.WriteLine("Attributes on Derived Class:");
            attrs = d.GetType().GetCustomAttributes(true);
            foreach (Attribute attr in attrs)
            {
                Console.WriteLine(attr);
            }
            Console.ReadKey();
        }
    }

}
