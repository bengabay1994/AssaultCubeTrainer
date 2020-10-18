using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace ACTrainer
{
    public partial class MainForm : Form
    {
        private const string c_gameName = "ac_client";
        private const string c_friendlyName = "Assault Cube";
        private const string c_notFound = "N/A";
        private static readonly byte[] c_FourBytesZero = {0,0,0,0};
        private static bool isGameOn = false;

        public Mem m_memoryObj = new Mem();

        public MainForm()
        {
            InitializeComponent();
        }

        private void GodMod_CheckedChanged(object sender, EventArgs e)
        {
            if (isGameOn)
            {
                if (GodMod.CheckState == CheckState.Checked)
                {
                    m_memoryObj.FreezeValue("base+10F4F4,F8", "int", "907");
                    health.Enabled = false;
                }
                else
                {
                    try
                    {
                        m_memoryObj.UnfreezeValue("base+10F4F4, F8");
                        health.Enabled = true;
                    }
                    catch(Exception exc){}
                }
            }
        }

        private async void FindGameAsync()
        {
            while (true) 
            {
                if (!m_memoryObj.OpenProcess(c_gameName)) 
                {
                    isGameOn = false;
                    IsProcFound.Text = c_notFound;
                    await Task.Delay(TimeSpan.FromSeconds(1));
                    continue;
                }
                else
                {
                    isGameOn = true;
                    IsProcFound.Text = $"{c_friendlyName} found";
                }
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            FindGameAsync();
        }

        private void InfiniteJumps_CheckedChanged(object sender, EventArgs e)
        {
            if (isGameOn && InfiniteJumps.Checked)
            {
                m_memoryObj.FreezeValue("base+10F4F4,69", "byte", "1");
            }
            else
            {
                try
                {
                    m_memoryObj.UnfreezeValue("base+10F4F4,69");
                }
                catch (Exception exc){}
            }
        }

        private void health_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(health.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory("base+10F4F4,F8", "int", health.Text);
            }
        }

        private void sheild_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(sheild.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory("base+10F4F4,FC", "int", sheild.Text);
            }
        }

        private void IsTwoPistols_CheckedChanged(object sender, EventArgs e)
        {
            if (isGameOn && IsTwoPistols.Checked)
            {
                m_memoryObj.FreezeValue("base+10F4F4,10C", "byte", "1");
            }
            else
            {
                try
                {
                    m_memoryObj.UnfreezeValue("base+10F4F4,10C");
                }
                catch (Exception exc){}
            }
        }

        private void OnePistolAmmo_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(OnePistolAmmo.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory("base+10F4F4,114", "int", OnePistolAmmo.Text);
            }
        }

        private void MainWeaponAmmo_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(MainWeaponAmmo.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory("base+10F4F4,128", "int", MainWeaponAmmo.Text);
            }
        }

        private void TwoPistolAmmo_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(TwoPistolAmmo.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory("base+10F4F4,134", "int", TwoPistolAmmo.Text);
            }
        }

        private void OnePistolStack_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(OnePistolStack.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory("base+10F4F4,13C", "int", OnePistolStack.Text);
            }
        }

        private void MainWeaponStack_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(MainWeaponStack.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory("base+10F4F4,150", "int", MainWeaponStack.Text);
            }
        }

        private void Granades_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(Granades.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory("base+10F4F4,158", "int", Granades.Text);
            }
        }

        private void TwoPistolStack_TextChanged(object sender, EventArgs e)
        {
            var isNum = int.TryParse(TwoPistolStack.Text, out _);
            if (isGameOn && isNum)
            {
                m_memoryObj.WriteMemory("base+10F4F4,15C", "int", TwoPistolStack.Text);
            }
        }

        private void NoReload_CheckedChanged(object sender, EventArgs e)
        {
            if(isGameOn){ 
                if (NoReload.Checked)
                {
                    Add100AndFreezeAmmo();
                }
                else
                {
                    UnFreezeAmmo();
                }
            }
        }

        private void Add100AndFreezeAmmo()
        {
            m_memoryObj.FreezeValue("base+10F4F4,114", "int", "100");
            m_memoryObj.FreezeValue("base+10F4F4,128", "int", "100");
            m_memoryObj.FreezeValue("base+10F4F4,134", "int", "100");
            m_memoryObj.FreezeValue("base+10F4F4,13C", "int", "100");
            m_memoryObj.FreezeValue("base+10F4F4,150", "int", "100");
            m_memoryObj.FreezeValue("base+10F4F4,158", "int", "100");
            m_memoryObj.FreezeValue("base+10F4F4,15C", "int", "100");
        }

        private void UnFreezeAmmo()
        {
            try
            {
                m_memoryObj.UnfreezeValue("base+10F4F4,114");
                m_memoryObj.UnfreezeValue("base+10F4F4,128");
                m_memoryObj.UnfreezeValue("base+10F4F4,134");
                m_memoryObj.UnfreezeValue("base+10F4F4,13C");
                m_memoryObj.UnfreezeValue("base+10F4F4,150");
                m_memoryObj.UnfreezeValue("base+10F4F4,158");
                m_memoryObj.UnfreezeValue("base+10F4F4,15C");
            }
            catch (Exception exc){}
        }
    }
}
