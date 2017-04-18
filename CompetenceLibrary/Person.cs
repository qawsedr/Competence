using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competence
{
    public class Person
    {
        public int p_ID { get; set; }
        public string p_PersonRef { get; set; }
        public string p_FirstName { get; set; }
        public string p_LastName { get; set; }
        public string p_Display { get; set; }
        public bool p_Active { get; set; } = true;
        public string p_FullInfo
        {
            get
            {
                return $"{ p_PersonRef } - { p_FirstName } { p_LastName }";
            }
        }
    }
}
