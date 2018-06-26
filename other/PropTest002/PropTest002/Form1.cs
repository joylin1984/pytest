using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using NativePropGrid;

namespace PropTest002
{
    public partial class Form1 : Form
    {
        private MMM mmm = new MMM();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //propertyGrid1.SelectedObject = textBox1;            
            propertyGrid1.SelectedObject = mmm;
        }

        private void propertyGrid1_SelectedObjectsChanged(object sender, EventArgs e)
        {

        }
    }

    public class MMM : PropertyBase
    {
        private int myInt;
        private bool myBool;
        private string myName;
        private float myFloat;

        System.Drawing.Color myColor;

        [Description("The is my color"), Localizable(true)]
        [NativeNameAttibute("颜色")]
       // [Category("颜色")]
        [Browsable(false)]
        public System.Drawing.Color MyColor
        {
            get { return myColor; }
            set { myColor = value; }
        }

        [Description("The is my name") , Category("Appearance"), Localizable(true)]
        [NativeNameAttibute("名字")]
        public string MyName
        {
            get { return myName; }
            set { myName = value; }
        }

        /// <summary>
        /// this is my int
        /// </summary>
        [Category("Old")]
        [NativeNameAttibute("整数")]
        public int MyInt
        {
            get { return myInt; }
            set { myInt = value; }
        }

        /// <summary>
        /// this is my bool
        /// </summary>
        [Browsable(false)]
        [Category("Old")]
        [NativeNameAttibute("布尔")]
        public bool MyBool
        {
            get { return myBool; }
            set { myBool = value; }
        }
        
        //[NativeAttibute("")]
        public float MyFloat
        {
            get { return myFloat; }
            set { myFloat = value; }
        }
    }


}