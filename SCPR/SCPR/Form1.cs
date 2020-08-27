using System;
using System.Windows.Forms;

namespace SCPR
{
    //This program was made by zix#6969
    //If you want something made, DM me on discord, and I might consider doing it.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        private void SCP_Click(object sender, EventArgs e)
        {
            string zero = "0";
            int scp;
            string scpr;

            Random r = new Random();
            scp = r.Next(1, 5999);

            if (scp <= 99)
            {
                if (scp <= 9)
                {
                    scpr = zero + zero + scp.ToString();
                } else
                {
                    scpr = zero + scp.ToString();
                }
            } else
            {
                scpr = scp.ToString();
            }

            System.Diagnostics.Process.Start("http://www.scpwiki.com/scp-" + scpr);
        }
    }
}
