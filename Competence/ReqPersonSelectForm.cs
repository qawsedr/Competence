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
    public partial class ReqPersonSelectForm : Form
    {
        DataAccess db = new DataAccess();
        public BindingSource bs { get; set; }
        Person pp = new Person();
        public Role r { get; set; } = new Role();
        public RoleXPerson rXp { get; set; }
        public ReqPersonSelectForm()
        {
            InitializeComponent();
        }

        private void dgvPersonSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                pp = personPXRBindingSource.Current as Person;
                rXp = new RoleXPerson();
                if (true)
                {
                    rXp.r_ID = r.r_ID;
                    rXp.p_ID = pp.p_ID;
                    db.InsertRoleXPerson(rXp);
                    bs.DataSource = db.GetRoleXPerson(r);
                    bs.ResetBindings(false);
                    bs.MoveLast();
                    personPXRBindingSource.DataSource = db.GetPeoplePXR(r);
                }
            }
        }

        private void PersonSelectForm_Load(object sender, EventArgs e)
        {
            personPXRBindingSource.DataSource = db.GetPeoplePXR(r);
        }
    }
}
