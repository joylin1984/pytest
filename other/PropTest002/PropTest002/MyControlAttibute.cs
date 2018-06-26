using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Reflection;
using System.Collections;

using NativePropGrid;

namespace PropTest002
{
    public delegate void PropertyChanged(object Value);
    /// <summary> 
    /// 主要是实现中文化属性显示 ,需要实现本地显示的类,需继承此类
    /// </summary> 
    public class PropertyBase : ICustomTypeDescriptor
    {
        /// <summary> 
        /// 下面这段代码来源于：http://www.bluespace.cn/Html/Csdn/2_47/View_4702219.html 
        /// </summary> 
        /// <returns></returns> 
        #region ICustomTypeDescriptor 显式接口定义
        AttributeCollection ICustomTypeDescriptor.GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        string ICustomTypeDescriptor.GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        string ICustomTypeDescriptor.GetComponentName()
        {
            return TypeDescriptor.GetComponentName(this, true);
        }

        TypeConverter ICustomTypeDescriptor.GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }
        EventDescriptor ICustomTypeDescriptor.GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }
        PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty()
        {
            return null;
        }
        object ICustomTypeDescriptor.GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }
        EventDescriptorCollection ICustomTypeDescriptor.GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }
        EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }
        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties()
        {
            return ((ICustomTypeDescriptor)this).GetProperties(new Attribute[0]);
        }

        //PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
        //{  
        //    List<PropertyDescriptor> props = new List<PropertyDescriptor>();
        //    Type thisType = this.GetType();
        //    PropertyInfo[] pis = thisType.GetProperties();
        //    foreach (PropertyInfo p in pis)
        //    {
        //        if (p.DeclaringType == thisType )
        //        {
        //            if (p.DeclaringType == thisType || p.PropertyType.ToString() == "System.Drawing.Color")
        //            {
        //                //判断属性是否显示 
        //                BrowsableAttribute Browsable = (BrowsableAttribute)Attribute.GetCustomAttribute(p, typeof(BrowsableAttribute));
        //                if (Browsable != null)
        //                {
        //                    if (Browsable.Browsable == true || p.PropertyType.ToString() == "System.Drawing.Color")
        //                    {
        //                        PropertyStub psd = new PropertyStub(p, attributes);
        //                        props.Add(psd);
        //                    }
        //                }
        //                else
        //                {
        //                    PropertyStub psd = new PropertyStub(p, attributes);
        //                    props.Add(psd);
        //                }
        //            }
        //        }
        //    }
        //    //PropertyDescriptor[] propArray = (PropertyDescriptor[])props.ToArray(typeof(PropertyDescriptor));
        //    PropertyDescriptor[] propArray = props.ToArray();
        //    return new PropertyDescriptorCollection(propArray);           
        //}

        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
        {
            PropertyDescriptorCollection pdcs = new PropertyDescriptorCollection(null);
            //List<PropertyDescriptor> props = new List<PropertyDescriptor>();
            Type thisType = this.GetType();
            PropertyInfo[] pis = thisType.GetProperties();
            foreach (PropertyInfo p in pis)
            {
                if (p.DeclaringType == thisType)
                {
                    if (p.DeclaringType == thisType || p.PropertyType.ToString() == "System.Drawing.Color")
                    {
                        //判断属性是否显示 
                        BrowsableAttribute Browsable = (BrowsableAttribute)Attribute.GetCustomAttribute(p, typeof(BrowsableAttribute));
                        if (Browsable != null)
                        {//颜色是非可视的
                            if (Browsable.Browsable == true || p.PropertyType.ToString() == "System.Drawing.Color")
                            {
                                PropertyStub psd = new PropertyStub(p, attributes);
                                pdcs.Add(psd);
                            }
                        }
                        else
                        {
                            PropertyStub psd = new PropertyStub(p, attributes);
                            pdcs.Add(psd);
                        }
                    }
                }
            }
            //PropertyDescriptor[] propArray = (PropertyDescriptor[])props.ToArray(typeof(PropertyDescriptor));
           // PropertyDescriptor[] propArray = props.ToArray();
           // return new PropertyDescriptorCollection(propArray);
            return pdcs;
        }


        object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }
        #endregion
    }
    /// <summary> 
    /// 下面这段代码来源于：http://www.bluespace.cn/Html/Csdn/2_47/View_4702219.html 
    /// </summary> 
    #region PropertyStub 定义
    class PropertyStub :  PropertyDescriptor
    {
        PropertyInfo info;
        public PropertyStub(PropertyInfo propertyInfo, Attribute[] attrs)
            : base(propertyInfo.Name, attrs)
        {
            this.info = propertyInfo;
        }
        public override Type ComponentType
        {
            get { return this.info.ReflectedType; }
        }
        public override bool IsReadOnly
        {
            get { return this.info.CanWrite == false; }
        }
        public override Type PropertyType
        {
            get { return this.info.PropertyType; }
        }
        public override bool CanResetValue(object component)
        {
            return false;
        }
        public override object GetValue(object component)
        {
            //Console.WriteLine("GetValue: " + component.GetHashCode()); 
            try
            {
                return this.info.GetValue(component, null);
            }
            catch
            {
                return null;
            }
        }
        public override void ResetValue(object component)
        {
        }
        public override void SetValue(object component, object value)
        {
            //Console.WriteLine("SetValue: " + component.GetHashCode()); 
            this.info.SetValue(component, value, null);
        }
        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }
        //通过重载下面这个属性，可以将属性在PropertyGrid中的显示设置成中文 
        public override string DisplayName
        {
            get
            {
                string disp = "";  
                if (info != null)
                {                    
                    NativeNameAttibute attr = (NativeNameAttibute)Attribute.GetCustomAttribute(info, typeof(NativeNameAttibute));
                    if (attr != null)
                        disp = attr.NativeName;
                    else
                        disp = info.Name;
                }
                return disp;
            }
        }

        public override string Category
        {
            get
            {
                string cate = null;
                if (info != null)
                {
                    CategoryAttribute attr = (CategoryAttribute)Attribute.GetCustomAttribute(info, typeof(CategoryAttribute));
                    if (attr != null)
                        cate = attr.Category;
                }
                return cate;
            }
        }

        public override string Description 
        {
            get
            {
                string desc = null;
                if (info != null)
                {
                    DescriptionAttribute attr = (DescriptionAttribute)Attribute.GetCustomAttribute(info, typeof(DescriptionAttribute));
                    if (attr != null)
                        desc = attr.Description;
                }
                return desc;
            }
        }

        public override bool IsBrowsable 
        {
            get
            {
                bool flag = true;
                if (info != null)
                {
                    BrowsableAttribute attr = (BrowsableAttribute)Attribute.GetCustomAttribute(info, typeof(BrowsableAttribute));
                    if (attr != null)
                        flag = attr.Browsable;
                }
                return flag;
            }
        }

        public override bool IsLocalizable
        {
            get
            {
                bool flag = true;
                if (info != null)
                {
                    LocalizableAttribute attr = (LocalizableAttribute)Attribute.GetCustomAttribute(info, typeof(LocalizableAttribute));
                    if (attr != null)
                        flag = attr.IsLocalizable;
                }
                return flag;
            }
        }
    }
    #endregion

   
}
