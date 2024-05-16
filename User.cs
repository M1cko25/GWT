using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GWT
{
    public class User
    {
        //public string username { get; set; }
        //public string gender { get; set; }
        //public int height { get; set; }
        //public int weight { get; set; }

        public string username, gender;
        public decimal height, weight;
        public bool back = false, shoulder = false, arm = false, chest = false, abs = false, butt = false, leg = false;

        public User(string _Name, string _Gender, bool _Back, bool _Shoulder, bool _Arm, bool _Chest, bool _Abs, bool _Butt, bool _leg, decimal _height, decimal _weight)
        {
            this.username = _Name;
            this.gender = _Gender;
            this.back = _Back;
            this.shoulder = _Shoulder;
            this.arm = _Arm;
            this.chest = _Chest;
            this.abs = _Abs;
            this.butt = _Butt;
            this.leg = _leg;
            this.height = _height;
            this.weight = _weight;
        }
    }
    
}
