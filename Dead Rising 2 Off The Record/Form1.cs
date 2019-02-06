using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using PS3Lib;
using System.Windows.Forms;

namespace Dead_Rising_2_Off_The_Record
{
    public partial class Form1 : Form
    {
        public static PS3API PS3 = new PS3API();
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.TargetManager);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget())
            {
                MessageBox.Show("Connected");
            }
            else
            {
                string Message = "Connexion Impossible";
                MessageBox.Show(Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                MessageBox.Show("Process Attached");
            }
            else
            {
                string Message = "Impossible to attach";
                MessageBox.Show(Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0xD3, 0xE3, 0x01, 0x60 };
            PS3.SetMemory(0x00596D44, buffer);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
            PS3.SetMemory(0x00596D44, buffer); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
            PS3.SetMemory(0x008C39D4, buffer);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x7C, 0x44, 0x19, 0x8E };
            PS3.SetMemory(0x008C39D4, buffer);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x60, 0x00, 0x00, 0x00 };
            PS3.SetMemory(0x008C8200, buffer);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x93, 0xE5, 0x06, 0xEC };
            PS3.SetMemory(0x008C8200, buffer);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x30, 0x63, 0x27, 0x10 };
            PS3.SetMemory(0x008C498C, buffer);
            byte[] buffer1 = new byte[] { 0x30, 0xA5, 0x27, 0x10 };
            PS3.SetMemory(0x008C4994, buffer1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x7C, 0x63, 0xE8, 0x14 };
            PS3.SetMemory(0x008C498C, buffer);
            byte[] buffer1 = new byte[] { 0x7C, 0xA5, 0xE8, 0x14 };
            PS3.SetMemory(0x008C4994, buffer1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x30, 0xA3, 0x27, 0x10 };
            PS3.SetMemory(0x002E4C7C, buffer);
            byte[] buffer1 = new byte[] { 0x30, 0xE7, 0x27, 0x10 };
            PS3.SetMemory(0x008C764C, buffer1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[] { 0x30, 0xA3, 0x00, 0x96 };
            PS3.SetMemory(0x002E4C7C, buffer);
            byte[] buffer1 = new byte[] { 0x7C, 0xE7, 0x20, 0x14 };
            PS3.SetMemory(0x008C764C, buffer1);
        }
    }
}
