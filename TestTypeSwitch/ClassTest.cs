using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTypeSwitch
{
    public abstract class ClassTest
    {
        public enum ClassTestType { A,B };

        public static ClassTest Factory(ClassTestType type)
        {
            ClassTest result = null;
            switch (type)
            {
                case ClassTestType.A:
                    result = new ClassTestA();
                    break;
                case ClassTestType.B:
                    result = new ClassTestB();
                    break;
            }
            return result;
        }
    }
}
