using System.ComponentModel;
using System.Drawing;

namespace easyChart
{
    public class LineSettings
    {
        public string name { get; set; }

        [Description("曲线类型"),
         CategoryAttribute("曲线设置"),
         DefaultValueAttribute(0)]
        public int type { get; set; }

        [Description("曲线类型"),
         CategoryAttribute("曲线设置"),
         DefaultValueAttribute(0)]
        public int color { get; set; }
   
        [Description("Y轴标题"),
         CategoryAttribute("曲线设置"),
         DefaultValueAttribute(0)]
        public string y_label { get; set; }




        public bool bool_label { get; set; }
        public int label_step { get; set; }
        public int font_size { get; set; }
        public int label_float { get; set; }

        [BrowsableAttribute(false)]
        public int sub_lines_count { get; set; }

        public bool fan_zhuan_y { get; set; }

        public bool end_label { get; set; }

        public bool start_label { get; set; }

        public bool legend_flag { get; set; }

        public int legend_where { get; set; }

        public int label_where { get; set; }

        public bool label_color { get; set; }
        
    }
}