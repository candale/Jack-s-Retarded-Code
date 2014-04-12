using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC.view
{
    public partial class WelcomeMessage : Form
    {
        Timer tm;
        public WelcomeMessage(string message)
        {
            InitializeComponent();
            label1.Text = message;
        }

        private void WelcomeMessage_Load(object sender, EventArgs e)
        {
            tm = new Timer();
            tm.Interval = 1500;
            tm.Tick += tm_Tick;
        }

        private void tm_Tick(object obj, EventArgs e)
        {
            this.Close();
        }
    }
}
