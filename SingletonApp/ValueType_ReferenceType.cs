using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonApp
{
    static class ValueType_ReferenceType
    {
        public static void main() {
            int obj1 = 1;
            int obj2 = 3;

            obj1 = obj2;

            obj1 = 10;
            obj2 = 20;

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

        }
    }
}
