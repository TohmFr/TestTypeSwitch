using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TestTypeSwitch
{
    public class ClassTestB : ClassTest
    {
        public ClassTestB()
        {
            this.Special = false;
        }

        public void MethodeB()
        {
            Debug.WriteLine("ClassTestB.MethodeB");
        } 

        public bool Special { get; set; } 
        
    }
}
