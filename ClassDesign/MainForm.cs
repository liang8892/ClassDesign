using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassDesign.Interface;
using ClassDesign.Monsters;
using ClassDesign.Weapons;

namespace ClassDesign
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly Person PERSON = new Person();
        private Monster monster;
        private readonly WoodSword woodSword = new WoodSword();
        private readonly IronSword ironSword = new IronSword();
        private readonly MagicSword magicSword = new MagicSword();
        private readonly HandGun handGun = new HandGun();

        public MainForm()
        {
            InitializeComponent();
            rbt_wood.Checked = true;
        }

        //刷新
        private void btn_tiger_Click(object sender, EventArgs e)
        {
            this.monster = new Tiger();
            lab_remain.Text = monster.HealthPoint.ToString();
        }

        #region Equipt Weapon

        //
        private void rbt_wood_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                PERSON.EquiptedWeapon = woodSword;
        }

        //
        private void rbt_iron_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                PERSON.EquiptedWeapon = ironSword;
        }

        //
        private void rbt_magic_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                PERSON.EquiptedWeapon = magicSword;
        }

        //
        private void rbt_handgun_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                PERSON.EquiptedWeapon = handGun;
        }
        
        #endregion

        //Attack
        private void btn_attack_Click(object sender, EventArgs e)
        {
            if (monster != null)
            {
                lab_remain.Text = AttackHelper.Attack(PERSON, monster);
            }
            else
            {
                MessageBox.Show("There is nothing to attack!");
            }
        }
    }
}
