using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_inheritance.Class;

namespace c_sharp_inheritance.ChildClass
{
    internal class Xbox : ClsConsola
    {
        public string ?edition { get; set; }

        public string ShowDetailsXbox()
        {
            string details = ShowDetails();
            return $"{details} - Edition: {edition}";
        }
    }
}
