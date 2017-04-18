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
    public partial class PersonEditForm : Form
    {
        public Person p;
        public PersonEditForm()
        {
            InitializeComponent();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            p.p_PersonRef = p_PersonRefTextBox.Text;
            p.p_FirstName = p_FirstNameTextBox.Text;
            p.p_LastName = p_LastNameTextBox.Text;
            p.p_Display = p_DisplayTextBox.Text;
        }

        private void PersonEditForm_Load(object sender, EventArgs e)
        {
            if (p != null)
            {
                p_PersonRefTextBox.Text = p.p_PersonRef;
                p_FirstNameTextBox.Text = p.p_FirstName;
                p_LastNameTextBox.Text = p.p_LastName;
                p_DisplayTextBox.Text = p.p_Display;
            }
        }
    }
}
