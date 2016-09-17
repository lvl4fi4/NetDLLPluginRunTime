using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mydll
{
    public partial class GBox : UserControl
    {
        public GBox()
        {
            InitializeComponent();
        }

        public UserControl setting(string s, string d) {
            textBox1.Text = s;
            textBox2.Text = d;
            return this;
        }
    }
}
