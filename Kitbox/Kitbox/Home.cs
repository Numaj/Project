using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitbox
{
    public partial class Home : Form
    {
        //Fields
        public static Home Current;

        //Constructor
        public Home()
        {
            Current = this;
            InitializeComponent();
        }

        //Event handlers
        private void btn_user_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            form1 = null;
            this.Show();
        }
    }
}
