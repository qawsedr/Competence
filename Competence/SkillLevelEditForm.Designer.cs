namespace Competence
{
    partial class SkillLevelEditForm
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
            System.Windows.Forms.Label LabelSkillLevelDisplay;
            System.Windows.Forms.Label LabelSkillLevelDescription;
            System.Windows.Forms.Label LabelSkillLevel;
            System.Windows.Forms.Label labelSkillLevelQualificationDuration;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSkillDisplay = new System.Windows.Forms.Label();
            this.TextDuration = new System.Windows.Forms.TextBox();
            this.comboLevel = new System.Windows.Forms.ComboBox();
            this.skillLevelEnumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TextDisplay = new System.Windows.Forms.TextBox();
            this.TextDescription = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            LabelSkillLevelDisplay = new System.Windows.Forms.Label();
            LabelSkillLevelDescription = new System.Windows.Forms.Label();
            LabelSkillLevel = new System.Windows.Forms.Label();
            labelSkillLevelQualificationDuration = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillLevelEnumBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelSkillLevelDisplay
            // 
            LabelSkillLevelDisplay.AutoSize = true;
            LabelSkillLevelDisplay.Location = new System.Drawing.Point(13, 77);
            LabelSkillLevelDisplay.Name = "LabelSkillLevelDisplay";
            LabelSkillLevelDisplay.Size = new System.Drawing.Size(44, 13);
            LabelSkillLevelDisplay.TabIndex = 2;
            LabelSkillLevelDisplay.Text = "Display:";
            // 
            // LabelSkillLevelDescription
            // 
            LabelSkillLevelDescription.AutoSize = true;
            LabelSkillLevelDescription.Location = new System.Drawing.Point(13, 103);
            LabelSkillLevelDescription.Name = "LabelSkillLevelDescription";
            LabelSkillLevelDescription.Size = new System.Drawing.Size(63, 13);
            LabelSkillLevelDescription.TabIndex = 8;
            LabelSkillLevelDescription.Text = "Description:";
            // 
            // LabelSkillLevel
            // 
            LabelSkillLevel.AutoSize = true;
            LabelSkillLevel.Location = new System.Drawing.Point(13, 51);
            LabelSkillLevel.Name = "LabelSkillLevel";
            LabelSkillLevel.Size = new System.Drawing.Size(36, 13);
            LabelSkillLevel.TabIndex = 20;
            LabelSkillLevel.Text = "Level:";
            // 
            // labelSkillLevelQualificationDuration
            // 
            labelSkillLevelQualificationDuration.AutoSize = true;
            labelSkillLevelQualificationDuration.Location = new System.Drawing.Point(13, 129);
            labelSkillLevelQualificationDuration.Name = "labelSkillLevelQualificationDuration";
            labelSkillLevelQualificationDuration.Size = new System.Drawing.Size(50, 13);
            labelSkillLevelQualificationDuration.TabIndex = 22;
            labelSkillLevelQualificationDuration.Text = "Duration:";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 207);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelSkillDisplay);
            this.panel1.Controls.Add(labelSkillLevelQualificationDuration);
            this.panel1.Controls.Add(this.TextDuration);
            this.panel1.Controls.Add(this.comboLevel);
            this.panel1.Controls.Add(LabelSkillLevelDisplay);
            this.panel1.Controls.Add(this.TextDisplay);
            this.panel1.Controls.Add(LabelSkillLevelDescription);
            this.panel1.Controls.Add(this.TextDescription);
            this.panel1.Controls.Add(LabelSkillLevel);
            this.panel1.Location = new System.Drawing.Point(3, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 159);
            this.panel1.TabIndex = 0;
            // 
            // labelSkillDisplay
            // 
            this.labelSkillDisplay.AutoSize = true;
            this.labelSkillDisplay.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSkillDisplay.Location = new System.Drawing.Point(104, 2);
            this.labelSkillDisplay.Name = "labelSkillDisplay";
            this.labelSkillDisplay.Size = new System.Drawing.Size(83, 33);
            this.labelSkillDisplay.TabIndex = 23;
            this.labelSkillDisplay.Text = "saasdf";
            // 
            // TextDuration
            // 
            this.TextDuration.AcceptsReturn = true;
            this.TextDuration.Location = new System.Drawing.Point(110, 126);
            this.TextDuration.Name = "TextDuration";
            this.TextDuration.Size = new System.Drawing.Size(79, 20);
            this.TextDuration.TabIndex = 21;
            // 
            // comboLevel
            // 
            this.comboLevel.DataSource = this.skillLevelEnumBindingSource;
            this.comboLevel.DisplayMember = "SkillLevel";
            this.comboLevel.FormattingEnabled = true;
            this.comboLevel.Location = new System.Drawing.Point(110, 47);
            this.comboLevel.Name = "comboLevel";
            this.comboLevel.Size = new System.Drawing.Size(230, 21);
            this.comboLevel.TabIndex = 1;
            this.comboLevel.ValueMember = "SkillLevel";
            // 
            // skillLevelEnumBindingSource
            // 
            this.skillLevelEnumBindingSource.DataSource = typeof(Competence.SkillLevelEnum);
            // 
            // TextDisplay
            // 
            this.TextDisplay.Location = new System.Drawing.Point(110, 74);
            this.TextDisplay.Name = "TextDisplay";
            this.TextDisplay.Size = new System.Drawing.Size(230, 20);
            this.TextDisplay.TabIndex = 2;
            // 
            // TextDescription
            // 
            this.TextDescription.Location = new System.Drawing.Point(110, 100);
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.Size = new System.Drawing.Size(230, 20);
            this.TextDescription.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(366, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 167);
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
            // SkillLevelEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 207);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SkillLevelEditForm";
            this.Text = "Edit skill level";
            this.Load += new System.EventHandler(this.SkillLevelEditForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillLevelEnumBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboLevel;
        private System.Windows.Forms.TextBox TextDisplay;
        private System.Windows.Forms.TextBox TextDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelSkillDisplay;
        private System.Windows.Forms.TextBox TextDuration;
        private System.Windows.Forms.BindingSource skillLevelEnumBindingSource;
    }
}