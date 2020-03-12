using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrbiumAPI.Model
{
    public class Forms
    {
        public int frm_Form { get; set; }
        public int frm_Operation { get; set; }
        public string frm_Name { get; set; }
        public string frm_Notes { get; set; }
        public bool frm_Enabled { get; set; }
        public DateTime frm_CreatedOn { get; set; }
        public int frm_CreatedBy { get; set; }
        public DateTime frm_ModifiedOn { get; set; }
        public int frm_ModifiedBy { get; set; }
    }
}
