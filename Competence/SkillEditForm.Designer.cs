namespace Competence
{
    partial class SkillEditForm
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
            System.Windows.Forms.Label LabelSkillDisplay;
            System.Windows.Forms.Label LabelSkillDescription;
            System.Windows.Forms.Label LabelSkillCategory;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.skillCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TextDisplay = new System.Windows.Forms.TextBox();
            this.TextDescription = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            LabelSkillDisplay = new System.Windows.Forms.Label();
            LabelSkillDescription = new System.Windows.Forms.Label();
            LabelSkillCategory = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillCategoryBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelSkillDisplay
            // 
            LabelSkillDisplay.AutoSize = true;
            LabelSkillDisplay.Enabled = false;
            LabelSkillDisplay.Location = new System.Drawing.Point(13, 41);
            LabelSkillDisplay.Name = "LabelSkillDisplay";
            LabelSkillDisplay.Size = new System.Drawing.Size(44, 13);
            LabelSkillDisplay.TabIndex = 2;
            LabelSkillDisplay.Text = "Display:";
            // 
            // LabelSkillDescription
            // 
            LabelSkillDescription.AutoSize = true;
            LabelSkillDescription.Enabled = false;
            LabelSkillDescription.Location = new System.Drawing.Point(13, 67);
            LabelSkillDescription.Name = "LabelSkillDescription";
            LabelSkillDescription.Size = new System.Drawing.Size(63, 13);
            LabelSkillDescription.TabIndex = 8;
            LabelSkillDescription.Text = "Description:";
            // 
            // LabelSkillCategory
            // 
            LabelSkillCategory.AutoSize = true;
            LabelSkillCategory.Enabled = false;
            LabelSkillCategory.Location = new System.Drawing.Point(13, 15);
            LabelSkillCategory.Name = "LabelSkillCategory";
            LabelSkillCategory.Size = new System.Drawing.Size(52, 13);
            LabelSkillCategory.TabIndex = 20;
            LabelSkillCategory.Text = "Category:";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(463, 261);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboCategory);
            this.panel1.Controls.Add(LabelSkillDisplay);
            this.panel1.Controls.Add(this.TextDisplay);
            this.panel1.Controls.Add(LabelSkillDescription);
            this.panel1.Controls.Add(this.TextDescription);
            this.panel1.Controls.Add(LabelSkillCategory);
            this.panel1.Location = new System.Drawing.Point(3, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 137);
            this.panel1.TabIndex = 0;
            // 
            // comboCategory
            // 
            this.comboCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.skillCategoryBindingSource, "sc_SkillCategory", true));
            this.comboCategory.DataSource = this.skillCategoryBindingSource;
            this.comboCategory.DisplayMember = "sc_SkillCategory";
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(110, 11);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(230, 21);
            this.comboCategory.TabIndex = 1;
            this.comboCategory.ValueMember = "sc_SkillCategory";
            // 
            // skillCategoryBindingSource
            // 
            this.skillCategoryBindingSource.DataSource = typeof(Competence.SkillCategory);
            // 
            // TextDisplay
            // 
            this.TextDisplay.Location = new System.Drawing.Point(110, 38);
            this.TextDisplay.Name = "TextDisplay";
            this.TextDisplay.Size = new System.Drawing.Size(230, 20);
            this.TextDisplay.TabIndex = 2;
            // 
            // TextDescription
            // 
            this.TextDescription.Location = new System.Drawing.Point(110, 64);
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.Size = new System.Drawing.Size(230, 20);
            this.TextDescription.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(381, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 221);
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
            // SkillEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SkillEditForm";
            this.Text = "Edit skill";
            this.Load += new System.EventHandler(this.SkillEditForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillCategoryBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextDisplay;
        private System.Windows.Forms.TextBox TextDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.BindingSource skillCategoryBindingSource;
    }
}