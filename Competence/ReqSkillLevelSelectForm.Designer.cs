namespace Competence
{
    partial class ReqSkillLevelSelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRoleSkillSelect = new System.Windows.Forms.DataGridView();
            this.sDisplayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slDisplayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.skillLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.roleXReqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personPXRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleSkillSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillLevelBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleXReqBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personPXRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 261);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvRoleSkillSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 221);
            this.panel1.TabIndex = 0;
            // 
            // dgvRoleSkillSelect
            // 
            this.dgvRoleSkillSelect.AllowUserToAddRows = false;
            this.dgvRoleSkillSelect.AllowUserToDeleteRows = false;
            this.dgvRoleSkillSelect.AllowUserToOrderColumns = true;
            this.dgvRoleSkillSelect.AutoGenerateColumns = false;
            this.dgvRoleSkillSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoleSkillSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sDisplayDataGridViewTextBoxColumn,
            this.slLevelDataGridViewTextBoxColumn,
            this.slDisplayDataGridViewTextBoxColumn,
            this.Add});
            this.dgvRoleSkillSelect.DataSource = this.skillLevelBindingSource;
            this.dgvRoleSkillSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoleSkillSelect.Location = new System.Drawing.Point(0, 0);
            this.dgvRoleSkillSelect.Name = "dgvRoleSkillSelect";
            this.dgvRoleSkillSelect.RowHeadersVisible = false;
            this.dgvRoleSkillSelect.RowHeadersWidth = 20;
            this.dgvRoleSkillSelect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRoleSkillSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoleSkillSelect.Size = new System.Drawing.Size(468, 221);
            this.dgvRoleSkillSelect.TabIndex = 14;
            this.dgvRoleSkillSelect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoleSkillSelect_CellContentClick);
            // 
            // sDisplayDataGridViewTextBoxColumn
            // 
            this.sDisplayDataGridViewTextBoxColumn.DataPropertyName = "s_Display";
            this.sDisplayDataGridViewTextBoxColumn.HeaderText = "s_Display";
            this.sDisplayDataGridViewTextBoxColumn.Name = "sDisplayDataGridViewTextBoxColumn";
            this.sDisplayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slLevelDataGridViewTextBoxColumn
            // 
            this.slLevelDataGridViewTextBoxColumn.DataPropertyName = "sl_Level";
            this.slLevelDataGridViewTextBoxColumn.HeaderText = "sl_Level";
            this.slLevelDataGridViewTextBoxColumn.Name = "slLevelDataGridViewTextBoxColumn";
            // 
            // slDisplayDataGridViewTextBoxColumn
            // 
            this.slDisplayDataGridViewTextBoxColumn.DataPropertyName = "sl_Display";
            this.slDisplayDataGridViewTextBoxColumn.HeaderText = "sl_Display";
            this.slDisplayDataGridViewTextBoxColumn.Name = "slDisplayDataGridViewTextBoxColumn";
            // 
            // Add
            // 
            this.Add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Add.HeaderText = "Add";
            this.Add.Name = "Add";
            this.Add.Text = "+";
            this.Add.UseColumnTextForButtonValue = true;
            this.Add.Width = 30;
            // 
            // skillLevelBindingSource
            // 
            this.skillLevelBindingSource.DataSource = typeof(Competence.SkillLevel);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(477, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 221);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(1, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Close";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // roleXReqBindingSource
            // 
            this.roleXReqBindingSource.DataSource = typeof(Competence.RoleXReq);
            // 
            // personPXRBindingSource
            // 
            this.personPXRBindingSource.DataSource = typeof(Competence.PersonPXR);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Competence.Person);
            // 
            // ReqSkillLevelSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ReqSkillLevelSelectForm";
            this.Text = "Role skill selection";
            this.Load += new System.EventHandler(this.ReqSkillLevelSelectForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoleSkillSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillLevelBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roleXReqBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personPXRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvRoleSkillSelect;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingSource personPXRBindingSource;
        private System.Windows.Forms.BindingSource roleXReqBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDisplayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slDisplayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.BindingSource skillLevelBindingSource;
    }
}