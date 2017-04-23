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
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    return connection.Query<Person>("dbo.spPeopleGet").ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
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

        public void InsertRequirement(RoleXReq rXreq)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    //List < { int, int}> personList = new List<{ int, int}>();
                    //personList.Add(p);
                    connection.Execute("dbo.spReqInsert @req_SkillLevelID, @req_RoleID", new { req_SkillLevelID = rXreq.req_SkillLevelID, req_RoleID = rXreq.req_RoleID });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public object GetReqInverse(Role r)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    return connection.Query<SkillLevel>("dbo.spReqInverseGet @RoleID", new { RoleID = r.r_ID }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public object GetPeoplePXR(Role r)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    return connection.Query<Person>("dbo.spPeoplePXRGet @RoleID", new { RoleID = r.r_ID }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public object GetReq(Role r)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    return connection.Query<RoleXReq>("dbo.spReqRoleGet @RoleID", new { RoleID = r.r_ID }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void InsertRoleXPerson(RoleXPerson rXp)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    //List < { int, int}> personList = new List<{ int, int}>();
                    //personList.Add(p);
                    connection.Execute("dbo.spRolesPeopleAdd @x_PersonID, @x_RoleID", new { x_PersonID = rXp.p_ID, x_RoleID = rXp.r_ID });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Role> GetRoles()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    return connection.Query<Role>("dbo.spRolesGet").ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<SkillCategory> GetSkillCategories()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    return connection.Query<SkillCategory>("dbo.spSkillCategoriesGet").ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<SkillLevelEnum> SkillLevelEnumGet()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    return connection.Query<SkillLevelEnum>("dbo.spSkillLevelEnumGet").ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Skill> GetSkills()
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    return connection.Query<Skill>("dbo.spSkillsGet").ToList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
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
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    if (s != null)
                    {
                        return connection.Query<SkillLevel>("dbo.spSkillLevelGet @sl_SkillID, @sl_Active", new { sl_SkillID = s.s_ID, sl_Active = true }).ToList();
                    }
                    else return null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
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

        public void DeleteRoleXReq(RoleXReq obj)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    connection.Execute("dbo.spReqDelete @req_ID", new { req_ID = obj.req_ID });
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
                    connection.Execute("dbo.spRoleDelete @r_ID", new { r_ID = obj.r_ID });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<RoleXPerson> GetRoleXPerson(Role role)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    if (role != null)
                    {
                        // Set parameter value = 0 to get all values
                        return connection.Query<RoleXPerson>("dbo.spRolesPeopleGet @x_RoleID, @x_PersonID", new { x_RoleID = role.r_ID, x_PersonID = 0 }).ToList();
                    }
                    else return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void DeleteRoleXPerson(RoleXPerson obj)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CompetenceDB")))
                {
                    connection.Execute("dbo.spRoleXPersonDelete @x_ID", new { x_ID = obj.x_ID });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
