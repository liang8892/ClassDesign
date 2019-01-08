using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassDesign.Interface;

namespace ClassDesign.Monsters
{
    class Tiger : Monster
    {
        private int _hp = 500;

        public int HealthPoint
        {
            get { return _hp; }
            set { _hp = value; }
        }
    }
}
