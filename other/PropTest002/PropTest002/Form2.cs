using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PropTest002
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            myPropGrid1.SetStandardPropertyTabs();

            MyTest myT = new MyTest();

            myT.nameChange += new NameChange(MyNameChange);

            myPropGrid1.SelectedObject = myT;
        }

        void MyNameChange(string newName)
        {
            textBox1.Text = newName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myPropGrid1.Dock = DockStyle.Fill;
        }
    }
}