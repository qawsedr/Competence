namespace Competence
{
    partial class PersonEditForm
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
            System.Windows.Forms.Label p_FirstNameLabel;
            System.Windows.Forms.Label p_LastNameLabel;
            System.Windows.Forms.Label p_PersonRefLabel;
            System.Windows.Forms.Label label1;
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_DisplayTextBox = new System.Windows.Forms.TextBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.p_LastNameTextBox = new System.Windows.Forms.TextBox();
            this.p_PersonRefTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            p_FirstNameLabel = new System.Windows.Forms.Label();
            p_LastNameLabel = new System.Windows.Forms.Label();
            p_PersonRefLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_FirstNameLabel
            // 
            p_FirstNameLabel.AutoSize = true;
            p_FirstNameLabel.Location = new System.Drawing.Point(13, 41);
            p_FirstNameLabel.Name = "p_FirstNameLabel";
            p_FirstNameLabel.Size = new System.Drawing.Size(58, 13);
            p_FirstNameLabel.TabIndex = 2;
            p_FirstNameLabel.Text = "First name:";
            // 
            // p_LastNameLabel
            // 
            p_LastNameLabel.AutoSize = true;
            p_LastNameLabel.Location = new System.Drawing.Point(13, 67);
            p_LastNameLabel.Name = "p_LastNameLabel";
            p_LastNameLabel.Size = new System.Drawing.Size(59, 13);
            p_LastNameLabel.TabIndex = 8;
            p_LastNameLabel.Text = "Last name:";
            // 
            // p_PersonRefLabel
            // 
            p_PersonRefLabel.AutoSize = true;
            p_PersonRefLabel.Location = new System.Drawing.Point(13, 15);
            p_PersonRefLabel.Name = "p_PersonRefLabel";
            p_PersonRefLabel.Size = new System.Drawing.Size(91, 13);
            p_PersonRefLabel.TabIndex = 10;
            p_PersonRefLabel.Text = "Person reference:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 95);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 13);
            label1.TabIndex = 13;
            label1.Text = "Signature:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.p_DisplayTextBox);
            this.panel1.Controls.Add(p_FirstNameLabel);
            this.panel1.Controls.Add(this.p_FirstNameTextBox);
            this.panel1.Controls.Add(p_LastNameLabel);
            this.panel1.Controls.Add(this.p_LastNameTextBox);
            this.panel1.Controls.Add(p_PersonRefLabel);
            this.panel1.Controls.Add(this.p_PersonRefTextBox);
            this.panel1.Location = new System.Drawing.Point(3, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 137);
            this.panel1.TabIndex = 0;
            // 
            // p_DisplayTextBox
            // 
            this.p_DisplayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "p_LastName", true));
            this.p_DisplayTextBox.Location = new System.Drawing.Point(110, 92);
            this.p_DisplayTextBox.Name = "p_DisplayTextBox";
            this.p_DisplayTextBox.Size = new System.Drawing.Size(230, 20);
            this.p_DisplayTextBox.TabIndex = 4;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Competence.Person);
            // 
            // p_FirstNameTextBox
            // 
            this.p_FirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "p_FirstName", true));
            this.p_FirstNameTextBox.Location = new System.Drawing.Point(110, 38);
            this.p_FirstNameTextBox.Name = "p_FirstNameTextBox";
            this.p_FirstNameTextBox.Size = new System.Drawing.Size(230, 20);
            this.p_FirstNameTextBox.TabIndex = 2;
            // 
            // p_LastNameTextBox
            // 
            this.p_LastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "p_LastName", true));
            this.p_LastNameTextBox.Location = new System.Drawing.Point(110, 64);
            this.p_LastNameTextBox.Name = "p_LastNameTextBox";
            this.p_LastNameTextBox.Size = new System.Drawing.Size(230, 20);
            this.p_LastNameTextBox.TabIndex = 3;
            // 
            // p_PersonRefTextBox
            // 
            this.p_PersonRefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "p_PersonRef", true));
            this.p_PersonRefTextBox.Location = new System.Drawing.Point(110, 12);
            this.p_PersonRefTextBox.Name = "p_PersonRefTextBox";
            this.p_PersonRefTextBox.Size = new System.Drawing.Size(230, 20);
            this.p_PersonRefTextBox.TabIndex = 1;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(516, 177);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(434, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 137);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(1, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PersonEditForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 177);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PersonEditForm";
            this.Text = "Edit person";
            this.Load += new System.EventHandler(this.PersonEditForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TextBox p_FirstNameTextBox;
        private System.Windows.Forms.TextBox p_LastNameTextBox;
        private System.Windows.Forms.TextBox p_PersonRefTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox p_DisplayTextBox;
    }
}