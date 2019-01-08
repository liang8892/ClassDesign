using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDesign.Interface
{
    public abstract class Weapon //: IWeapon
    {
        /// <summary>
        /// 武器伤害值
        /// </summary>
        /// <returns></returns>
        protected abstract int Damage { get; }

        /// <summary>
        /// 攻击方法
        /// </summary>
        /// <param name="monster"></param>
        /// <returns></returns>
        public int Attack(Monster monster)
        {
            monster.HealthPoint -= Damage;
            return monster.HealthPoint;
        }
    }
}
