using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypeSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region redirect debug output into console
            TextWriterTraceListener myWriter = new TextWriterTraceListener(System.Console.Out);
            Debug.Listeners.Add(myWriter);
            #endregion

            var a = ClassTest.Factory(ClassTest.ClassTestType.A);
            var b = ClassTest.Factory(ClassTest.ClassTestType.B);
            var bSpecial = ClassTest.Factory(ClassTest.ClassTestType.B);

            ((ClassTestB)bSpecial).Special = true;

            Debug.WriteLine("=> TestSwith(a)");
            TestSwith(a);
            Debug.WriteLine("=> TestSwith(b)");
            TestSwith(b);
            Debug.WriteLine("=> TestSwith(bSpecial)");
            TestSwith(bSpecial);

            #region simple pause
            Console.ReadKey();
            #endregion
        }

        static void TestSwith(ClassTest classTest)
        {
            switch (classTest)
            {
                case ClassTestA classA:
                    classA?.MethodeA();
                    break;
                case ClassTestB classB when classB.Special:
                    Debug.WriteLine("Special");
                    classB?.MethodeB();
                    break;
                case ClassTestB classB:
                    classB?.MethodeB();
                    break;
            }
        }
    }
}
