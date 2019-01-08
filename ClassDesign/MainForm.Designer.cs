namespace ClassDesign
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lable2 = new System.Windows.Forms.Label();
            this.lab_remain = new System.Windows.Forms.Label();
            this.btn_monster = new System.Windows.Forms.Button();
            this.btn_attack = new System.Windows.Forms.Button();
            this.rbt_wood = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbt_handgun = new System.Windows.Forms.RadioButton();
            this.rbt_magic = new System.Windows.Forms.RadioButton();
            this.rbt_iron = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(147, 33);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(58, 13);
            this.lable2.TabIndex = 3;
            this.lable2.Text = "Remained:";
            // 
            // lab_remain
            // 
            this.lab_remain.AutoSize = true;
            this.lab_remain.Location = new System.Drawing.Point(224, 33);
            this.lab_remain.Name = "lab_remain";
            this.lab_remain.Size = new System.Drawing.Size(13, 13);
            this.lab_remain.TabIndex = 4;
            this.lab_remain.Text = "0";
            // 
            // btn_monster
            // 
            this.btn_monster.Location = new System.Drawing.Point(43, 28);
            this.btn_monster.Name = "btn_monster";
            this.btn_monster.Size = new System.Drawing.Size(75, 23);
            this.btn_monster.TabIndex = 5;
            this.btn_monster.Text = "Moster";
            this.btn_monster.UseVisualStyleBackColor = true;
            this.btn_monster.Click += new System.EventHandler(this.btn_tiger_Click);
            // 
            // btn_attack
            // 
            this.btn_attack.Location = new System.Drawing.Point(102, 165);
            this.btn_attack.Name = "btn_attack";
            this.btn_attack.Size = new System.Drawing.Size(75, 23);
            this.btn_attack.TabIndex = 6;
            this.btn_attack.Text = "Attack";
            this.btn_attack.UseVisualStyleBackColor = true;
            this.btn_attack.Click += new System.EventHandler(this.btn_attack_Click);
            // 
            // rbt_wood
            // 
            this.rbt_wood.AutoSize = true;
            this.rbt_wood.Location = new System.Drawing.Point(3, 3);
            this.rbt_wood.Name = "rbt_wood";
            this.rbt_wood.Size = new System.Drawing.Size(83, 17);
            this.rbt_wood.TabIndex = 7;
            this.rbt_wood.TabStop = true;
            this.rbt_wood.Text = "WoodSword";
            this.rbt_wood.UseVisualStyleBackColor = true;
            this.rbt_wood.CheckedChanged += new System.EventHandler(this.rbt_wood_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbt_handgun);
            this.panel1.Controls.Add(this.rbt_magic);
            this.panel1.Controls.Add(this.rbt_iron);
            this.panel1.Controls.Add(this.rbt_wood);
            this.panel1.Location = new System.Drawing.Point(43, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 53);
            this.panel1.TabIndex = 8;
            // 
            // rbt_handgun
            // 
            this.rbt_handgun.AutoSize = true;
            this.rbt_handgun.Location = new System.Drawing.Point(107, 26);
            this.rbt_handgun.Name = "rbt_handgun";
            this.rbt_handgun.Size = new System.Drawing.Size(69, 17);
            this.rbt_handgun.TabIndex = 10;
            this.rbt_handgun.TabStop = true;
            this.rbt_handgun.Text = "HandGun";
            this.rbt_handgun.UseVisualStyleBackColor = true;
            this.rbt_handgun.CheckedChanged += new System.EventHandler(this.rbt_handgun_CheckedChanged);
            // 
            // rbt_magic
            // 
            this.rbt_magic.AutoSize = true;
            this.rbt_magic.Location = new System.Drawing.Point(107, 3);
            this.rbt_magic.Name = "rbt_magic";
            this.rbt_magic.Size = new System.Drawing.Size(82, 17);
            this.rbt_magic.TabIndex = 9;
            this.rbt_magic.TabStop = true;
            this.rbt_magic.Text = "MagicSword";
            this.rbt_magic.UseVisualStyleBackColor = true;
            this.rbt_magic.CheckedChanged += new System.EventHandler(this.rbt_magic_CheckedChanged);
            // 
            // rbt_iron
            // 
            this.rbt_iron.AutoSize = true;
            this.rbt_iron.Location = new System.Drawing.Point(3, 26);
            this.rbt_iron.Name = "rbt_iron";
            this.rbt_iron.Size = new System.Drawing.Size(75, 17);
            this.rbt_iron.TabIndex = 8;
            this.rbt_iron.TabStop = true;
            this.rbt_iron.Text = "IronSword";
            this.rbt_iron.UseVisualStyleBackColor = true;
            this.rbt_iron.CheckedChanged += new System.EventHandler(this.rbt_iron_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 200);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_attack);
            this.Controls.Add(this.btn_monster);
            this.Controls.Add(this.lab_remain);
            this.Controls.Add(this.lable2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label lab_remain;
        private System.Windows.Forms.Button btn_monster;
        private System.Windows.Forms.Button btn_attack;
        private System.Windows.Forms.RadioButton rbt_wood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbt_magic;
        private System.Windows.Forms.RadioButton rbt_iron;
        private System.Windows.Forms.RadioButton rbt_handgun;
    }
}

