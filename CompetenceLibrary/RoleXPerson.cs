using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competence
{
    public class RoleXPerson
    {
        public int x_ID { get; set; }
        public int p_ID { get; set; }
        public string p_PersonRef { get; set; }
        public string p_FirstName { get; set; }
        public string p_LastName { get; set; }
        public string p_Display { get; set; }
        public int r_ID { get; set; }
        public string r_Description { get; set; }
        public string r_Display { get; set; }
    }
}
