using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_inheritance.Class;

namespace c_sharp_inheritance.ChildClass
{
    internal class SegaDreamCast : ClsConsola
    {
        public string[] ?games { get; set; }

        public string ShowDetailsSegaDreamCast()
        {
            string details = ShowDetails();
            return $"{details} - Games: {string.Join(", ", games)}";
        }
    }
}
