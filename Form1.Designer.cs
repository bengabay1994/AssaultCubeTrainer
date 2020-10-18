namespace ACTrainer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GodMod = new System.Windows.Forms.CheckBox();
            this.gameLabel = new System.Windows.Forms.Label();
            this.IsProcFound = new System.Windows.Forms.Label();
            this.InfiniteJumps = new System.Windows.Forms.CheckBox();
            this.L_health = new System.Windows.Forms.Label();
            this.health = new System.Windows.Forms.TextBox();
            this.L_sheild = new System.Windows.Forms.Label();
            this.sheild = new System.Windows.Forms.TextBox();
            this.IsTwoPistols = new System.Windows.Forms.CheckBox();
            this.L_OnePistolAmmo = new System.Windows.Forms.Label();
            this.L_MainWeaponAmmo = new System.Windows.Forms.Label();
            this.L_TwoPistolAmmo = new System.Windows.Forms.Label();
            this.L_OnePistolStack = new System.Windows.Forms.Label();
            this.L_MainWeaponStack = new System.Windows.Forms.Label();
            this.L_Granades = new System.Windows.Forms.Label();
            this.L_TwoPistolStack = new System.Windows.Forms.Label();
            this.OnePistolAmmo = new System.Windows.Forms.TextBox();
            this.TwoPistolStack = new System.Windows.Forms.TextBox();
            this.Granades = new System.Windows.Forms.TextBox();
            this.MainWeaponStack = new System.Windows.Forms.TextBox();
            this.OnePistolStack = new System.Windows.Forms.TextBox();
            this.TwoPistolAmmo = new System.Windows.Forms.TextBox();
            this.MainWeaponAmmo = new System.Windows.Forms.TextBox();
            this.NoReload = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // GodMod
            // 
            this.GodMod.AutoSize = true;
            this.GodMod.Location = new System.Drawing.Point(12, 27);
            this.GodMod.Name = "GodMod";
            this.GodMod.Size = new System.Drawing.Size(73, 19);
            this.GodMod.TabIndex = 1;
            this.GodMod.Text = "GodMod";
            this.GodMod.UseVisualStyleBackColor = true;
            this.GodMod.CheckedChanged += new System.EventHandler(this.GodMod_CheckedChanged);
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(12, 9);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(50, 15);
            this.gameLabel.TabIndex = 3;
            this.gameLabel.Text = "Process:";
            // 
            // IsProcFound
            // 
            this.IsProcFound.AutoSize = true;
            this.IsProcFound.Location = new System.Drawing.Point(69, 9);
            this.IsProcFound.Name = "IsProcFound";
            this.IsProcFound.Size = new System.Drawing.Size(0, 15);
            this.IsProcFound.TabIndex = 4;
            // 
            // InfiniteJumps
            // 
            this.InfiniteJumps.AutoSize = true;
            this.InfiniteJumps.Location = new System.Drawing.Point(12, 53);
            this.InfiniteJumps.Name = "InfiniteJumps";
            this.InfiniteJumps.Size = new System.Drawing.Size(97, 19);
            this.InfiniteJumps.TabIndex = 5;
            this.InfiniteJumps.Text = "InfiniteJumps";
            this.InfiniteJumps.UseVisualStyleBackColor = true;
            this.InfiniteJumps.CheckedChanged += new System.EventHandler(this.InfiniteJumps_CheckedChanged);
            // 
            // L_health
            // 
            this.L_health.AutoSize = true;
            this.L_health.Location = new System.Drawing.Point(12, 82);
            this.L_health.Name = "L_health";
            this.L_health.Size = new System.Drawing.Size(45, 15);
            this.L_health.TabIndex = 6;
            this.L_health.Text = "Health:";
            // 
            // health
            // 
            this.health.Location = new System.Drawing.Point(64, 79);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(100, 23);
            this.health.TabIndex = 7;
            this.health.TextChanged += new System.EventHandler(this.health_TextChanged);
            // 
            // L_sheild
            // 
            this.L_sheild.AutoSize = true;
            this.L_sheild.Location = new System.Drawing.Point(12, 112);
            this.L_sheild.Name = "L_sheild";
            this.L_sheild.Size = new System.Drawing.Size(39, 15);
            this.L_sheild.TabIndex = 8;
            this.L_sheild.Text = "Sheild";
            // 
            // sheild
            // 
            this.sheild.Location = new System.Drawing.Point(63, 109);
            this.sheild.Name = "sheild";
            this.sheild.Size = new System.Drawing.Size(100, 23);
            this.sheild.TabIndex = 9;
            this.sheild.TextChanged += new System.EventHandler(this.sheild_TextChanged);
            // 
            // IsTwoPistols
            // 
            this.IsTwoPistols.AutoSize = true;
            this.IsTwoPistols.Location = new System.Drawing.Point(12, 141);
            this.IsTwoPistols.Name = "IsTwoPistols";
            this.IsTwoPistols.Size = new System.Drawing.Size(89, 19);
            this.IsTwoPistols.TabIndex = 10;
            this.IsTwoPistols.Text = "IsTwoPistols";
            this.IsTwoPistols.UseVisualStyleBackColor = true;
            this.IsTwoPistols.CheckedChanged += new System.EventHandler(this.IsTwoPistols_CheckedChanged);
            // 
            // L_OnePistolAmmo
            // 
            this.L_OnePistolAmmo.AutoSize = true;
            this.L_OnePistolAmmo.Location = new System.Drawing.Point(12, 167);
            this.L_OnePistolAmmo.Name = "L_OnePistolAmmo";
            this.L_OnePistolAmmo.Size = new System.Drawing.Size(98, 15);
            this.L_OnePistolAmmo.TabIndex = 11;
            this.L_OnePistolAmmo.Text = "OnePistolAmmo:";
            // 
            // L_MainWeaponAmmo
            // 
            this.L_MainWeaponAmmo.AutoSize = true;
            this.L_MainWeaponAmmo.Location = new System.Drawing.Point(12, 196);
            this.L_MainWeaponAmmo.Name = "L_MainWeaponAmmo";
            this.L_MainWeaponAmmo.Size = new System.Drawing.Size(118, 15);
            this.L_MainWeaponAmmo.TabIndex = 11;
            this.L_MainWeaponAmmo.Text = "MainWeaponAmmo:";
            // 
            // L_TwoPistolAmmo
            // 
            this.L_TwoPistolAmmo.AutoSize = true;
            this.L_TwoPistolAmmo.Location = new System.Drawing.Point(12, 225);
            this.L_TwoPistolAmmo.Name = "L_TwoPistolAmmo";
            this.L_TwoPistolAmmo.Size = new System.Drawing.Size(97, 15);
            this.L_TwoPistolAmmo.TabIndex = 11;
            this.L_TwoPistolAmmo.Text = "TwoPistolAmmo:";
            // 
            // L_OnePistolStack
            // 
            this.L_OnePistolStack.AutoSize = true;
            this.L_OnePistolStack.Location = new System.Drawing.Point(12, 254);
            this.L_OnePistolStack.Name = "L_OnePistolStack";
            this.L_OnePistolStack.Size = new System.Drawing.Size(89, 15);
            this.L_OnePistolStack.TabIndex = 11;
            this.L_OnePistolStack.Text = "OnePistolStack:";
            // 
            // L_MainWeaponStack
            // 
            this.L_MainWeaponStack.AutoSize = true;
            this.L_MainWeaponStack.Location = new System.Drawing.Point(12, 283);
            this.L_MainWeaponStack.Name = "L_MainWeaponStack";
            this.L_MainWeaponStack.Size = new System.Drawing.Size(109, 15);
            this.L_MainWeaponStack.TabIndex = 11;
            this.L_MainWeaponStack.Text = "MainWeaponStack:";
            // 
            // L_Granades
            // 
            this.L_Granades.AutoSize = true;
            this.L_Granades.Location = new System.Drawing.Point(12, 312);
            this.L_Granades.Name = "L_Granades";
            this.L_Granades.Size = new System.Drawing.Size(59, 15);
            this.L_Granades.TabIndex = 11;
            this.L_Granades.Text = "Granades:";
            // 
            // L_TwoPistolStack
            // 
            this.L_TwoPistolStack.AutoSize = true;
            this.L_TwoPistolStack.Location = new System.Drawing.Point(12, 341);
            this.L_TwoPistolStack.Name = "L_TwoPistolStack";
            this.L_TwoPistolStack.Size = new System.Drawing.Size(88, 15);
            this.L_TwoPistolStack.TabIndex = 11;
            this.L_TwoPistolStack.Text = "TwoPistolStack:";
            // 
            // OnePistolAmmo
            // 
            this.OnePistolAmmo.Location = new System.Drawing.Point(138, 164);
            this.OnePistolAmmo.Name = "OnePistolAmmo";
            this.OnePistolAmmo.Size = new System.Drawing.Size(100, 23);
            this.OnePistolAmmo.TabIndex = 12;
            this.OnePistolAmmo.TextChanged += new System.EventHandler(this.OnePistolAmmo_TextChanged);
            // 
            // TwoPistolStack
            // 
            this.TwoPistolStack.Location = new System.Drawing.Point(138, 338);
            this.TwoPistolStack.Name = "TwoPistolStack";
            this.TwoPistolStack.Size = new System.Drawing.Size(100, 23);
            this.TwoPistolStack.TabIndex = 12;
            this.TwoPistolStack.TextChanged += new System.EventHandler(this.TwoPistolStack_TextChanged);
            // 
            // Granades
            // 
            this.Granades.Location = new System.Drawing.Point(138, 309);
            this.Granades.Name = "Granades";
            this.Granades.Size = new System.Drawing.Size(100, 23);
            this.Granades.TabIndex = 12;
            this.Granades.TextChanged += new System.EventHandler(this.Granades_TextChanged);
            // 
            // MainWeaponStack
            // 
            this.MainWeaponStack.Location = new System.Drawing.Point(138, 280);
            this.MainWeaponStack.Name = "MainWeaponStack";
            this.MainWeaponStack.Size = new System.Drawing.Size(100, 23);
            this.MainWeaponStack.TabIndex = 12;
            this.MainWeaponStack.TextChanged += new System.EventHandler(this.MainWeaponStack_TextChanged);
            // 
            // OnePistolStack
            // 
            this.OnePistolStack.Location = new System.Drawing.Point(138, 251);
            this.OnePistolStack.Name = "OnePistolStack";
            this.OnePistolStack.Size = new System.Drawing.Size(100, 23);
            this.OnePistolStack.TabIndex = 12;
            this.OnePistolStack.TextChanged += new System.EventHandler(this.OnePistolStack_TextChanged);
            // 
            // TwoPistolAmmo
            // 
            this.TwoPistolAmmo.Location = new System.Drawing.Point(138, 222);
            this.TwoPistolAmmo.Name = "TwoPistolAmmo";
            this.TwoPistolAmmo.Size = new System.Drawing.Size(100, 23);
            this.TwoPistolAmmo.TabIndex = 12;
            this.TwoPistolAmmo.TextChanged += new System.EventHandler(this.TwoPistolAmmo_TextChanged);
            // 
            // MainWeaponAmmo
            // 
            this.MainWeaponAmmo.Location = new System.Drawing.Point(138, 193);
            this.MainWeaponAmmo.Name = "MainWeaponAmmo";
            this.MainWeaponAmmo.Size = new System.Drawing.Size(100, 23);
            this.MainWeaponAmmo.TabIndex = 12;
            this.MainWeaponAmmo.TextChanged += new System.EventHandler(this.MainWeaponAmmo_TextChanged);
            // 
            // NoReload
            // 
            this.NoReload.AutoSize = true;
            this.NoReload.Location = new System.Drawing.Point(12, 364);
            this.NoReload.Name = "NoReload";
            this.NoReload.Size = new System.Drawing.Size(78, 19);
            this.NoReload.TabIndex = 13;
            this.NoReload.Text = "NoReload";
            this.NoReload.UseVisualStyleBackColor = true;
            this.NoReload.CheckedChanged += new System.EventHandler(this.NoReload_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NoReload);
            this.Controls.Add(this.MainWeaponAmmo);
            this.Controls.Add(this.TwoPistolAmmo);
            this.Controls.Add(this.OnePistolStack);
            this.Controls.Add(this.MainWeaponStack);
            this.Controls.Add(this.Granades);
            this.Controls.Add(this.TwoPistolStack);
            this.Controls.Add(this.OnePistolAmmo);
            this.Controls.Add(this.L_TwoPistolStack);
            this.Controls.Add(this.L_Granades);
            this.Controls.Add(this.L_MainWeaponStack);
            this.Controls.Add(this.L_OnePistolStack);
            this.Controls.Add(this.L_TwoPistolAmmo);
            this.Controls.Add(this.L_MainWeaponAmmo);
            this.Controls.Add(this.L_OnePistolAmmo);
            this.Controls.Add(this.IsTwoPistols);
            this.Controls.Add(this.sheild);
            this.Controls.Add(this.L_sheild);
            this.Controls.Add(this.health);
            this.Controls.Add(this.L_health);
            this.Controls.Add(this.InfiniteJumps);
            this.Controls.Add(this.IsProcFound);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.GodMod);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Assault Cube Trainer v.1.0.1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox GodMod;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.Label IsProcFound;
        private System.Windows.Forms.CheckBox InfiniteJumps;
        private System.Windows.Forms.Label L_health;
        private System.Windows.Forms.TextBox health;
        private System.Windows.Forms.Label L_sheild;
        private System.Windows.Forms.TextBox sheild;
        private System.Windows.Forms.CheckBox IsTwoPistols;
        private System.Windows.Forms.Label L_OnePistolAmmo;
        private System.Windows.Forms.Label L_MainWeaponAmmo;
        private System.Windows.Forms.Label L_TwoPistolAmmo;
        private System.Windows.Forms.Label L_OnePistolStack;
        private System.Windows.Forms.Label L_MainWeaponStack;
        private System.Windows.Forms.Label L_Granades;
        private System.Windows.Forms.Label L_TwoPistolStack;
        private System.Windows.Forms.TextBox OnePistolAmmo;
        private System.Windows.Forms.TextBox TwoPistolStack;
        private System.Windows.Forms.TextBox Granades;
        private System.Windows.Forms.TextBox MainWeaponStack;
        private System.Windows.Forms.TextBox OnePistolStack;
        private System.Windows.Forms.TextBox TwoPistolAmmo;
        private System.Windows.Forms.TextBox MainWeaponAmmo;
        private System.Windows.Forms.CheckBox NoReload;
    }
}

