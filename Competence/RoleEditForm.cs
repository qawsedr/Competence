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
    public partial class RoleEditForm : Form
    {
        public Role r;
        public RoleEditForm()
        {
            InitializeComponent();
        }

        private void RoleEditForm_Load(object sender, EventArgs e)
        {
            if (r != null)
            {
                TextDisplay.Text = r.r_Display;
                TextDescription.Text = r.r_Description;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            r.r_Display = TextDisplay.Text;
            r.r_Description = TextDescription.Text;
        }
    }
}
