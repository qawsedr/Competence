using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competence
{
    public class SkillLevel
    {
        public int sl_ID { get; set; }
        public string sl_Description { get; set; }
        public int sl_Order { get; set; }
        public string sl_Level { get; set; }
        public int sl_SkillID { get; set; }
        public string sl_Display { get; set; }
        public int? sl_ValidityDurationMonths { get; set; }
        public int? sl_TrainingDocumentID { get; set; }
        public bool sl_Active { get; set; } = true;
    }
}
