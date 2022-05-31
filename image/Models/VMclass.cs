using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace image.Models
{
    public class VMclass
    {
        public int md_id { get; set; }
        public string m_title_name { get; set; }
        public string Category_id { get; set; }
        public string Category_type_id { get; set; }
        public string version_id { get; set; }
        public string image_path { get; set; }
        public Nullable<System.DateTime> year { get; set; }
    }
}