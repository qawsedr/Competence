using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competence
{
    public class RoleXReq
    {
        public int req_ID { get; set; }
        public int req_SkillLevelID { get; set; }
        public int req_RoleID { get; set; }
        public string sl_Display { get; set; }
        public string sl_Level { get; set; }
        public string s_Display { get; set; }
        public string r_Display { get; set; }

    }
}
