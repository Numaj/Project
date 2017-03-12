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
    public partial class Form2 : Form
    {
        //Fields
        public static Form2 Current;

        //Constructor
        public Form2()
        {
            Current = this;
            InitializeComponent();
        }

        //Event handlers
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void btn_back_form2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.Current.Show();
        }

        private void btn_next_form2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
