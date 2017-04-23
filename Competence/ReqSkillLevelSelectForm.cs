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
    public partial class ReqSkillLevelSelectForm : Form
    {
        DataAccess db = new DataAccess();
        public BindingSource bs { get; set; }
        SkillLevel selSkillLevel = new SkillLevel();
        public Role r { get; set; } = new Role();
        public RoleXReq rXreq { get; set; }
        public ReqSkillLevelSelectForm()
        {
            InitializeComponent();
        }

       private void dgvRoleSkillSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                selSkillLevel = skillLevelBindingSource.Current as SkillLevel;
                rXreq = new RoleXReq();
                if (true)
                {
                    rXreq.req_RoleID = r.r_ID;
                    rXreq.req_SkillLevelID = selSkillLevel.sl_ID;
                    db.InsertRequirement(rXreq);
                    //Update datagridviews
                    bs.DataSource = db.GetReq(r);
                    bs.ResetBindings(false);
                    bs.MoveLast();
                    skillLevelBindingSource.DataSource = db.GetReqInverse(r);
                }
            }
        }

        private void ReqSkillLevelSelectForm_Load(object sender, EventArgs e)
        {
            skillLevelBindingSource.DataSource = db.GetReqInverse(r);
        }
    }
}
