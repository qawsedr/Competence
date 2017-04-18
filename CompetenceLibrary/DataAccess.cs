using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Windows.Forms;

namespace Competence    
{
    public class DataAccess
    {
        public List<Person> GetPeople()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
            {
                return connection.Query<Person>("dbo.spPeopleGet").ToList();
            }
        }

        public void InsertPerson(Person p)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    List<Person> personList = new List<Person>();
                    personList.Add(p);
                    connection.Execute("dbo.spPersonAdd @p_ID, @p_PersonRef, @p_FirstName, @p_LastName, @p_Display, @p_Active", personList);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public object GetRoles()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
            {
                return connection.Query<Role>("dbo.spRolesGet").ToList();
            }
        }

        public List<SkillCategory> GetSkillCategories()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
            {
                return connection.Query<SkillCategory>("dbo.spSkillCategoriesGet").ToList();
            }
        }

        public object SkillLevelEnumGet()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
            {
                return connection.Query<SkillLevelEnum>("dbo.spSkillLevelEnumGet").ToList();
            }
        }

        public List<Skill> GetSkills()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
            {
                return connection.Query<Skill>("dbo.spSkillsGet").ToList();
            }
        }

        public void UpdatePerson(Person p)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    List<Person> personList = new List<Person>();
                    personList.Add(p);
                    connection.Execute("dbo.spPersonUpdate @p_ID, @p_PersonRef, @p_FirstName, @p_LastName, @p_Display, @p_Active", personList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertSkill(Skill s)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    List<Skill> skillList = new List<Skill>();
                    skillList.Add(s);
                    connection.Execute("dbo.spSkillAdd @s_ID, @s_Category, @s_Display, @s_Description", skillList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateSkill(Skill s)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    List<Skill> skillList = new List<Skill>();
                    skillList.Add(s);
                    connection.Execute("dbo.spSkillUpdate @s_ID, @s_Category, @s_Display, @s_Description, @s_Active", skillList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<SkillLevel> GetSkillLevels(Skill s)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
            {
                if (s != null)
                {
                    return connection.Query<SkillLevel>("dbo.spSkillLevelGet @sl_SkillID, @sl_Active", new { sl_SkillID = s.s_ID , sl_Active = true } ).ToList();
                }
                else return null;
            }
        }

        public void InsertSkillLevel(SkillLevel sl)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    List<SkillLevel> skillLevelList = new List<SkillLevel>();
                    skillLevelList.Add(sl);
                    connection.Execute("dbo.spSkillLevelAdd @sl_ID, @sl_Description, @sl_Order, @sl_Level, @sl_SkillID, @sl_Display, @sl_ValidityDurationMonths, @sl_TrainingDocumentID, @sl_Active", skillLevelList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateSkillLevel(SkillLevel obj)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    List<SkillLevel> slList = new List<SkillLevel>();
                    slList.Add(obj);
                    connection.Execute("dbo.spSkillLevelUpdate @sl_ID, @sl_Description, @sl_Order, @sl_Level, @sl_SkillID, @sl_Display, @sl_ValidityDurationMonths, @sl_TrainingDocumentID, @sl_Active", slList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertRole(Role r)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    List<Role> roleList = new List<Role>();
                    roleList.Add(r);
                    connection.Execute("dbo.spRoleAdd @r_ID, @r_Description, @r_Display", roleList);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateRole(Role obj)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    List<Role> roleList = new List<Role>();
                    roleList.Add(obj);
                    connection.Execute("dbo.spRoleUpdate @r_ID, @r_Description, @r_Display", roleList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteRole(Role obj)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    //List<Role> roleList = new List<Role>();
                    //roleList.Add(obj);
                    connection.Execute("dbo.spRoleDelete @r_ID", new { r_ID = obj.r_ID });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
