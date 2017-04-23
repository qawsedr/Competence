using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competence
{
    // A class to help populate a list for people that is not yet connected to a specific role - using OUTER JOIN on table Person_x_Role
    public class PersonPXR
    {
        public int p_ID { get; set; }
        public string p_personRef { get; set; }
        public string p_Display { get; set; }
        public string p_FirstName { get; set; }
        public string p_LastName { get; set; }
    }
}
