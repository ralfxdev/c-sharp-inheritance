using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_inheritance.Class;

namespace c_sharp_inheritance.ChildClass
{
    internal class Nintendo : ClsConsola
    {
        public bool isPortable { get; set; }

        public string ShowDetailsNintendo()
        {
            string details = ShowDetails();
            return $"{details} - Is Portable: {isPortable}";
        }
    }
}
