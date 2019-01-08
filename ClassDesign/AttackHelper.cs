using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassDesign.Interface;
using ClassDesign.Monsters;
using ClassDesign.Weapons;

namespace ClassDesign
{
    class AttackHelper
    {
        public static string Attack(Person person, Monster monster)
        {
            string result;

            int remaind = person.Attack(monster);
            result = remaind > 0 ? remaind.ToString() : "You win!";

            return result;
        }
    }
}
