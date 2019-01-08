using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassDesign.Interface;

namespace ClassDesign
{
    class Person
    {
        public Weapon EquiptedWeapon { get; set; }

        public int Attack(Monster monster)
        {
            if (EquiptedWeapon != null)
            {
                return EquiptedWeapon.Attack(monster);
            }
            else
            {
                MessageBox.Show("No Weapon was equiped!");
                return 0;
            }
        }
    }
}
