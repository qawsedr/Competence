namespace Competence
{
    partial class ReqPersonSelectForm
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
            this.dgvPersonSelect = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personPXRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonSelect)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.dgvPersonSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 221);
            this.panel1.TabIndex = 0;
            // 
            // dgvPersonSelect
            // 
            this.dgvPersonSelect.AllowUserToAddRows = false;
            this.dgvPersonSelect.AllowUserToDeleteRows = false;
            this.dgvPersonSelect.AllowUserToOrderColumns = true;
            this.dgvPersonSelect.AutoGenerateColumns = false;
            this.dgvPersonSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pFirstNameDataGridViewTextBoxColumn,
            this.pLastNameDataGridViewTextBoxColumn,
            this.Add});
            this.dgvPersonSelect.DataSource = this.personPXRBindingSource;
            this.dgvPersonSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersonSelect.Location = new System.Drawing.Point(0, 0);
            this.dgvPersonSelect.Name = "dgvPersonSelect";
            this.dgvPersonSelect.RowHeadersVisible = false;
            this.dgvPersonSelect.RowHeadersWidth = 20;
            this.dgvPersonSelect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPersonSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonSelect.Size = new System.Drawing.Size(468, 221);
            this.dgvPersonSelect.TabIndex = 14;
            this.dgvPersonSelect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonSelect_CellContentClick);
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
            // pFirstNameDataGridViewTextBoxColumn
            // 
            this.pFirstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pFirstNameDataGridViewTextBoxColumn.DataPropertyName = "p_FirstName";
            this.pFirstNameDataGridViewTextBoxColumn.FillWeight = 40F;
            this.pFirstNameDataGridViewTextBoxColumn.HeaderText = "First name";
            this.pFirstNameDataGridViewTextBoxColumn.Name = "pFirstNameDataGridViewTextBoxColumn";
            // 
            // pLastNameDataGridViewTextBoxColumn
            // 
            this.pLastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pLastNameDataGridViewTextBoxColumn.DataPropertyName = "p_LastName";
            this.pLastNameDataGridViewTextBoxColumn.FillWeight = 40F;
            this.pLastNameDataGridViewTextBoxColumn.HeaderText = "Last name";
            this.pLastNameDataGridViewTextBoxColumn.Name = "pLastNameDataGridViewTextBoxColumn";
            // 
            // personPXRBindingSource
            // 
            this.personPXRBindingSource.DataSource = typeof(Competence.PersonPXR);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Competence.Person);
            // 
            // PersonSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PersonSelectForm";
            this.Text = "PersonSelectForm";
            this.Load += new System.EventHandler(this.PersonSelectForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonSelect)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personPXRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvPersonSelect;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.BindingSource personPXRBindingSource;
    }
}