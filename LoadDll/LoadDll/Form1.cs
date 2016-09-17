using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadDll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            byte[] bytes = File.ReadAllBytes(openFileDialog1.FileName);
            var dll = AppDomain.CurrentDomain.Load(bytes);
            var newdll = dll.CreateInstance("mydll.GBox");
            var dlltype = dll.GetType("mydll.GBox");
            var form = dlltype.InvokeMember("setting", BindingFlags.Default | BindingFlags.InvokeMethod,
                null, newdll, new object[] { "Hellow!", "im here!" });

            this.Controls.Add(((UserControl)form));
            if(Controls.Count==3)
            this.Controls.RemoveAt(1);
        }
    }
}
