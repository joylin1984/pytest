using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


using NativePropGrid;

namespace PropTest002
{
    public delegate void NameChange( string newName);

    class MyTest
    {
        private int myInt;
        private bool myBool;
        private string myName;
        private float myFloat;

        public event NameChange nameChange = null;

        System.Drawing.Color myColor;

        [Description("The is my color"), Localizable(true)]
        [NativeNameAttibute("颜色")]
        // [Category("颜色")]
        [Browsable(true)]
        public System.Drawing.Color MyColor
        {
            get { return myColor; }
            set { myColor = value; }
        }

        [Description("The is my name"), Category("Appearance"), Localizable(true)]
        [NativeNameAttibute("名字")]
        public string MyName
        {
            get { return myName; }
            set { 
                myName = value;
                if (nameChange != null)
                    nameChange(myName);
            }
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
