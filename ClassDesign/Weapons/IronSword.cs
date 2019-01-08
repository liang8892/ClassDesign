using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassDesign.Interface;

namespace ClassDesign.Weapons
{
    class IronSword : Weapon
    {
        protected override int Damage => 50;
    }
}
