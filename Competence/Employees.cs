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
    public partial class EmployeesForm : Form
    {
        List<Person> empList = new List<Person>();
        public EmployeesForm()
        {
            InitializeComponent();
            PopulateList();
            UpdateBinding();
        }

        private void PopulateList()
        {
            DataAccess db = new DataAccess();
            empList = db.GetPeople();
        }

        private void UpdateBinding()
        {
            employeesGridView.DataSource = empList;
            //employeesGridView.DataMember = "p_Display";
            listBox1.DataSource = empList;
            listBox1.DisplayMember = "p_FullInfo";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateBinding();
        }
    }
}
