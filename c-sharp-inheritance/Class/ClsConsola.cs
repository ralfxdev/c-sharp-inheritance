using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_inheritance.Class
{
    internal class ClsConsola
    {
        public int yearLaunch { get; set; }
        public string ?brand { get; set; }

        public string ShowDetails()
        {
            return $"Brand: {brand} - Year Launch: {yearLaunch}";
        }
    }
}
