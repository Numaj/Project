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
    public partial class Form1 : Form
    {
        //Fields
        public static Form1 Current;

        //Constructor
        public Form1()
        {
            Current = this;
            InitializeComponent();
        }

        //Event Handlers
        private void btn_compose_form1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
