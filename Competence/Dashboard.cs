using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Competence
{
    public partial class CompetenceUI : Form
    {
        internal DataAccess db = new DataAccess();
        public CompetenceUI()
        {
            InitializeComponent();
            PopulatePeopleList();
            PopulateSkillsList();
            PopulateRolesList();
        }

        private void PopulateRolesList()
        {
         //   DataAccess db = new DataAccess();
            roleBindingSource.DataSource = db.GetRoles();
        }

        private void PopulateSkillsList()
        {
            //   DataAccess db = new DataAccess();
            dgvSkills.Visible = false;
            skillBindingSource.DataSource = db.GetSkills();
            dgvSkills.Visible = true;
        }

        public void PopulatePeopleList()
        {
         //   DataAccess db = new DataAccess();
            personBindingSource.DataSource = db.GetPeople();
        }

         private void btnPersonAdd_Click(object sender, EventArgs e)
        {
            using (PersonEditForm frmEditPerson = new PersonEditForm() { p = new Person() })
            {
                if (frmEditPerson.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    db.InsertPerson(frmEditPerson.p);
                    personBindingSource.DataSource = db.GetPeople();
                    personBindingSource.MoveLast();
                }
            }
        }


        private void btnPersonEdit_Click(object sender, EventArgs e)
        {
            Person obj = personBindingSource.Current as Person;
            if (obj !=null)
            {
                using (PersonEditForm editForm = new PersonEditForm() { p = obj })
                {
                    if (editForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        personBindingSource.EndEdit();
                        DataAccess db = new DataAccess();
                        db.UpdatePerson(obj);
                        personBindingSource.ResetBindings(false);
                        btnEdit.Focus();
                    }
                }
            }
        }

        private void btnPersonDel_Click(object sender, EventArgs e)
        {
            Person obj = personBindingSource.Current as Person;
            if (obj != null)
            {
                if (MessageBox.Show(string.Format("Please confirm the removal of {0} {1} from the list.",obj.p_FirstName,obj.p_LastName), "Deleting record",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)  == DialogResult.OK)
                {

                    obj.p_Active = false;
                    DataAccess db = new DataAccess();
                    db.UpdatePerson(obj);
                    personBindingSource.RemoveCurrent();
                }
            }
        }

        private void btnSkillAdd_Click(object sender, EventArgs e)
        {
            using (SkillEditForm frm = new SkillEditForm() { s = new Skill() })
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    db.InsertSkill(frm.s);
                    skillBindingSource.DataSource = db.GetSkills();
                    skillBindingSource.MoveLast();
                }
            }
        }

        private void btnSkillEdit_Click(object sender, EventArgs e)
        {
            Skill obj = skillBindingSource.Current as Skill;
            if (obj != null)
            {
                using (SkillEditForm frm = new SkillEditForm() { s = obj })
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        skillBindingSource.EndEdit();
                        //DataAccess db = new DataAccess();
                        db.UpdateSkill(obj);
                        PopulateSkillsList();
                        //skillBindingSource.ResetBindings(false);
                        btnEdit.Focus();
                    }
                }
            }
        }

        private void btnSkillDelete_Click(object sender, EventArgs e)
        {
            Skill obj = skillBindingSource.Current as Skill;
            if (obj != null)
            {
                if (MessageBox.Show(string.Format("Please confirm the removal of skill '{0}' from the list.", obj.s_Display), "Deleting record", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    obj.s_Active = false;
                    db.UpdateSkill(obj);
                    skillBindingSource.RemoveCurrent();
                }
            }
        }

        private void dgvSkills_SelectionChanged(object sender, EventArgs e)
        {
            skillLevelBindingSource.DataSource = db.GetSkillLevels(skillBindingSource.Current as Skill);
        }
        private void btnLevelAdd_Click(object sender, EventArgs e)
        {
            using (SkillLevelEditForm frm = new SkillLevelEditForm(skillBindingSource.Current as Skill) { sl = new SkillLevel() })
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    db.InsertSkillLevel(frm.sl);
                    skillLevelBindingSource.DataSource = db.GetSkillLevels(skillBindingSource.Current as Skill);
                    skillLevelBindingSource.MoveLast();
                }
            }
        }

        private void btnLevelEdit_Click(object sender, EventArgs e)
        {
            SkillLevel obj = skillLevelBindingSource.Current as SkillLevel;
            if (obj != null)
            {
                using (SkillLevelEditForm frm = new SkillLevelEditForm(skillBindingSource.Current as Skill) { sl = obj })
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        skillLevelBindingSource.EndEdit();
                        db.UpdateSkillLevel(obj);
                        PopulateSkillsList();
                        btnEdit.Focus();
                    }
                }
            }
        }

        private void btnLevelDelete_Click(object sender, EventArgs e)
        {
            SkillLevel obj = skillLevelBindingSource.Current as SkillLevel;
            if (obj != null)
            {
                if (MessageBox.Show(string.Format("Please confirm the removal of skill '{0}' from the list.", obj.sl_Display), "Deleting record", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    obj.sl_Active = false;
                    db.UpdateSkillLevel(obj);
                    skillLevelBindingSource.RemoveCurrent();
                }
            }
        }

        private void btnRoleAdd_Click(object sender, EventArgs e)
        {
            using (RoleEditForm frm = new RoleEditForm() { r = new Role() })
            {
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    db.InsertRole(frm.r);
                    roleBindingSource.DataSource = db.GetRoles();
                    roleBindingSource.MoveLast();
                }
            }
        }

        private void btnRoleEdit_Click(object sender, EventArgs e)
        {
            Role obj = roleBindingSource.Current as Role;
            if (obj != null)
            {
                using (RoleEditForm frm = new RoleEditForm() { r = obj })
                {
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        roleBindingSource.EndEdit();
                        db.UpdateRole(obj);
                        roleBindingSource.ResetBindings(false);
                        btnEdit.Focus();
                    }
                }
            }
        }

        private void btnRoleDelete_Click(object sender, EventArgs e)
        {
            Role obj = roleBindingSource.Current as Role;
            if (obj != null)
            {
                if (MessageBox.Show(string.Format("Please confirm the removal of skill '{0}' from the list.", obj.r_Display), "Deleting record", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    db.DeleteRole(obj);
                    roleBindingSource.RemoveCurrent();
                }
            }
        }
    }
}
