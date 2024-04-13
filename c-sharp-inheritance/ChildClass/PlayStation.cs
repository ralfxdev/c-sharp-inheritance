using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_inheritance.Class;

namespace c_sharp_inheritance.ChildClass
{
    internal class PlayStation : ClsConsola
    {
        public string ?driveModel { get; set; }

        public string ShowDetailsPlayStation()
        {
            string details = ShowDetails();
            return $"{details} - Drive Model: {driveModel}";
        }
    }
}
