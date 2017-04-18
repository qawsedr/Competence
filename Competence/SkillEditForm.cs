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
    public partial class SkillEditForm : Form
    {
        DataAccess db = new DataAccess();
        public Skill s;
        public SkillEditForm()
        {
            InitializeComponent();
            skillCategoryBindingSource.DataSource=db.GetSkillCategories();
            //skillCategoryBindingSource.ResetBindings(false);
            //comboCategory.DataBindings.
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            s.s_Category = comboCategory.Text;
            s.s_Display = TextDisplay.Text;
            s.s_Description = TextDescription.Text;
        }

        private void SkillEditForm_Load(object sender, EventArgs e)
        {
            if (s != null)
            {
                comboCategory.Text = s.s_Category;
                TextDisplay.Text = s.s_Display;
                TextDescription.Text = s.s_Description;
            }
        }
    }
}
