using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWT
{
    class User
    {
        public string username { get; set; }
        public string gender { get; set; }
        public int height { get; set; }
        public int weight { get; set; }

        //public string username, gender;
        //public int height, weight;
        public bool back, shoulder, arm, chest, abs, butt, leg, fullbody;
    }
}
