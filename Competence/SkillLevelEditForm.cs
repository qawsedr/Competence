using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Competence
{
    public partial class SkillLevelEditForm : Form
    {
        DataAccess db = new DataAccess();
        public SkillLevel sl;
        Skill _s;
        public SkillLevelEditForm(Skill s)
        {
            InitializeComponent();
            _s = s;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sl.sl_Level = comboLevel.Text;
            sl.sl_Display = TextDisplay.Text;
            sl.sl_Description = TextDescription.Text;
            try
            {
                sl.sl_ValidityDurationMonths = int.Parse(TextDuration.Text);
                //if (sl.sl_ValidityDurationMonths = 0)
                //{
                //    sl.sl_ValidityDurationMonths = null;
                //}

            }
            catch (Exception ex)
            {
                if (TextDuration.Text != null)
                {
                    if (TextDuration.Text == "")
                    {
                        sl.sl_ValidityDurationMonths = null;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            sl.sl_SkillID = _s.s_ID;

        }

        private void SkillLevelEditForm_Load(object sender, EventArgs e)
        {
            if (sl != null)
            {
                skillLevelEnumBindingSource.DataSource = db.SkillLevelEnumGet();
                labelSkillDisplay.Text = _s.s_Display;
                comboLevel.Text = sl.sl_Level;
                TextDisplay.Text = sl.sl_Display;
                TextDescription.Text = sl.sl_Description;
                TextDuration.Text = sl.sl_ValidityDurationMonths.ToString();
            }

        }
    }
}
